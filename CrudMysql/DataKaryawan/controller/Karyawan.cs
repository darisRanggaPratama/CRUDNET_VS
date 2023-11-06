using DataKaryawan.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataKaryawan.controller
{
	class Karyawan
	{
		// Memanggil Class Connect dan membuat objek baru
		Connect connects = new Connect();

		// Method Insert
		public bool Insert(Karyawan_m karyawan)
		{
			Boolean status = false;

			try
			{

			} catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return status;
		}
	}
}
