using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCAFE.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance 
        { get
            {
                if (instance == null) 
                    instance = new DataProvider();
                return DataProvider.instance;
            }
          private set => instance = value; 
        }

        private string connectionSTR = "Data Source=.\\sqlexpress;Initial Catalog=QuanLyQuanCaPhe;Integrated Security=True;Encrypt=False";

        private DataProvider() { }
        public DataTable ExcuteQuery(string query, object[]? parameter = null)
        {

            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                int i = 0;
                if (parameter != null )
                {
                    string[] listPara = query.Split(' ');
                    foreach ( string para in listPara )
                    {
                        if (para.Contains('@'))
                        {
                            command.Parameters.AddWithValue(para,parameter[i]);
                            i++;
                        }
                    }

                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

                connection.Close();
            }    

            return data;
        }

        public int ExcuteNonQuery(string query, object[]? parameter = null)
        {

            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                int i = 0;
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    foreach (string para in listPara)
                    {
                        if (para.Contains('@'))
                        {
                            command.Parameters.AddWithValue(para, parameter[i]);
                            i++;
                        }
                    }

                }
                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }

        public object ExcuteScalar(string query, object[]? parameter = null)
        {

            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                int i = 0;
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    foreach (string para in listPara)
                    {
                        if (para.Contains('@'))
                        {
                            command.Parameters.AddWithValue(para, parameter[i]);
                            i++;
                        }
                    }

                }
                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }
    }
}
