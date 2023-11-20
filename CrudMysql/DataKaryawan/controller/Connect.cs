//using System;
//using System.Collections.Generic;
using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DataKaryawan
{
	class Connect
	{
		string connectString = "Server=127.0.0.1;Port=3306;Database=world;Uid=rangga;Pwd=rangga;";
		MySqlConnection conn;

		public void OpenConnection()
		{
			conn = new MySqlConnection(connectString);
			conn.Open();				
		}

		public void CloseConnection()
		{
			conn.Close();
		}

		public void ExecuteQuery(string query)
		{
			MySqlCommand command = new MySqlCommand(query);
			command.ExecuteNonQuery();
		}

		public object ShowData(string query)
		{
			MySqlDataAdapter adapter = new MySqlDataAdapter(query, connectString);
			DataSet data = new DataSet();

			adapter.Fill(data);
			object bebas = data.Tables[0];
			return bebas;
		}
	}
}

