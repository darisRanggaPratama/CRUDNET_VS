//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace DataKaryawan.model
{
	class Karyawan_m
	{
		string nik, nama, jabatan, alamat, email, hp;

		public Karyawan_m() { }

		public Karyawan_m(string nik, string nama, string jabatan, string alamat, string email, string hp)
		{
			this.Nik = nik;
			this.Nama = nama;
			this.Jabatan = jabatan;
			this.Alamat = alamat;
			this.Email = email;
			this.Hp = hp;
		}

		public string Nik { get => nik; set => nik = value; }
		public string Nama { get => nama; set => nama = value; }
		public string Jabatan { get => jabatan; set => jabatan = value; }
		public string Alamat { get => alamat; set => alamat = value; }
		public string Email { get => email; set => email = value; }
		public string Hp { get => hp; set => hp = value; }
	}
}
