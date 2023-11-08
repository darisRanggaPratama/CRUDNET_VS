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
'Tutorial: https://www.youtube.com/watch?v=hibaqN27oBU