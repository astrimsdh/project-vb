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
        Me.tnorek = New System.Windows.Forms.TextBox()
        Me.tharga = New System.Windows.Forms.TextBox()
        Me.tppn = New System.Windows.Forms.TextBox()
        Me.ttotal = New System.Windows.Forms.TextBox()
        Me.tpemakai = New System.Windows.Forms.TextBox()
        Me.ttotalbayar = New System.Windows.Forms.TextBox()
        Me.Cjenis = New System.Windows.Forms.ComboBox()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnmulai = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.tnama = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NO REKENING"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TOTAL BAYAR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PPN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "JENIS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "HARGA PER M3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "BANYAK PEMAKAIAN"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "NAMA"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 156)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "TOTAL"
        '
        'tnorek
        '
        Me.tnorek.Location = New System.Drawing.Point(151, 22)
        Me.tnorek.Name = "tnorek"
        Me.tnorek.Size = New System.Drawing.Size(121, 20)
        Me.tnorek.TabIndex = 8
        '
        'tharga
        '
        Me.tharga.Location = New System.Drawing.Point(151, 101)
        Me.tharga.Name = "tharga"
        Me.tharga.Size = New System.Drawing.Size(121, 20)
        Me.tharga.TabIndex = 9
        '
        'tppn
        '
        Me.tppn.Location = New System.Drawing.Point(151, 179)
        Me.tppn.Name = "tppn"
        Me.tppn.Size = New System.Drawing.Size(121, 20)
        Me.tppn.TabIndex = 10
        '
        'ttotal
        '
        Me.ttotal.Location = New System.Drawing.Point(151, 153)
        Me.ttotal.Name = "ttotal"
        Me.ttotal.Size = New System.Drawing.Size(121, 20)
        Me.ttotal.TabIndex = 11
        '
        'tpemakai
        '
        Me.tpemakai.Location = New System.Drawing.Point(151, 127)
        Me.tpemakai.Name = "tpemakai"
        Me.tpemakai.Size = New System.Drawing.Size(121, 20)
        Me.tpemakai.TabIndex = 12
        '
        'ttotalbayar
        '
        Me.ttotalbayar.Location = New System.Drawing.Point(151, 205)
        Me.ttotalbayar.Name = "ttotalbayar"
        Me.ttotalbayar.Size = New System.Drawing.Size(121, 20)
        Me.ttotalbayar.TabIndex = 14
        '
        'Cjenis
        '
        Me.Cjenis.FormattingEnabled = True
        Me.Cjenis.Items.AddRange(New Object() {"Perumahan", "Perkantoran", "Bisnis"})
        Me.Cjenis.Location = New System.Drawing.Point(151, 74)
        Me.Cjenis.Name = "Cjenis"
        Me.Cjenis.Size = New System.Drawing.Size(121, 21)
        Me.Cjenis.TabIndex = 15
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(315, 23)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 23)
        Me.btntambah.TabIndex = 16
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'btnmulai
        '
        Me.btnmulai.Location = New System.Drawing.Point(315, 52)
        Me.btnmulai.Name = "btnmulai"
        Me.btnmulai.Size = New System.Drawing.Size(75, 23)
        Me.btnmulai.TabIndex = 17
        Me.btnmulai.Text = "Mulai"
        Me.btnmulai.UseVisualStyleBackColor = True
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(315, 81)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnkeluar.TabIndex = 18
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'tnama
        '
        Me.tnama.Location = New System.Drawing.Point(151, 48)
        Me.tnama.Name = "tnama"
        Me.tnama.Size = New System.Drawing.Size(121, 20)
        Me.tnama.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 261)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnmulai)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.Cjenis)
        Me.Controls.Add(Me.ttotalbayar)
        Me.Controls.Add(Me.tnama)
        Me.Controls.Add(Me.tpemakai)
        Me.Controls.Add(Me.ttotal)
        Me.Controls.Add(Me.tppn)
        Me.Controls.Add(Me.tharga)
        Me.Controls.Add(Me.tnorek)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
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
    Friend WithEvents tnorek As System.Windows.Forms.TextBox
    Friend WithEvents tharga As System.Windows.Forms.TextBox
    Friend WithEvents tppn As System.Windows.Forms.TextBox
    Friend WithEvents ttotal As System.Windows.Forms.TextBox
    Friend WithEvents tpemakai As System.Windows.Forms.TextBox
    Friend WithEvents ttotalbayar As System.Windows.Forms.TextBox
    Friend WithEvents Cjenis As System.Windows.Forms.ComboBox
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents btnmulai As System.Windows.Forms.Button
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents tnama As System.Windows.Forms.TextBox

End Class
