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
        Me.nama_astri = New System.Windows.Forms.TextBox()
        Me.ipk_astri = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bMulai_astri = New System.Windows.Forms.Button()
        Me.bHasil_astri = New System.Windows.Forms.Button()
        Me.bReset_astri = New System.Windows.Forms.Button()
        Me.bKeluar_astri = New System.Windows.Forms.Button()
        Me.hslnama_astri = New System.Windows.Forms.Label()
        Me.hslipk_astri = New System.Windows.Forms.Label()
        Me.hslgelar_astri = New System.Windows.Forms.Label()
        Me.npm_astri = New System.Windows.Forms.ComboBox()
        Me.jml_astri = New System.Windows.Forms.NumericUpDown()
        Me.Panel1.SuspendLayout()
        CType(Me.jml_astri, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(64, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Program Kelulusan Sederhana"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(18, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NPM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(18, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Location = New System.Drawing.Point(18, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jumlah Semester"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Location = New System.Drawing.Point(18, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "IPK"
        '
        'nama_astri
        '
        Me.nama_astri.Location = New System.Drawing.Point(111, 78)
        Me.nama_astri.Name = "nama_astri"
        Me.nama_astri.Size = New System.Drawing.Size(183, 20)
        Me.nama_astri.TabIndex = 6
        '
        'ipk_astri
        '
        Me.ipk_astri.Location = New System.Drawing.Point(111, 130)
        Me.ipk_astri.Name = "ipk_astri"
        Me.ipk_astri.Size = New System.Drawing.Size(183, 20)
        Me.ipk_astri.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.hslgelar_astri)
        Me.Panel1.Controls.Add(Me.hslipk_astri)
        Me.Panel1.Controls.Add(Me.hslnama_astri)
        Me.Panel1.Location = New System.Drawing.Point(12, 160)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(378, 104)
        Me.Panel1.TabIndex = 9
        '
        'bMulai_astri
        '
        Me.bMulai_astri.Location = New System.Drawing.Point(300, 52)
        Me.bMulai_astri.Name = "bMulai_astri"
        Me.bMulai_astri.Size = New System.Drawing.Size(75, 25)
        Me.bMulai_astri.TabIndex = 10
        Me.bMulai_astri.Text = "Mulai"
        Me.bMulai_astri.UseVisualStyleBackColor = True
        '
        'bHasil_astri
        '
        Me.bHasil_astri.Location = New System.Drawing.Point(300, 76)
        Me.bHasil_astri.Name = "bHasil_astri"
        Me.bHasil_astri.Size = New System.Drawing.Size(75, 25)
        Me.bHasil_astri.TabIndex = 11
        Me.bHasil_astri.Text = "Hasil"
        Me.bHasil_astri.UseVisualStyleBackColor = True
        '
        'bReset_astri
        '
        Me.bReset_astri.Location = New System.Drawing.Point(300, 100)
        Me.bReset_astri.Name = "bReset_astri"
        Me.bReset_astri.Size = New System.Drawing.Size(75, 25)
        Me.bReset_astri.TabIndex = 12
        Me.bReset_astri.Text = "Reset"
        Me.bReset_astri.UseVisualStyleBackColor = True
        '
        'bKeluar_astri
        '
        Me.bKeluar_astri.Location = New System.Drawing.Point(300, 124)
        Me.bKeluar_astri.Name = "bKeluar_astri"
        Me.bKeluar_astri.Size = New System.Drawing.Size(75, 25)
        Me.bKeluar_astri.TabIndex = 13
        Me.bKeluar_astri.Text = "Keluar"
        Me.bKeluar_astri.UseVisualStyleBackColor = True
        '
        'hslnama_astri
        '
        Me.hslnama_astri.AutoSize = True
        Me.hslnama_astri.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hslnama_astri.Location = New System.Drawing.Point(14, 15)
        Me.hslnama_astri.Name = "hslnama_astri"
        Me.hslnama_astri.Size = New System.Drawing.Size(57, 20)
        Me.hslnama_astri.TabIndex = 0
        Me.hslnama_astri.Text = "Label6"
        '
        'hslipk_astri
        '
        Me.hslipk_astri.AutoSize = True
        Me.hslipk_astri.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hslipk_astri.Location = New System.Drawing.Point(14, 40)
        Me.hslipk_astri.Name = "hslipk_astri"
        Me.hslipk_astri.Size = New System.Drawing.Size(57, 20)
        Me.hslipk_astri.TabIndex = 1
        Me.hslipk_astri.Text = "Label7"
        '
        'hslgelar_astri
        '
        Me.hslgelar_astri.AutoSize = True
        Me.hslgelar_astri.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hslgelar_astri.Location = New System.Drawing.Point(12, 60)
        Me.hslgelar_astri.Name = "hslgelar_astri"
        Me.hslgelar_astri.Size = New System.Drawing.Size(101, 31)
        Me.hslgelar_astri.TabIndex = 2
        Me.hslgelar_astri.Text = "Label8"
        '
        'npm_astri
        '
        Me.npm_astri.FormattingEnabled = True
        Me.npm_astri.Items.AddRange(New Object() {"432007006190065", "432007006190068", "432007006190056", "432007006190078"})
        Me.npm_astri.Location = New System.Drawing.Point(111, 51)
        Me.npm_astri.Name = "npm_astri"
        Me.npm_astri.Size = New System.Drawing.Size(183, 21)
        Me.npm_astri.TabIndex = 14
        '
        'jml_astri
        '
        Me.jml_astri.Location = New System.Drawing.Point(112, 105)
        Me.jml_astri.Name = "jml_astri"
        Me.jml_astri.Size = New System.Drawing.Size(182, 20)
        Me.jml_astri.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(402, 276)
        Me.Controls.Add(Me.jml_astri)
        Me.Controls.Add(Me.npm_astri)
        Me.Controls.Add(Me.bKeluar_astri)
        Me.Controls.Add(Me.bReset_astri)
        Me.Controls.Add(Me.bHasil_astri)
        Me.Controls.Add(Me.bMulai_astri)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ipk_astri)
        Me.Controls.Add(Me.nama_astri)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.jml_astri, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nama_astri As System.Windows.Forms.TextBox
    Friend WithEvents ipk_astri As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents hslgelar_astri As System.Windows.Forms.Label
    Friend WithEvents hslipk_astri As System.Windows.Forms.Label
    Friend WithEvents hslnama_astri As System.Windows.Forms.Label
    Friend WithEvents bMulai_astri As System.Windows.Forms.Button
    Friend WithEvents bHasil_astri As System.Windows.Forms.Button
    Friend WithEvents bReset_astri As System.Windows.Forms.Button
    Friend WithEvents bKeluar_astri As System.Windows.Forms.Button
    Friend WithEvents npm_astri As System.Windows.Forms.ComboBox
    Friend WithEvents jml_astri As System.Windows.Forms.NumericUpDown

End Class
