<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HitungUmur
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
		Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.btnCalc = New System.Windows.Forms.Button()
		Me.dtTanggal = New System.Windows.Forms.DateTimePicker()
		Me.txtNama = New System.Windows.Forms.TextBox()
		Me.lblLahir = New System.Windows.Forms.Label()
		Me.lblNama = New System.Windows.Forms.Label()
		Me.richResult = New System.Windows.Forms.RichTextBox()
		CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainer1.Panel1.SuspendLayout()
		Me.SplitContainer1.Panel2.SuspendLayout()
		Me.SplitContainer1.SuspendLayout()
		Me.SuspendLayout()
		'
		'SplitContainer1
		'
		Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
		Me.SplitContainer1.Name = "SplitContainer1"
		'
		'SplitContainer1.Panel1
		'
		Me.SplitContainer1.Panel1.Controls.Add(Me.btnCalc)
		Me.SplitContainer1.Panel1.Controls.Add(Me.dtTanggal)
		Me.SplitContainer1.Panel1.Controls.Add(Me.txtNama)
		Me.SplitContainer1.Panel1.Controls.Add(Me.lblLahir)
		Me.SplitContainer1.Panel1.Controls.Add(Me.lblNama)
		'
		'SplitContainer1.Panel2
		'
		Me.SplitContainer1.Panel2.Controls.Add(Me.richResult)
		Me.SplitContainer1.Size = New System.Drawing.Size(800, 450)
		Me.SplitContainer1.SplitterDistance = 414
		Me.SplitContainer1.TabIndex = 0
		'
		'btnCalc
		'
		Me.btnCalc.Location = New System.Drawing.Point(311, 125)
		Me.btnCalc.Name = "btnCalc"
		Me.btnCalc.Size = New System.Drawing.Size(75, 23)
		Me.btnCalc.TabIndex = 4
		Me.btnCalc.Text = "Calculate"
		Me.btnCalc.UseVisualStyleBackColor = True
		'
		'dtTanggal
		'
		Me.dtTanggal.CustomFormat = "dd-MM-yyyy"
		Me.dtTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtTanggal.Location = New System.Drawing.Point(104, 78)
		Me.dtTanggal.Name = "dtTanggal"
		Me.dtTanggal.Size = New System.Drawing.Size(282, 20)
		Me.dtTanggal.TabIndex = 3
		'
		'txtNama
		'
		Me.txtNama.Location = New System.Drawing.Point(104, 31)
		Me.txtNama.Name = "txtNama"
		Me.txtNama.Size = New System.Drawing.Size(282, 20)
		Me.txtNama.TabIndex = 2
		'
		'lblLahir
		'
		Me.lblLahir.AutoSize = True
		Me.lblLahir.Location = New System.Drawing.Point(26, 84)
		Me.lblLahir.Name = "lblLahir"
		Me.lblLahir.Size = New System.Drawing.Size(72, 13)
		Me.lblLahir.TabIndex = 1
		Me.lblLahir.Text = "Tanggal Lahir"
		'
		'lblNama
		'
		Me.lblNama.AutoSize = True
		Me.lblNama.Location = New System.Drawing.Point(26, 34)
		Me.lblNama.Name = "lblNama"
		Me.lblNama.Size = New System.Drawing.Size(35, 13)
		Me.lblNama.TabIndex = 0
		Me.lblNama.Text = "Nama"
		'
		'richResult
		'
		Me.richResult.Dock = System.Windows.Forms.DockStyle.Fill
		Me.richResult.Location = New System.Drawing.Point(0, 0)
		Me.richResult.Name = "richResult"
		Me.richResult.Size = New System.Drawing.Size(382, 450)
		Me.richResult.TabIndex = 0
		Me.richResult.Text = ""
		'
		'HitungUmur
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.SplitContainer1)
		Me.Name = "HitungUmur"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Hitung Usia"
		Me.SplitContainer1.Panel1.ResumeLayout(False)
		Me.SplitContainer1.Panel1.PerformLayout()
		Me.SplitContainer1.Panel2.ResumeLayout(False)
		CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents SplitContainer1 As SplitContainer
	Friend WithEvents richResult As RichTextBox
	Friend WithEvents lblNama As Label
	Friend WithEvents lblLahir As Label
	Friend WithEvents dtTanggal As DateTimePicker
	Friend WithEvents txtNama As TextBox
	Friend WithEvents btnCalc As Button
End Class
