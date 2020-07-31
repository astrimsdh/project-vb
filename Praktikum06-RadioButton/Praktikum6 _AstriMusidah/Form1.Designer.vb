<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Nik = New System.Windows.Forms.ComboBox()
        Me.Nama = New System.Windows.Forms.ComboBox()
        Me.sMenikah = New System.Windows.Forms.RadioButton()
        Me.sBelum = New System.Windows.Forms.RadioButton()
        Me.jmlAnak = New System.Windows.Forms.TextBox()
        Me.Gaji = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tAnak = New System.Windows.Forms.TextBox()
        Me.tIstri = New System.Windows.Forms.TextBox()
        Me.tTotal = New System.Windows.Forms.TextBox()
        Me.Pendapatan = New System.Windows.Forms.TextBox()
        Me.btnMulai = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(36, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(36, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Karyawan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(36, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(36, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jumlah Anak"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tunjangan Anak"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(235, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Gaji Pokok"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total Tunjangan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Tunjangan Istri"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(234, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Total Pendapatan"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.Pendapatan)
        Me.Panel1.Controls.Add(Me.tTotal)
        Me.Panel1.Controls.Add(Me.tIstri)
        Me.Panel1.Controls.Add(Me.tAnak)
        Me.Panel1.Controls.Add(Me.Gaji)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(12, 187)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(447, 159)
        Me.Panel1.TabIndex = 9
        '
        'Nik
        '
        Me.Nik.FormattingEnabled = True
        Me.Nik.Items.AddRange(New Object() {"001", "002", "003", "004", "005"})
        Me.Nik.Location = New System.Drawing.Point(155, 63)
        Me.Nik.Name = "Nik"
        Me.Nik.Size = New System.Drawing.Size(167, 21)
        Me.Nik.TabIndex = 10
        '
        'Nama
        '
        Me.Nama.FormattingEnabled = True
        Me.Nama.Items.AddRange(New Object() {"Astri Musidah", "Rubby Herdandi", "Ayi Zakiyatul", "Irfan Fauzi", "Mida Muharmadani"})
        Me.Nama.Location = New System.Drawing.Point(155, 90)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(167, 21)
        Me.Nama.TabIndex = 11
        '
        'sMenikah
        '
        Me.sMenikah.AutoSize = True
        Me.sMenikah.ForeColor = System.Drawing.Color.White
        Me.sMenikah.Location = New System.Drawing.Point(155, 119)
        Me.sMenikah.Name = "sMenikah"
        Me.sMenikah.Size = New System.Drawing.Size(66, 17)
        Me.sMenikah.TabIndex = 12
        Me.sMenikah.TabStop = True
        Me.sMenikah.Text = "Menikah"
        Me.sMenikah.UseVisualStyleBackColor = True
        '
        'sBelum
        '
        Me.sBelum.AutoSize = True
        Me.sBelum.ForeColor = System.Drawing.Color.White
        Me.sBelum.Location = New System.Drawing.Point(224, 119)
        Me.sBelum.Name = "sBelum"
        Me.sBelum.Size = New System.Drawing.Size(98, 17)
        Me.sBelum.TabIndex = 13
        Me.sBelum.TabStop = True
        Me.sBelum.Text = "Belum Menikah"
        Me.sBelum.UseVisualStyleBackColor = True
        '
        'jmlAnak
        '
        Me.jmlAnak.Location = New System.Drawing.Point(155, 142)
        Me.jmlAnak.Name = "jmlAnak"
        Me.jmlAnak.Size = New System.Drawing.Size(167, 20)
        Me.jmlAnak.TabIndex = 14
        '
        'Gaji
        '
        Me.Gaji.BackColor = System.Drawing.Color.White
        Me.Gaji.Enabled = False
        Me.Gaji.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gaji.ForeColor = System.Drawing.Color.Black
        Me.Gaji.Location = New System.Drawing.Point(238, 37)
        Me.Gaji.Multiline = True
        Me.Gaji.Name = "Gaji"
        Me.Gaji.Size = New System.Drawing.Size(177, 40)
        Me.Gaji.TabIndex = 15
        Me.Gaji.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(120, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(241, 28)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Program Gaji Sederhana"
        '
        'tAnak
        '
        Me.tAnak.BackColor = System.Drawing.Color.White
        Me.tAnak.Enabled = False
        Me.tAnak.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAnak.ForeColor = System.Drawing.Color.Black
        Me.tAnak.Location = New System.Drawing.Point(27, 37)
        Me.tAnak.Name = "tAnak"
        Me.tAnak.Size = New System.Drawing.Size(173, 21)
        Me.tAnak.TabIndex = 16
        Me.tAnak.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tIstri
        '
        Me.tIstri.BackColor = System.Drawing.Color.White
        Me.tIstri.Enabled = False
        Me.tIstri.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tIstri.ForeColor = System.Drawing.Color.Black
        Me.tIstri.Location = New System.Drawing.Point(27, 76)
        Me.tIstri.Name = "tIstri"
        Me.tIstri.Size = New System.Drawing.Size(173, 21)
        Me.tIstri.TabIndex = 17
        Me.tIstri.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tTotal
        '
        Me.tTotal.BackColor = System.Drawing.Color.White
        Me.tTotal.Enabled = False
        Me.tTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tTotal.ForeColor = System.Drawing.Color.Black
        Me.tTotal.Location = New System.Drawing.Point(27, 115)
        Me.tTotal.Name = "tTotal"
        Me.tTotal.Size = New System.Drawing.Size(173, 21)
        Me.tTotal.TabIndex = 18
        Me.tTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Pendapatan
        '
        Me.Pendapatan.BackColor = System.Drawing.Color.White
        Me.Pendapatan.Enabled = False
        Me.Pendapatan.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pendapatan.ForeColor = System.Drawing.Color.Black
        Me.Pendapatan.Location = New System.Drawing.Point(237, 96)
        Me.Pendapatan.Multiline = True
        Me.Pendapatan.Name = "Pendapatan"
        Me.Pendapatan.Size = New System.Drawing.Size(178, 39)
        Me.Pendapatan.TabIndex = 19
        Me.Pendapatan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnMulai
        '
        Me.btnMulai.Location = New System.Drawing.Point(351, 61)
        Me.btnMulai.Name = "btnMulai"
        Me.btnMulai.Size = New System.Drawing.Size(108, 47)
        Me.btnMulai.TabIndex = 16
        Me.btnMulai.Text = "Mulai"
        Me.btnMulai.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(351, 115)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(108, 47)
        Me.btnKeluar.TabIndex = 17
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(470, 361)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnMulai)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.jmlAnak)
        Me.Controls.Add(Me.sBelum)
        Me.Controls.Add(Me.sMenikah)
        Me.Controls.Add(Me.Nama)
        Me.Controls.Add(Me.Nik)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Name = "Form1"
        Me.Text = "Program Gaji"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Pendapatan As System.Windows.Forms.TextBox
    Friend WithEvents tTotal As System.Windows.Forms.TextBox
    Friend WithEvents tIstri As System.Windows.Forms.TextBox
    Friend WithEvents tAnak As System.Windows.Forms.TextBox
    Friend WithEvents Gaji As System.Windows.Forms.TextBox
    Friend WithEvents Nik As System.Windows.Forms.ComboBox
    Friend WithEvents Nama As System.Windows.Forms.ComboBox
    Friend WithEvents sMenikah As System.Windows.Forms.RadioButton
    Friend WithEvents sBelum As System.Windows.Forms.RadioButton
    Friend WithEvents jmlAnak As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnMulai As System.Windows.Forms.Button
    Friend WithEvents btnKeluar As System.Windows.Forms.Button

End Class
