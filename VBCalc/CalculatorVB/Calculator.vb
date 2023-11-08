Public Class Calculator
	Dim angka As Double = 0, simbol As String = ""
	Dim kondisi As Boolean = True
	Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click

		Dim objectButton As Button
		objectButton = sender

		If kondisi = True Then
			txtInput.Text &= objectButton.Text
		Else
			txtInput.Text = objectButton.Text
			kondisi = True
		End If

		'txtInput.Text = txtInput.Text & objectButton.Text Cara lain

	End Sub

	Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click, btnMinus.Click, btnMulti.Click, btnDiv.Click

		Dim objectButton As Button


		objectButton = sender
		angka = txtInput.Text
		simbol = objectButton.Text

		txtInput.Text = ""
	End Sub

	Private Sub btnCE_Click(sender As Object, e As EventArgs) Handles btnCE.Click
		txtInput.Text = ""
	End Sub

	Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
		Dim result As Double

		Select Case simbol
			Case "+"
				result = Convert.ToDouble(txtInput.Text) + angka
			Case "-"
				result = angka - Convert.ToDouble(txtInput.Text)
			Case "*"
				result = angka * Convert.ToDouble(txtInput.Text)
			Case "/"
				result = angka / Convert.ToDouble(txtInput.Text)
		End Select


		txtInput.Text = result
		kondisi = False
	End Sub
End Class
