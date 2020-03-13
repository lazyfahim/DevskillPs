using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    public class SqlDataProvider<T> : IDisposable
    {
        protected readonly SqlConnection _sqlConnection;

        public SqlDataProvider(string connectionString)
        {
            _sqlConnection = new SqlConnection(connectionString);
            _sqlConnection.Open();

        }

        public (List<T>,int) GetData(string sql)
        {
            var result = new List<T>();
            var command = new SqlCommand(sql, _sqlConnection);
            //command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@filteredCount",SqlDbType.Int).Direction = ParameterDirection.Output;
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var itemType = typeof(T);
                var constructor = itemType.GetConstructor(new Type[] { });
                var instance = constructor.Invoke(new object[] { });
                var properties = itemType.GetProperties();
                foreach(var property in properties)
                {
                    property.SetValue(instance, Convert.ChangeType(reader[property.Name],property.PropertyType));
                }
                result.Add((T)instance);
            }

            reader.NextResult();
            int cnt=0;
            while (reader.Read())
                cnt = (int) reader["cnt"];
            return (result,cnt);
        }
        public int GetTotal(string tablename)
        {
            var command = new SqlCommand($"select count(Id) from {tablename} ", _sqlConnection);
            int res = (int)command.ExecuteScalar();
            return res;
        }
        public void Dispose()
        {
            if(_sqlConnection != null)
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                    _sqlConnection.Close();
                _sqlConnection.Dispose();
            }
            
        }
    }
}
