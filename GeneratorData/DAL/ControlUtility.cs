using System;
using System.Data;
using System.Data.SqlClient;

namespace GeneratorData.DAL
{
    public class ControlUtility
    {
        public static DataTable FillCmb(string firstRow, string query)
        {
            DataTable dt;
            try
            {
                dt = new DataTable();
                GetConnection.Open();
                new SqlDataAdapter(query, GetConnection.Conn).Fill(dt);
                DataRow row1 = dt.NewRow();
                row1[0] = 0;
                row1[1] = firstRow;
                dt.Rows.InsertAt(row1, 0);

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                GetConnection.Close();
            }
            return dt;
        }
      
    }
}
