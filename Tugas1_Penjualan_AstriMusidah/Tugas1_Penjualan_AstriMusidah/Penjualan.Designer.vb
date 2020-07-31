<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Penjualan
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
        Me.kode_astri = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nama_astri = New System.Windows.Forms.TextBox()
        Me.harga_astri = New System.Windows.Forms.TextBox()
        Me.jmlBeli_astri = New System.Windows.Forms.TextBox()
        Me.jmlBayar_astri = New System.Windows.Forms.TextBox()
        Me.diskon_astri = New System.Windows.Forms.TextBox()
        Me.total_astri = New System.Windows.Forms.TextBox()
        Me.btnHitung_astri = New System.Windows.Forms.Button()
        Me.btnBersih_astri = New System.Windows.Forms.Button()
        Me.btnKeluar_astri = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Program Sederhana Penjualan"
        '
        'kode_astri
        '
        Me.kode_astri.FormattingEnabled = True
        Me.kode_astri.Location = New System.Drawing.Point(153, 83)
        Me.kode_astri.Name = "kode_astri"
        Me.kode_astri.Size = New System.Drawing.Size(155, 21)
        Me.kode_astri.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Kode Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Nama Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Harga Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Jumlah Beli"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Jumlah Bayar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Diskon"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(37, 243)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Total Bayar"
        '
        'nama_astri
        '
        Me.nama_astri.Location = New System.Drawing.Point(153, 110)
        Me.nama_astri.Name = "nama_astri"
        Me.nama_astri.Size = New System.Drawing.Size(155, 20)
        Me.nama_astri.TabIndex = 5
        '
        'harga_astri
        '
        Me.harga_astri.Location = New System.Drawing.Point(153, 136)
        Me.harga_astri.Name = "harga_astri"
        Me.harga_astri.Size = New System.Drawing.Size(155, 20)
        Me.harga_astri.TabIndex = 6
        '
        'jmlBeli_astri
        '
        Me.jmlBeli_astri.Location = New System.Drawing.Point(153, 162)
        Me.jmlBeli_astri.Name = "jmlBeli_astri"
        Me.jmlBeli_astri.Size = New System.Drawing.Size(155, 20)
        Me.jmlBeli_astri.TabIndex = 1
        '
        'jmlBayar_astri
        '
        Me.jmlBayar_astri.Location = New System.Drawing.Point(153, 188)
        Me.jmlBayar_astri.Name = "jmlBayar_astri"
        Me.jmlBayar_astri.Size = New System.Drawing.Size(155, 20)
        Me.jmlBayar_astri.TabIndex = 2
        '
        'diskon_astri
        '
        Me.diskon_astri.Location = New System.Drawing.Point(153, 214)
        Me.diskon_astri.Name = "diskon_astri"
        Me.diskon_astri.Size = New System.Drawing.Size(155, 20)
        Me.diskon_astri.TabIndex = 7
        '
        'total_astri
        '
        Me.total_astri.Location = New System.Drawing.Point(153, 240)
        Me.total_astri.Name = "total_astri"
        Me.total_astri.Size = New System.Drawing.Size(155, 20)
        Me.total_astri.TabIndex = 8
        '
        'btnHitung_astri
        '
        Me.btnHitung_astri.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnHitung_astri.Location = New System.Drawing.Point(41, 289)
        Me.btnHitung_astri.Name = "btnHitung_astri"
        Me.btnHitung_astri.Size = New System.Drawing.Size(75, 23)
        Me.btnHitung_astri.TabIndex = 3
        Me.btnHitung_astri.Text = "Hitung"
        Me.btnHitung_astri.UseVisualStyleBackColor = True
        '
        'btnBersih_astri
        '
        Me.btnBersih_astri.Location = New System.Drawing.Point(136, 289)
        Me.btnBersih_astri.Name = "btnBersih_astri"
        Me.btnBersih_astri.Size = New System.Drawing.Size(75, 23)
        Me.btnBersih_astri.TabIndex = 4
        Me.btnBersih_astri.Text = "Bersih"
        Me.btnBersih_astri.UseVisualStyleBackColor = True
        '
        'btnKeluar_astri
        '
        Me.btnKeluar_astri.Location = New System.Drawing.Point(233, 289)
        Me.btnKeluar_astri.Name = "btnKeluar_astri"
        Me.btnKeluar_astri.Size = New System.Drawing.Size(75, 23)
        Me.btnKeluar_astri.TabIndex = 17
        Me.btnKeluar_astri.Text = "Keluar"
        Me.btnKeluar_astri.UseVisualStyleBackColor = True
        '
        'Penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 353)
        Me.Controls.Add(Me.btnKeluar_astri)
        Me.Controls.Add(Me.btnBersih_astri)
        Me.Controls.Add(Me.btnHitung_astri)
        Me.Controls.Add(Me.total_astri)
        Me.Controls.Add(Me.diskon_astri)
        Me.Controls.Add(Me.jmlBayar_astri)
        Me.Controls.Add(Me.jmlBeli_astri)
        Me.Controls.Add(Me.harga_astri)
        Me.Controls.Add(Me.nama_astri)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.kode_astri)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Penjualan"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents kode_astri As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents nama_astri As System.Windows.Forms.TextBox
    Friend WithEvents harga_astri As System.Windows.Forms.TextBox
    Friend WithEvents jmlBeli_astri As System.Windows.Forms.TextBox
    Friend WithEvents jmlBayar_astri As System.Windows.Forms.TextBox
    Friend WithEvents diskon_astri As System.Windows.Forms.TextBox
    Friend WithEvents total_astri As System.Windows.Forms.TextBox
    Friend WithEvents btnHitung_astri As System.Windows.Forms.Button
    Friend WithEvents btnBersih_astri As System.Windows.Forms.Button
    Friend WithEvents btnKeluar_astri As System.Windows.Forms.Button

End Class
