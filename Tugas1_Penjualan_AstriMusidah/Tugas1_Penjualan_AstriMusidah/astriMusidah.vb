Public Class astriMusidah

    Private Sub astriMusidah_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        kode_astri.Items.Add("P001")
        kode_astri.Items.Add("P002")
        kode_astri.Items.Add("P003")
    End Sub

    Private Sub kode_astri_TextChanged(sender As Object, e As System.EventArgs) Handles kode_astri.TextChanged
        If kode_astri.Text = "P001" Then
            nama_astri.Text = "Indomie Goreng"
            harga_astri.Text = "3000"
        ElseIf kode_astri.Text = "P002" Then
            nama_astri.Text = "Indomie Goreng Ayam Geprek"
            harga_astri.Text = "3500"
        ElseIf kode_astri.Text = "P003" Then
            nama_astri.Text = "Indomie Goreng Aceh"
            harga_astri.Text = "4000"
        End If
        jmlBeli_astri.Focus()
    End Sub

    Private Sub btnHitung_astri_Click(sender As System.Object, e As System.EventArgs) Handles btnHitung_astri.Click
        jmlBayar_astri.Text = Val(harga_astri.Text) * Val(jmlBeli_astri.Text)
        If Val(jmlBayar_astri.Text) >= 100000 Then
            diskon_astri.Text = Val(jmlBayar_astri.Text) * 10 / 100
        Else
            diskon_astri.Text = 0
        End If
        total_astri.Text = Val(jmlBayar_astri.Text) - Val(diskon_astri.Text)
    End Sub
    Private Sub btnBersih_astri_Click(sender As System.Object, e As System.EventArgs) Handles btnBersih_astri.Click
        kode_astri.Text = ""
        nama_astri.Text = ""
        harga_astri.Text = ""
        jmlBeli_astri.Text = ""
        jmlBayar_astri.Text = ""
        diskon_astri.Text = ""
        total_astri.Text = ""
        kode_astri.Focus()
    End Sub

    Private Sub btnKeluar_astri_Click(sender As System.Object, e As System.EventArgs) Handles btnKeluar_astri.Click
        Me.Close()
    End Sub
End Class