Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btntambah.Click
        Me.tnorek.Clear()
        Me.tharga.Clear()
        Me.tppn.Clear()
        Me.ttotal.Clear()
        Me.tpemakai.Clear()
        Me.tnama.Clear()
        Me.ttotalbayar.Clear()
        Me.Cjenis.Text = ""
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles btnkeluar.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Cjenis.SelectedIndexChanged
        If Cjenis.Text = "Perumahan" Then
            tharga.Text = 1000
        ElseIf Cjenis.Text = "Perkantoran" Then
            tharga.Text = 1500
        ElseIf Cjenis.Text = "Bisnis" Then
            tharga.Text = 2000
        End If
    End Sub

    Private Sub tpemakai_TextChanged(sender As System.Object, e As System.EventArgs) Handles tpemakai.TextChanged
        Dim total, ppn, bayar As Single
        total = Val(tpemakai.Text) * Val(tharga.Text)
        ppn = total * 10 / 100
        bayar = total + ppn
        ttotal.Text = Format(total, "###,###,###")
        tppn.Text = Format(ppn, "###,###,###")
        ttotalbayar.Text = Format(bayar, "###,###,###")
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.tharga.Enabled = False
        Me.ttotal.Enabled = False
        Me.tppn.Enabled = False
        Me.ttotalbayar.Enabled = False
    End Sub
End Class
