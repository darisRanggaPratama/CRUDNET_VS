Public Class HitungUmur

	Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
		Dim date_now As Date
		Dim date_birth As Date
		Dim age_year As Integer
		Dim age_month As Integer
		Dim age_result As String

		date_now = Now.Date
		date_birth = dtTanggal.Value

		age_year = date_now.Year - date_birth.Year
		age_month = date_now.Month - date_birth.Month

		age_result = $" Nama Saya: {txtNama.Text} {vbCrLf} Tanggal: {date_birth} {vbCrLf} Usia: {age_year} Tahun {age_month} Bulan"
		richResult.Text = age_result

		' Tutorial: https://www.youtube.com/watch?v=hibaqN27oBU
		' Judul: Pemrograman Visual Basic(VB) untuk Pemula Secara Terstruktur




	End Sub

End Class
