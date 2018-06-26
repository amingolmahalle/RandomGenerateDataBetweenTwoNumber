using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeneratorData.BLL;
using GeneratorData.DAL;
using GeneratorData.DAL.Entity;

namespace GeneratorData
{
    /// <summary>
    /// Random number with fixed average in c#
    /// </summary>+
    public partial class Form1 : Form
    {
        #region Fields
        private bool _completed = true;
        private List<double> _copynomreList = new List<double>();
        private List<double> _sortcopynomreList = new List<double>();
        private SqlBuffer _buffer;
        private CalculationBll _calculation;
        #endregion

        #region Constructor
        public Form1()
        {
            InitializeComponent();
            FillControls();
        }
        #endregion

        #region Functions
        public void EnableControls(bool enabled)
        {
            pnlControls.Enabled = enabled;
            lstShow.Enabled = enabled;
        }
        public void ClearLabelControls()
        {           
            lblAvgGenerateData.Text = @"0";
            lblNumberOfTimesCount.Text = @"0";
            lblListShowCount.Text = @"0";
            lblMax.Text = @"0";
            lblMin.Text = @"0";
            lblTimeOperation.Text = @"0";
        }
        public void ClearTextBoxControls()
        {
            txtNumberStudents.Clear();
            txtFixedAvg.Clear();
            txtMax.Clear();
            txtMin.Clear();
        }
        public void ClearErrorProvider()
        {
            epCheckFiexdAverage.Clear();
            epCheckValueMinMax.Clear();
        }

        public void FillControls()
        {
            //---FillControl cmbGroup
            cmbGroup.DataSource = new ProjectBll().FillComboBoxControl("Group_tbl", "Id", "Name");
            cmbGroup.DisplayMember = "Name";
            cmbGroup.ValueMember = "Id";
        }

        public void ConfigProgressBar()
        {
            progressBar1.Visible = false;
            progressBar1.Maximum = 120;
            progressBar1.Style = ProgressBarStyle.Marquee;
        }
        public void ShowDataInListBox(List<double> nomreList, int adjustmentsVal)
        {
            foreach (var item in nomreList)
            {
                Invoke(new Action(() => lstShow.Items.Add(item)));
            }

            //max min value ListBox
            double max = Convert.ToDouble(lstShow.Items[0]);
            double min = max;

            foreach (var item in nomreList)
            {
                var cng = Convert.ToDouble(item);
                if (cng > max)
                    max = cng;
                else if (cng < min)
                    min = cng;
            }

            Invoke(new Action(() => lblMax.Text = max.ToString(CultureInfo.InvariantCulture)));
            Invoke(new Action(() => lblMin.Text = min.ToString(CultureInfo.InvariantCulture)));
            Invoke(new Action(() => lblAvgGenerateData.Text = nomreList.Average().ToString("##.##")));
            Invoke(new Action(() => lblNumberOfTimesCount.Text = adjustmentsVal.ToString()));
            Invoke(new Action(() => lblListShowCount.Text = lstShow.Items.Count.ToString()));
            Invoke(new Action(() => progressBar1.Visible = false));
        }
        public async Task ProgressAsync(DataEntryDomain workBookData)
        {
            _calculation = new CalculationBll();
            progressBar1.Visible = true;
            _completed = false;
            Stopwatch watch = Stopwatch.StartNew();
            List<double> nomreList = new List<double>();
            int adjustmentsVal = 0;

            await Task.Run(() => _calculation.ProccessGenerateData(workBookData, out nomreList, out adjustmentsVal, out _completed));
            _copynomreList = nomreList;
            await Task.Run(() => ShowDataInListBox(nomreList, adjustmentsVal));

            if (_completed)
            {
                watch.Stop();
                lblTimeOperation.Text = watch.ElapsedMilliseconds.ToString();
                EnableControls(true);
            }
        }

