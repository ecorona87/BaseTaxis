using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace BaseTaxisDataAccessLayer
{
    public class SQLHelper
    {
        private SqlConnection _connection;
        private SqlCommand _command;
        private List<SqlParameter> _parameters;

        string _azureConnectionString;

        public SQLHelper()
        {
            _azureConnectionString = ConfigurationManager.ConnectionStrings["AzureConnectionString"].ConnectionString;

            _connection = new SqlConnection(_azureConnectionString);
            _parameters = new List<SqlParameter>();
            _command = _connection.CreateCommand();
            _command.CommandType = CommandType.StoredProcedure;
        }

        public void AddParameter(string Name, object Value, SqlDbType Type, int Size, ParameterDirection Direction)
        {
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = Name;
            parameter.Value = Value;
            parameter.SqlDbType = Type;
            parameter.Size = Size;
            parameter.Direction = Direction;

            _parameters.Add(parameter);
        }
        public string ReadOutputParameter(string Name)
        {
            return _parameters.Find(x => x.ParameterName == Name).Value.ToString();
        }

        private void AddParametersToCommand()
        {
            foreach (var parameter in _parameters)
            {
                _command.Parameters.Add(parameter);
            }
        }

        public int ExecuteNonQueryStoredProcedure(string StoredProcedure)
        {
            int RowsAffected = 0;
            try
            {
                _connection.Open();
                _command.CommandText = StoredProcedure;

                AddParametersToCommand();

                RowsAffected = _command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error de Base de Datos : " + ex.Message);
            }
            finally
            {
                _connection.Close();
            }

            return RowsAffected;
        }

        public int ExecuteQueryStoredProcedure(string StoredProcedure)
        {
            int RowsAffected = 0;
            try
            {
                _connection.Open();
                _command.CommandText = StoredProcedure;

                AddParametersToCommand();

                RowsAffected = _command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error de Base de Datos : " + ex.Message);
            }
            finally
            {
                _connection.Close();
            }

            return RowsAffected;
        }
    }
}
