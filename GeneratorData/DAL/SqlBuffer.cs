using System;
using System.Data.SqlClient;
using System.Text;

namespace GeneratorData.DAL
{
    public class SqlBuffer
    {
        #region fields

        private StringBuilder _sb = new StringBuilder();
        private readonly SqlConnection _conn = new SqlConnection();
        private int _commandCount;
        private SqlTransaction _transaction;
        #endregion

        #region Proeprty
        public int CommandCount => _commandCount;
        #endregion

        #region Functionality
        public void AddQuery(string query)
        {
            try
            {
                _sb.Append(query);
                _commandCount++;
            }
            catch
            {
                // ignored
            }
        }
        private void Clear()
        {
            _commandCount = 0;
            _sb = new StringBuilder
            {
                Length = 0
            };
            GC.Collect();

        }
        public int WriteBufferToDb()
        {
            int k = ExecuteNonQuery(_sb.ToString());
            Clear();
            return  k;
        }
        private int ExecuteNonQuery(string queryStr)
        {
            if (string.IsNullOrEmpty(queryStr))
                return 0;
            _conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            try
            {
                _conn.Open();
                _transaction = _conn.BeginTransaction();
                var cm = new SqlCommand
                {
                    CommandType = System.Data.CommandType.Text,
                    CommandTimeout = 30000000,
                    CommandText = queryStr,
                    Connection = _conn,
                    Transaction = _transaction
                };

                var res = cm.ExecuteNonQuery();
                _transaction.Commit();
                return res;
            }
            catch(Exception)
            {
                _transaction.Rollback();
                return 0;
            }
            finally
            {
                _conn.Close();
            }
        }
        public string GetQuery()
        {
            return _sb.ToString();
        }
        #endregion
    }
}