        public bool CheckError()
        {
            ClearErrorProvider();

            bool hasError = false;

            if (txtTolerance.Text.Trim() == string.Empty)
            {
                hasError = true;
            }
            else if (txtFixedAvg.Text.Trim() == string.Empty || txtFixedAvg.Text.Trim() == "0")
            {
                hasError = true;
            }
            else if (txtMax.Text.Trim() == string.Empty)
            {
                hasError = true;
            }
            else if (txtMin.Text.Trim() == string.Empty)
            {
                hasError = true;
            }
            else if (txtNumberStudents.Text.Trim() == string.Empty || txtNumberStudents.Text.Trim() == "0")
            {
                hasError = true;
            }
            else if (0 == (int)cmbGroup.SelectedValue)
            {
                hasError = true;
            }
            else if (0 == (int)cmbLesson.SelectedValue)
            {
                hasError = true;
            }
            if (int.Parse(txtMax.Text.Trim()) < int.Parse(txtMin.Text.Trim()))
            {
                hasError = true;
                epCheckValueMinMax.SetError(txtMin, MyMessage.IncorrectMinOrMax);
            }
            if (double.Parse(txtFixedAvg.Text.Trim()) < int.Parse(txtMin.Text.Trim()) || double.Parse(txtFixedAvg.Text.Trim()) > int.Parse(txtMax.Text.Trim()))
            {
                epCheckFiexdAverage.SetError(txtFixedAvg, MyMessage.InappropriateRangeAverage);
                hasError = true;
            }
            return hasError;
        }
        public bool InsertData(List<double> nomreListSorted,DataTable listStudents)
        {
            try
            {
                int numberStudents = 1001;
                _buffer = new SqlBuffer();
                foreach (var row in nomreListSorted)
                {
                    _buffer.AddQuery($@"INSERT INTO Workbook_tbl VALUES({int.Parse(cmbLesson.SelectedValue.ToString())},{row},{numberStudents})");
                    numberStudents += 1;
                }
                int resultCount = _buffer.WriteBufferToDb();

                if (resultCount > 0)
                    return true;

                return false;//else
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Events
        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!CheckError())
            {
                if (lstShow.Items.Count > 0)
                {
                    lstShow.Items.Clear();
                    ClearLabelControls();
                }
                EnableControls(false);

                DataEntryDomain workBook = new DataEntryDomain
                {
                    NumberStudents = Int32.Parse(txtNumberStudents.Text.Trim()),
                    Min = Double.Parse(txtMin.Text.Trim()),
                    Max = Double.Parse(txtMax.Text.Trim()),
                    FixedAvg = Double.Parse(txtFixedAvg.Text.Trim()),
                    Tolerance = Double.Parse(txtTolerance.Text.Trim())
                };

                await ProgressAsync(workBook);
            }
            else
            {
                MessageBox.Show(MyMessage.PleaseEnterData);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstShow.Items.Clear();
            cmbGroup.SelectedValue = 0;
            ClearTextBoxControls();
            ClearLabelControls();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNumberStudents.Select();
            ConfigProgressBar();
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(MyMessage.ConfirmInsertData, MyMessage.TitleMessageQuestion, MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

            if (_copynomreList != null && _copynomreList.Any())
            {
                var recordstudents = new ProjectBll().GetaAllDataTable("Student_Tbl");
                _sortcopynomreList = _copynomreList.OrderByDescending(o => o).ToList();
                MessageBox.Show(InsertData(_sortcopynomreList, recordstudents) ? MyMessage.OperationSuccessful : MyMessage.ErrorInsertData);
            }

            else
            {
                MessageBox.Show(MyMessage.ListEmpty);
            }
        }

        #endregion

        private void cmbGroup_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                //---FillControl cmbLesson
                cmbLesson.DataSource = new ProjectBll().FillComboBoxControlByFilter("Lesson_tbl", "Id", "Name", "Group_Id", int.Parse(cmbGroup.SelectedValue.ToString()));
                cmbLesson.DisplayMember = "Name";
                cmbLesson.ValueMember = "Id";
            }
            catch
            {
                // ignored
            }
        }
    }
}
