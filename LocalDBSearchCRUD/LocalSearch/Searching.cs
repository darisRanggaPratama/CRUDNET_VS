using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LocalSearch
{
	public partial class Browse : Form
	{
		SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\raden\Documents\UploadGithub\CRUDNET_VS\LocalDBSearchCRUD\LocalSearch\db_server.mdf;Integrated Security = True; Connect Timeout=30");
		public Browse()
		{
			InitializeComponent();
		}

		private void Browse_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'dataSet.mytable' table. You can move, or remove it, as needed.
            this.mytableTableAdapter.Fill(this.dataSet.mytable);

        }

        private void btn_insert_Click(object sender, EventArgs e)
		{
			connection.Open();
			SqlCommand cmd = connection.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "INSERT INTO [mytable] (Name,Surename,Address)" +
				" VALUES('"+txt_name.Text+"','"+txt_surename.Text+"','"+txt_address.Text+"')";
			cmd.ExecuteNonQuery();
			connection.Close();
			txt_name.Text = "";
			txt_surename.Text = "";
			txt_address.Text = "";
			txt_search.Text = "";
			display_data();
			MessageBox.Show("Data inserted Successfully");
		}

		// To display Data
		public void display_data()
		{
			connection.Open();
			SqlCommand cmd = connection.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "SELECT * FROM [mytable]";
			cmd.ExecuteNonQuery();
			DataTable dta = new DataTable();
			SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
			dataadp.Fill(dta);
			dataGridView.DataSource = dta;
			connection.Close();
		}

		private void btn_delete_Click(object sender, EventArgs e)
		{
			connection.Open();
			SqlCommand cmd = connection.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "DELETE FROM [mytable] WHERE name = '" + txt_name.Text + "'";
			cmd.ExecuteNonQuery();
			connection.Close();
			txt_name.Text = "";
			txt_surename.Text = "";
			txt_address.Text = "";
			txt_search.Text = "";
			display_data();
			MessageBox.Show("Data deleted Successfully");
		}

		private void btn_update_Click(object sender, EventArgs e)
		{
			connection.Open();
			SqlCommand cmd = connection.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "UPDATE [mytable] SET name = '" + txt_surename.Text + "' WHERE name = '"+txt_name.Text+"'";
			cmd.ExecuteNonQuery();
			connection.Close();
			txt_name.Text = "";
			txt_surename.Text = "";
			txt_address.Text = "";
			txt_search.Text = "";
			display_data();
			MessageBox.Show("Data updated Successfully");
		}

		private void btn_search_Click(object sender, EventArgs e)
		{
			connection.Open();
			SqlCommand cmd = connection.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "SELECT * FROM [mytable] WHERE name = '" + txt_search.Text + "' OR surename = '" + txt_search.Text + "'";
			cmd.ExecuteNonQuery();
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			da.Fill(dt);
			dataGridView.DataSource = dt;
			connection.Close();
			txt_name.Text = "";
			txt_surename.Text = "";
			txt_address.Text = "";
			txt_search.Text = "";
		}

		private void btn_display_Click(object sender, EventArgs e)
		{
			display_data();
		}
	}
}
// Tutorial: https://www.youtube.com/watch?v=I4ERJXSqHnQ