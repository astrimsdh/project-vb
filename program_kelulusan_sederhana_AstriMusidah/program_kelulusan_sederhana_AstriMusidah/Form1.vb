Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call reset()
        npm_astri.Enabled = False
        nama_astri.Enabled = False
        ipk_astri.Enabled = False
        jml_astri.Enabled = False
    End Sub
    Sub reset()
        Me.npm_astri.Text = ""
        Me.nama_astri.Clear()
        Me.ipk_astri.Clear()
        Me.jml_astri.Value = 0
        Me.hslnama_astri.Text = ""
        Me.hslipk_astri.Text = ""
        Me.hslgelar_astri.Text = ""

    End Sub

    Private Sub bMulai_astri_Click(sender As System.Object, e As System.EventArgs) Handles bMulai_astri.Click
        npm_astri.Enabled = true
        nama_astri.Enabled = True
        ipk_astri.Enabled = True
        jml_astri.Enabled = True
        bMulai_astri.Enabled = False

    End Sub

    Private Sub bReset_astri_Click(sender As System.Object, e As System.EventArgs) Handles bReset_astri.Click
        Call reset()
    End Sub

    Private Sub bKeluar_astri_Click(sender As System.Object, e As System.EventArgs) Handles bKeluar_astri.Click
        Me.Close()
    End Sub

    Private Sub npm_astri_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles npm_astri.SelectedIndexChanged
        If npm_astri.Text = "432007006190065" Then
            nama_astri.Text = "Astri Musidah"
        ElseIf npm_astri.Text = "432007006190068" Then
            nama_astri.Text = "Anggi Anggara"
        ElseIf npm_astri.Text = "432007006190056" Then
            nama_astri.Text = "Shanty sukma galyh kencana"
        ElseIf npm_astri.Text = "432007006190078" Then
            nama_astri.Text = "Ayi zakiyul Hudaya"
        End If
    End Sub

    Private Sub bHasil_astri_Click(sender As System.Object, e As System.EventArgs) Handles bHasil_astri.Click
        Dim gelar As String
        If ipk_astri.Text > 3.5 Then
            If Val(jml_astri.Text) <= 8 Then
                gelar = "Cumlaude"
            Else
                gelar = "Sangat Memuaskan"
            End If
        ElseIf Val(ipk_astri.Text) > 3 And Val(ipk_astri.Text) <= 3.5 Then
            gelar = "Memuaskan"
        Else
            gelar = "Cukup"
        End If
        hslgelar_astri.Text = gelar
        hslipk_astri.Text = ipk_astri.Text
        hslnama_astri.Text = nama_astri.Text
    End Sub
End Class
