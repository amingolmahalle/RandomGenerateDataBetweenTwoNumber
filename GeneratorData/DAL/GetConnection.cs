﻿using System;
using System.Data;
using System.Data.SqlClient;
using GeneratorData.Other;

namespace GeneratorData.DAL
{
   public static class GetConnection
    {
        public static readonly SqlConnection Conn = new SqlConnection();
        static GetConnection()
        {
            try
            {
                Conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"]
                    .ConnectionString;
            }
            catch (ApplicationConnectToDatabaseException)
            {
                throw new ApplicationConnectToDatabaseException();
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static void Open()
        {
            if (Conn.State == ConnectionState.Closed || Conn.State == ConnectionState.Broken)
                Conn.Open();
        }

        public static void Close()
        {
            Conn.Close();
        }
    }
}
