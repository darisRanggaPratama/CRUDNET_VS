Public Class Calculator
	Dim number As Double = 0, symbol As String = ""
	Dim condition As Boolean = True
	Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click

		Dim objectButton As Button
		
		objectButton = sender

		If condition = True Then
			txtInput.Text &= objectButton.Text

		Else
			txtInput.Text = objectButton.Text
			condition = True
		End If

		'txtInput.Text = txtInput.Text & objectButton.Text Cara lain

	End Sub

	Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click, btnMinus.Click, btnMulti.Click, btnDiv.Click

		Dim objectButton As Button

		Try
			objectButton = sender
			number = txtInput.Text
			symbol = objectButton.Text
			txtInput.Text = ""

		Catch ex As Exception
			MessageBox.Show("False calculation: " & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

		End Try
	End Sub

	Private Sub btnCE_Click(sender As Object, e As EventArgs) Handles btnCE.Click
		txtInput.Text = ""
	End Sub

	Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
		Dim result As Double
		Try
			Select Case symbol
				Case "+"
					result = Convert.ToDouble(txtInput.Text) + number
				Case "-"
					result = number - Convert.ToDouble(txtInput.Text)
				Case "*"
					result = number * Convert.ToDouble(txtInput.Text)
				Case "/"
					result = number / Convert.ToDouble(txtInput.Text)
			End Select

		Catch ex As Exception
			MessageBox.Show("False calculation: " & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

		End Try


		txtInput.Text = result.ToString("N")
		condition = False
	End Sub
End Class
' Tutorial: https://www.youtube.com/watch?v=hibaqN27oBU

#Region "Private Sub btn1_Click"
' 1. Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, ...: Ini adalah event handler (penangan aksi) untuk klik tombol. Ini berarti kode ini akan dieksekusi ketika salah satu tombol yang dinyatakan di sini (btn1, btn2, ..., btn0) diklik. Saat tombol diklik, objek yang mengirimkan aksi (sender) adalah tombol itu sendiri.

' 2. Dim objectButton As Button: Ini mendeklarasikan variabel objectButton yang akan digunakan untuk menyimpan tombol yang diklik.

' 3. objectButton = sender: Variabel objectButton diisi dengan tombol yang dikirim oleh sender. Dalam konteks ini, sender adalah tombol yang diklik, sehingga objectButton akan mengacu pada tombol yang memicu klik.

' 4.  If condition = True Then: Ini adalah awal dari blok pengkondisian. Ini memeriksa apakah variabel condition adalah True.

' 5.  txtInput.Text &= objectButton.Text: Jika condition adalah True, maka teks pada tombol yang diklik (objectButton.Text) akan ditambahkan ke teks yang sudah ada dalam txtInput. Ini berarti Anda dapat mengklik beberapa tombol secara berurutan, dan teks akan terus ditambahkan ke teks yang ada di txtInput.

' 6. Else: Bagian ini akan dieksekusi jika condition bukan True.

' 7. txtInput.Text = objectButton.Text: Ini menggantikan teks yang ada dalam txtInput dengan teks dari tombol yang diklik (objectButton.Text).

' 8. condition = True: Setelah mengganti teks dalam txtInput, condition diatur kembali menjadi True, sehingga selanjutnya, jika Anda mengklik tombol lagi, teks akan ditambahkan, bukan mengganti seluruhnya.
#End Region

#Region "Private Sub btnEqual_Click"
' 1. `Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click`: Ini adalah Event handler (penangan aksi) untuk tombol "btnEqual" yang akan dieksekusi saat tombol tersebut diklik. Saat tombol ini diklik, objek yang mengirimkan aksi (sender) adalah tombol tersebut.

' 2. `Dim result As Double`: Ini mendeklarasikan variabel `result` yang akan digunakan untuk menyimpan hasil perhitungan.

' 3. `Try`: Ini adalah awal dari blok `Try`, yang digunakan untuk mencoba menjalankan potongan kode yang mungkin menghasilkan pengecualian (exceptions).

' 4. `Select Case symbol`: Ini adalah konstruksi `Select Case` yang digunakan untuk memeriksa nilai dalam variabel `symbol` dan melaksanakan operasi matematika sesuai dengan Operator yang dipilih.

' 5. Di dalam `Select Case`, kita memeriksa nilai dalam `symbol` dan melaksanakan operasi matematika sesuai dengan operator yang telah dipilih sebelumnya. Hasil perhitungan disimpan dalam variabel `result`.

' 6. `Catch ex As Exception`: Ini adalah bagian yang akan menangani pengecualian yang mungkin terjadi saat mencoba menjalankan perhitungan. Jika ada pengecualian, kode dalam blok `Catch` akan dijalankan.

' 7. `MessageBox.Show("False calculation: " & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)`: Ini menampilkan pesan dialog dengan pesan kesalahan yang mencakup pesan pengecualian (ex.Message) yang dihasilkan. Ini membantu pengguna memahami kesalahan perhitungan yang terjadi.

' 8. `txtInput.Text = result.ToString("N")`: Ini mengatur teks dalam TextBox `txtInput` dengan hasil perhitungan (`result`). `ToString("N")` digunakan untuk memformat hasil dengan pemisah ribuan.

' 9. condition = False: Ini mengatur variabel condition menjadi False.

' Dengan demikian, kode ini menerima Operator matematika dan angka dari pengguna, melakukan perhitungan sesuai dengan Operator yang dipilih, menampilkan hasilnya di TextBox, dan menangani pengecualian jika ada kesalahan dalam perhitungan.
#End Region