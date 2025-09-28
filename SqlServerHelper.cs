using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace BudgetBook
{
    internal static class SqlServerHelper
    {
        private static readonly string connectionString;

        static SqlServerHelper()
        {
            // appsettings.json ����ڑ���������擾
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            connectionString = configuration.GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException("�ڑ������񂪐ݒ肳��Ă��܂���B");
        }

        public static DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand(query, connection);
            if (parameters != null && parameters.Length > 0)
            {
                command.Parameters.AddRange(parameters);
            }
            using var adapter = new SqlDataAdapter(command);
            var table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static int ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand(query, connection);
            if (parameters != null && parameters.Length > 0)
            {
                command.Parameters.AddRange(parameters);
            }
            connection.Open();
            return command.ExecuteNonQuery();
        }
    }
}