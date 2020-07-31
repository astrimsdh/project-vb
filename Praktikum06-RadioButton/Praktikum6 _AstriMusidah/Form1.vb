Public Class Form1

    Private Sub btnKeluar_Click(sender As System.Object, e As System.EventArgs) Handles btnKeluar.Click
        Close()
    End Sub
    Sub Hasil()
        Pendapatan.Text = Val(tTotal.Text) + Val(Gaji.Text)
    End Sub

    Private Sub btnMulai_Click(sender As System.Object, e As System.EventArgs) Handles btnMulai.Click
        Nik.Text = ""
        Nama.Text = ""
        sMenikah.Checked = False
        sBelum.Checked = False
        jmlAnak.Text = ""
        Gaji.Text = ""
        tAnak.Text = ""
        tIstri.Text = ""
        tTotal.Text = ""
        Pendapatan.Text = ""
        jmlAnak.Enabled = False
        Me.Focus()
    End Sub

    Private Sub sMenikah_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles sMenikah.CheckedChanged
        jmlAnak.Enabled = True
        tIstri.Text = Val(Gaji.Text) * 30 / 100
        tTotal.Text = Val(tAnak.Text) + Val(tIstri.Text)
        Call Hasil()
    End Sub

    Private Sub sBelum_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles sBelum.CheckedChanged
        jmlAnak.Text = 0
        jmlAnak.Enabled = False
        tAnak.Text = 0
        tIstri.Text = 0
        tTotal.Text = 0
        Call Hasil()
    End Sub

    Private Sub jmlAnak_TextChanged(sender As System.Object, e As System.EventArgs) Handles jmlAnak.TextChanged
        If Val(jmlAnak.Text) >= 3 Then
            tAnak.Text = 2 * Val(Gaji.Text) * 20 / 100
        Else
            tAnak.Text = Val(jmlAnak.Text) * Val(Gaji.Text) * 20 / 100
        End If
        tIstri.Text = Val(Gaji.Text) * 30 / 100
        tTotal.Text = Val(tAnak.Text) + Val(tIstri.Text)
        Call Hasil()
    End Sub

    Private Sub Nik_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Nik.SelectedIndexChanged
        If Nik.Text = "001" Then
            Nama.Text = "Astri Musidah"
            Gaji.Text = 10000000
        ElseIf Nik.Text = "002" Then
            Nama.Text = "Rubby Herdandy"
            Gaji.Text = 2000000
        ElseIf Nik.Text = "003" Then
            Nama.Text = "Ayi Zakiyatul"
            Gaji.Text = 3000000
        ElseIf Nik.Text = "004" Then
            Nama.Text = "Irfan Fauzi"
            Gaji.Text = 4000000
        Else
            Nama.Text = "Mida Muharmadani"
            Gaji.Text = 5000000
        End If
    End Sub

    Private Sub Nama_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Nama.SelectedIndexChanged
        If Nama.Text = "Astri Musidah" Then
            Nik.Text = "001"
            Gaji.Text = 10000000
        ElseIf Nama.Text = "Rubby Herdandy" Then
            Nik.Text = "002"
            Gaji.Text = 2000000
        ElseIf Nama.Text = "Ayi Zakiyatul" Then
            Nik.Text = "003"
            Gaji.Text = 3000000
        ElseIf Nama.Text = "Irfan Fauzi" Then
            Nik.Text = "004"
            Gaji.Text = 4000000
        Else
            Nik.Text = "005"
            Gaji.Text = 5000000
        End If
    End Sub
End Class
