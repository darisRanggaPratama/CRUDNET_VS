<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.txtInput = New System.Windows.Forms.TextBox()
		Me.btn1 = New System.Windows.Forms.Button()
		Me.btn4 = New System.Windows.Forms.Button()
		Me.btn7 = New System.Windows.Forms.Button()
		Me.btn8 = New System.Windows.Forms.Button()
		Me.btn5 = New System.Windows.Forms.Button()
		Me.btn2 = New System.Windows.Forms.Button()
		Me.btn9 = New System.Windows.Forms.Button()
		Me.btn6 = New System.Windows.Forms.Button()
		Me.btn3 = New System.Windows.Forms.Button()
		Me.btnMinus = New System.Windows.Forms.Button()
		Me.btnPlus = New System.Windows.Forms.Button()
		Me.btn0 = New System.Windows.Forms.Button()
		Me.btnDiv = New System.Windows.Forms.Button()
		Me.btnMulti = New System.Windows.Forms.Button()
		Me.btnCE = New System.Windows.Forms.Button()
		Me.btnEqual = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'txtInput
		'
		Me.txtInput.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtInput.ForeColor = System.Drawing.Color.Navy
		Me.txtInput.Location = New System.Drawing.Point(16, 8)
		Me.txtInput.Multiline = True
		Me.txtInput.Name = "txtInput"
		Me.txtInput.Size = New System.Drawing.Size(360, 51)
		Me.txtInput.TabIndex = 0
		Me.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'btn1
		'
		Me.btn1.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn1.Location = New System.Drawing.Point(16, 80)
		Me.btn1.Name = "btn1"
		Me.btn1.Size = New System.Drawing.Size(72, 51)
		Me.btn1.TabIndex = 1
		Me.btn1.Text = "1"
		Me.btn1.UseVisualStyleBackColor = True
		'
		'btn4
		'
		Me.btn4.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn4.Location = New System.Drawing.Point(16, 152)
		Me.btn4.Name = "btn4"
		Me.btn4.Size = New System.Drawing.Size(72, 51)
		Me.btn4.TabIndex = 2
		Me.btn4.Text = "4"
		Me.btn4.UseVisualStyleBackColor = True
		'
		'btn7
		'
		Me.btn7.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn7.Location = New System.Drawing.Point(16, 224)
		Me.btn7.Name = "btn7"
		Me.btn7.Size = New System.Drawing.Size(72, 51)
		Me.btn7.TabIndex = 3
		Me.btn7.Text = "7"
		Me.btn7.UseVisualStyleBackColor = True
		'
		'btn8
		'
		Me.btn8.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn8.Location = New System.Drawing.Point(112, 224)
		Me.btn8.Name = "btn8"
		Me.btn8.Size = New System.Drawing.Size(72, 51)
		Me.btn8.TabIndex = 6
		Me.btn8.Text = "8"
		Me.btn8.UseVisualStyleBackColor = True
		'
		'btn5
		'
		Me.btn5.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn5.Location = New System.Drawing.Point(112, 152)
		Me.btn5.Name = "btn5"
		Me.btn5.Size = New System.Drawing.Size(72, 51)
		Me.btn5.TabIndex = 5
		Me.btn5.Text = "5"
		Me.btn5.UseVisualStyleBackColor = True
		'
		'btn2
		'
		Me.btn2.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn2.Location = New System.Drawing.Point(112, 80)
		Me.btn2.Name = "btn2"
		Me.btn2.Size = New System.Drawing.Size(72, 51)
		Me.btn2.TabIndex = 4
		Me.btn2.Text = "2"
		Me.btn2.UseVisualStyleBackColor = True
		'
		'btn9
		'
		Me.btn9.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn9.Location = New System.Drawing.Point(208, 224)
		Me.btn9.Name = "btn9"
		Me.btn9.Size = New System.Drawing.Size(72, 51)
		Me.btn9.TabIndex = 9
		Me.btn9.Text = "9"
		Me.btn9.UseVisualStyleBackColor = True
		'
		'btn6
		'
		Me.btn6.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn6.Location = New System.Drawing.Point(208, 152)
		Me.btn6.Name = "btn6"
		Me.btn6.Size = New System.Drawing.Size(72, 51)
		Me.btn6.TabIndex = 8
		Me.btn6.Text = "6"
		Me.btn6.UseVisualStyleBackColor = True
		'
		'btn3
		'
		Me.btn3.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn3.Location = New System.Drawing.Point(208, 80)
		Me.btn3.Name = "btn3"
		Me.btn3.Size = New System.Drawing.Size(72, 51)
		Me.btn3.TabIndex = 7
		Me.btn3.Text = "3"
		Me.btn3.UseVisualStyleBackColor = True
		'
		'btnMinus
		'
		Me.btnMinus.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnMinus.Location = New System.Drawing.Point(304, 224)
		Me.btnMinus.Name = "btnMinus"
		Me.btnMinus.Size = New System.Drawing.Size(72, 51)
		Me.btnMinus.TabIndex = 12
		Me.btnMinus.Text = "-"
		Me.btnMinus.UseVisualStyleBackColor = True
		'
		'btnPlus
		'
		Me.btnPlus.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnPlus.Location = New System.Drawing.Point(304, 152)
		Me.btnPlus.Name = "btnPlus"
		Me.btnPlus.Size = New System.Drawing.Size(72, 51)
		Me.btnPlus.TabIndex = 11
		Me.btnPlus.Text = "+"
		Me.btnPlus.UseVisualStyleBackColor = True
		'
		'btn0
		'
		Me.btn0.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn0.Location = New System.Drawing.Point(304, 80)
		Me.btn0.Name = "btn0"
		Me.btn0.Size = New System.Drawing.Size(72, 51)
		Me.btn0.TabIndex = 10
		Me.btn0.Text = "0"
		Me.btn0.UseVisualStyleBackColor = True
		'
		'btnDiv
		'
		Me.btnDiv.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDiv.Location = New System.Drawing.Point(400, 224)
		Me.btnDiv.Name = "btnDiv"
		Me.btnDiv.Size = New System.Drawing.Size(72, 51)
		Me.btnDiv.TabIndex = 15
		Me.btnDiv.Text = "/"
		Me.btnDiv.UseVisualStyleBackColor = True
		'
		'btnMulti
		'
		Me.btnMulti.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnMulti.Location = New System.Drawing.Point(400, 152)
		Me.btnMulti.Name = "btnMulti"
		Me.btnMulti.Size = New System.Drawing.Size(72, 51)
		Me.btnMulti.TabIndex = 14
		Me.btnMulti.Text = "*"
		Me.btnMulti.UseVisualStyleBackColor = True
		'
		'btnCE
		'
		Me.btnCE.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCE.Location = New System.Drawing.Point(400, 8)
		Me.btnCE.Name = "btnCE"
		Me.btnCE.Size = New System.Drawing.Size(72, 51)
		Me.btnCE.TabIndex = 13
		Me.btnCE.Text = "CE"
		Me.btnCE.UseVisualStyleBackColor = True
		'
		'btnEqual
		'
		Me.btnEqual.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnEqual.Location = New System.Drawing.Point(400, 80)
		Me.btnEqual.Name = "btnEqual"
		Me.btnEqual.Size = New System.Drawing.Size(72, 51)
		Me.btnEqual.TabIndex = 16
		Me.btnEqual.Text = "="
		Me.btnEqual.UseVisualStyleBackColor = True
		'
		'Calculator
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(488, 292)
		Me.Controls.Add(Me.btnEqual)
		Me.Controls.Add(Me.btnDiv)
		Me.Controls.Add(Me.btnMulti)
		Me.Controls.Add(Me.btnCE)
		Me.Controls.Add(Me.btnMinus)
		Me.Controls.Add(Me.btnPlus)
		Me.Controls.Add(Me.btn0)
		Me.Controls.Add(Me.btn9)
		Me.Controls.Add(Me.btn6)
		Me.Controls.Add(Me.btn3)
		Me.Controls.Add(Me.btn8)
		Me.Controls.Add(Me.btn5)
		Me.Controls.Add(Me.btn2)
		Me.Controls.Add(Me.btn7)
		Me.Controls.Add(Me.btn4)
		Me.Controls.Add(Me.btn1)
		Me.Controls.Add(Me.txtInput)
		Me.Name = "Calculator"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Calculator"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents txtInput As TextBox
	Friend WithEvents btn1 As Button
	Friend WithEvents btn4 As Button
	Friend WithEvents btn7 As Button
	Friend WithEvents btn8 As Button
	Friend WithEvents btn5 As Button
	Friend WithEvents btn2 As Button
	Friend WithEvents btn9 As Button
	Friend WithEvents btn6 As Button
	Friend WithEvents btn3 As Button
	Friend WithEvents btnMinus As Button
	Friend WithEvents btnPlus As Button
	Friend WithEvents btn0 As Button
	Friend WithEvents btnDiv As Button
	Friend WithEvents btnMulti As Button
	Friend WithEvents btnCE As Button
	Friend WithEvents btnEqual As Button
End Class
