using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataKaryawan
{
	public partial class DataKaryawan : Form
	{
		Connect connect = new Connect();

		public void Tampil()
		{
			// Query Database
			string txtQuery = "SELECT * FROM karyawan";
			dataGridView.DataSource = connect.ShowData(txtQuery);

			// Mengubah nama kolom
			dataGridView.Columns[0].HeaderText = "#";
			dataGridView.Columns[1].HeaderText = "NIK";
			dataGridView.Columns[2].HeaderText = "NAMA";
			dataGridView.Columns[3].HeaderText = "JABATAN";
			dataGridView.Columns[4].HeaderText = "ALAMAT";
			dataGridView.Columns[5].HeaderText = "EMAIL";
			dataGridView.Columns[6].HeaderText = "HP";
		}

		public DataKaryawan()
		{
			InitializeComponent();

		}

		private void DataKaryawan_Load(object sender, EventArgs e)
		{
			// Call Method Tampil
			Tampil();
		}

	
	}
}
