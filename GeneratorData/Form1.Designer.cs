namespace GeneratorData
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lstShow = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAvgGenerateData = new System.Windows.Forms.Label();
            this.lblNumberOfTimesCount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTimeOperation = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTolerance = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbLesson = new System.Windows.Forms.ComboBox();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFixedAvg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumberStudents = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblListShowCount = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.epCheckValueMinMax = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCheckFiexdAverage = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCheckValueMinMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCheckFiexdAverage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.Red;
            this.btnGenerate.Location = new System.Drawing.Point(4, 183);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(124, 36);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Start Generate Data";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lstShow
            // 
            this.lstShow.FormattingEnabled = true;
            this.lstShow.Location = new System.Drawing.Point(5, 279);
            this.lstShow.Name = "lstShow";
            this.lstShow.Size = new System.Drawing.Size(190, 472);
            this.lstShow.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Average GenerateData:";
            // 
            // lblAvgGenerateData
            // 
            this.lblAvgGenerateData.AutoSize = true;
            this.lblAvgGenerateData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgGenerateData.ForeColor = System.Drawing.Color.Navy;
            this.lblAvgGenerateData.Location = new System.Drawing.Point(203, 302);
            this.lblAvgGenerateData.Name = "lblAvgGenerateData";
            this.lblAvgGenerateData.Size = new System.Drawing.Size(14, 15);
            this.lblAvgGenerateData.TabIndex = 17;
            this.lblAvgGenerateData.Text = "0";
            // 
            // lblNumberOfTimesCount
            // 
            this.lblNumberOfTimesCount.AutoSize = true;
            this.lblNumberOfTimesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfTimesCount.ForeColor = System.Drawing.Color.Navy;
            this.lblNumberOfTimesCount.Location = new System.Drawing.Point(203, 361);
            this.lblNumberOfTimesCount.Name = "lblNumberOfTimesCount";
            this.lblNumberOfTimesCount.Size = new System.Drawing.Size(14, 15);
            this.lblNumberOfTimesCount.TabIndex = 19;
            this.lblNumberOfTimesCount.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(203, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Number of Times Count:\r\n";
            // 
            // btnSaveData
            // 
            this.btnSaveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveData.ForeColor = System.Drawing.Color.Purple;
            this.btnSaveData.Location = new System.Drawing.Point(132, 183);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(125, 36);
            this.btnSaveData.TabIndex = 8;
            this.btnSaveData.Text = "Save Data In Table";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Fuchsia;
            this.label8.Location = new System.Drawing.Point(4, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "Show Data:";
            // 
            // lblTimeOperation
            // 
            this.lblTimeOperation.AutoSize = true;
            this.lblTimeOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeOperation.ForeColor = System.Drawing.Color.Navy;
            this.lblTimeOperation.Location = new System.Drawing.Point(203, 419);
            this.lblTimeOperation.Name = "lblTimeOperation";
            this.lblTimeOperation.Size = new System.Drawing.Size(14, 15);
            this.lblTimeOperation.TabIndex = 25;
            this.lblTimeOperation.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(203, 397);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "The End Time of the Operation:\r\n";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Green;
            this.btnClear.Location = new System.Drawing.Point(261, 183);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 36);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear Controls";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(5, 232);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(359, 28);
            this.progressBar1.TabIndex = 27;
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.label13);
            this.pnlControls.Controls.Add(this.txtTolerance);
            this.pnlControls.Controls.Add(this.label9);
            this.pnlControls.Controls.Add(this.btnClear);
            this.pnlControls.Controls.Add(this.cmbLesson);
            this.pnlControls.Controls.Add(this.cmbGroup);
            this.pnlControls.Controls.Add(this.txtMax);
            this.pnlControls.Controls.Add(this.label6);
            this.pnlControls.Controls.Add(this.btnSaveData);
            this.pnlControls.Controls.Add(this.label5);
            this.pnlControls.Controls.Add(this.label4);
            this.pnlControls.Controls.Add(this.txtMin);
            this.pnlControls.Controls.Add(this.label3);
            this.pnlControls.Controls.Add(this.txtFixedAvg);
            this.pnlControls.Controls.Add(this.label2);
            this.pnlControls.Controls.Add(this.btnGenerate);
            this.pnlControls.Controls.Add(this.txtNumberStudents);
            this.pnlControls.Controls.Add(this.label1);
            this.pnlControls.Location = new System.Drawing.Point(4, 2);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(360, 227);
            this.pnlControls.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(209, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "EX: 0.01";
            // 
            // txtTolerance
            // 
            this.txtTolerance.Location = new System.Drawing.Point(103, 54);
            this.txtTolerance.Name = "txtTolerance";
            this.txtTolerance.Size = new System.Drawing.Size(102, 20);
            this.txtTolerance.TabIndex = 26;
            this.txtTolerance.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Tolerance:";
            // 
            // cmbLesson
            // 
            this.cmbLesson.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLesson.FormattingEnabled = true;
            this.cmbLesson.Location = new System.Drawing.Point(103, 154);
            this.cmbLesson.Name = "cmbLesson";
            this.cmbLesson.Size = new System.Drawing.Size(154, 21);
            this.cmbLesson.TabIndex = 32;
            // 
            // cmbGroup
            // 
            this.cmbGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(103, 128);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(154, 21);
            this.cmbGroup.TabIndex = 30;
            this.cmbGroup.SelectedValueChanged += new System.EventHandler(this.cmbGroup_SelectedValueChanged);
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(103, 104);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(85, 20);
            this.txtMax.TabIndex = 29;
            this.txtMax.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Maximum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Lesson:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Group:";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(103, 79);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(85, 20);
            this.txtMin.TabIndex = 27;
            this.txtMin.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Minimum:";
            // 
            // txtFixedAvg
            // 
            this.txtFixedAvg.Location = new System.Drawing.Point(103, 29);
            this.txtFixedAvg.Name = "txtFixedAvg";
            this.txtFixedAvg.Size = new System.Drawing.Size(102, 20);
            this.txtFixedAvg.TabIndex = 24;
            this.txtFixedAvg.Text = "7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Fixed Average:";
            // 
            // txtNumberStudents
            // 
            this.txtNumberStudents.Location = new System.Drawing.Point(103, 4);
            this.txtNumberStudents.Name = "txtNumberStudents";
            this.txtNumberStudents.Size = new System.Drawing.Size(102, 20);
            this.txtNumberStudents.TabIndex = 23;
            this.txtNumberStudents.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Number Students:";
            // 
            // lblListShowCount
            // 
            this.lblListShowCount.AutoSize = true;
            this.lblListShowCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListShowCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblListShowCount.Location = new System.Drawing.Point(58, 263);
            this.lblListShowCount.Name = "lblListShowCount";
            this.lblListShowCount.Size = new System.Drawing.Size(13, 13);
            this.lblListShowCount.TabIndex = 29;
            this.lblListShowCount.Text = "0";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.ForeColor = System.Drawing.Color.Navy;
            this.lblMax.Location = new System.Drawing.Point(204, 474);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(14, 15);
            this.lblMax.TabIndex = 31;
            this.lblMax.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(204, 452);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Maximum Value:";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.Color.Navy;
            this.lblMin.Location = new System.Drawing.Point(201, 530);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(14, 15);
            this.lblMin.TabIndex = 33;
            this.lblMin.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(201, 508);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Minimum Value:";
            // 
            // epCheckValueMinMax
            // 
            this.epCheckValueMinMax.ContainerControl = this;
            // 
            // epCheckFiexdAverage
            // 
            this.epCheckFiexdAverage.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 756);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblListShowCount);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblTimeOperation);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblNumberOfTimesCount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblAvgGenerateData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerateData";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCheckValueMinMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCheckFiexdAverage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ListBox lstShow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAvgGenerateData;
        private System.Windows.Forms.Label lblNumberOfTimesCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTimeOperation;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.TextBox txtTolerance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbLesson;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFixedAvg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumberStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblListShowCount;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ErrorProvider epCheckValueMinMax;
        private System.Windows.Forms.ErrorProvider epCheckFiexdAverage;
        private System.Windows.Forms.Label label13;
    }
}

