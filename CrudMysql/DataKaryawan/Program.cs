using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataKaryawan
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new DataKaryawan());
			// Connect();
		}

		public static void Connect()
		{

			// Connection string untuk koneksi ke MySQL.
			string connectionString = "Server=localhost;Database=adventure;User ID=rangga;Password=rangga;";

			// Buat objek koneksi MySQL.
			MySqlConnection connection = new MySqlConnection(connectionString);

			try
			{
				// Buka koneksi.
				connection.Open();

				// Cek apakah koneksi berhasil.
				if (connection.State == ConnectionState.Open)
				{
					Console.WriteLine("Koneksi ke MySQL berhasil!");
					MessageBox.Show("Success");
				}
				else
				{
					Console.WriteLine("Gagal terhubung ke MySQL.");
				}
			}
			catch (MySqlException ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}
			finally
			{
				// Pastikan untuk selalu menutup koneksi setelah digunakan.
				if (connection.State == ConnectionState.Open)
				{
					connection.Close();
				}
			}

			Console.ReadLine();
		}
	}
}
