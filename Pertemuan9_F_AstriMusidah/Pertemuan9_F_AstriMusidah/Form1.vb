Imports System.Data.OleDb
Public Class Form1
    Private conn As OleDbConnection = Nothing
    Private cmd As OleDbCommand = Nothing
    Private sql As String = Nothing
    Private da As OleDbDataAdapter = Nothing
    Private reader As OleDbDataReader = Nothing
    Function Connect()
        If Not conn Is Nothing Then
            conn.Close()
        End If
        conn.Open()
        Return conn
    End Function
    Function closedd()
        conn.Close()
        Return conn
    End Function
    Sub loadData()
        Connect()
        sql = "Select NIS from siswa"
        cmd = New OleDbCommand(sql, conn)
        reader = cmd.ExecuteReader()
        Try
            cbNis.Items.Clear()
            While reader.Read
                cbNis.Items.Add(reader.GetString(0))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        closedd()
    End Sub
    Sub tampil()
        Connect()
        Try
            Dim dt As New DataTable
            da = New OleDbDataAdapter("Select * from siswa", conn)
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        closedd()
    End Sub
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Not conn Is Nothing Then conn.Close()
        Dim connString As String
        connString = "Provider=Microsot.ACE.OLEDB.12.0;Data Souce" & Application.StartupPath & "\biodata.accdb"
        Try
            conn = New OleDbConnection(connString)
            conn.Close()
            Me.Text = "Mengubah data Anggota [cnnected]"
            loadData()
            tampil()_
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Koneksi Error : " + ex.Message)
        End Try
        cbKelas.Items.Add("X-RPL")
        cbKelas.Items.Add("XI-RPL")
        cbKelas.Items.Add("XII-RPL")
        cbKelas.Items.Add("X-OTKP")
        cbKelas.Items.Add("X-TBSM")
        cbKelas.Items.Add("X-TKR")
    End Sub

    Private Sub cbNis_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbNis.SelectedIndexChanged
        Connect()
        Dim kunci As String = cbNis.Text
        sql = "Select * from siswa where nis ='" & kunci & "'"
        cmd = New OleDbCommand(sql, conn)
        reader = cmd.ExecuteReader
        Try
            reader.Read()
            txtnama.Text = reader.GetString(1)
            txtEmail.Text = reader.GetString(2)
            cbKelas.Text = reader.GetString(3)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        closedd()

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Connect()
        Dim index As Integer = cbNis.SelectedIndex
        Dim hasil As Integer
        Dim pesan As DialogResult
        sql = "delete from siswa where nis = '" & cbNis.Text & "'"
        pesan = MessageBox.Show("Yakin menghapus data siswa " & Chr(10) & "dengan id " & cbNis.Text & "...?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        cmd = New OleDbCommand(sql, conn)
        Try
            If pesan = Windows.Forms.DialogResult.Yes = True Then
                hasil = cmd.ExecuteNonQuery
                cbNis.Text = ""
                txtEmail.Text = ""
                txtnama.Text = ""
                tampil()
            End If
        Catch ex As Exception
            MsgBox("failed : " & ex.Message)
        End Try
        closedd()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Connect()
        Dim hasil As Integer
        sql = "Update siswa set nama ='" & txtnama.Text & "', email='" & txtEmail.Text & "', kelas = '" & cbKelas.Text & "' where NIS = '" & cbNis.Text & "'"
        cmd = New OleDbCommand(sql, conn)
        Try
            hasil = cmd.ExecuteNonQuery
            If (hasil > 0) Then
                MessageBox.Show("Data berhasil diubah", "sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cbNis.Text = ""
                txtEmail.Text = ""
                txtnama.Text = ""
                tampil()
                loadData()
            End If
        Catch ex As Exception
            MessageBox.Show("Failed : " & ex.Message)
        End Try
        closedd()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Connect()
        Dim insertQuery As String
        Dim hasil As Integer
        Dim cmd As OleDbCommand
        insertQuery = ("Insert into siswa(NIS, nama, email, kelas) values('" & cbNis.Text & "','" & txtnama.Text & "','" & txtEmail.Text & "','" & cbKelas.Text & "')")
        Try
            cmd = New OleDbCommand(insertQuery, conn)
            hasil = cmd.ExecuteNonQuery
            If hasil > 0 Then
                MessageBox.Show("Data berhasil dimasukkan", "sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cbNis.Text = ""
                txtEmail.Text = ""
                txtnama.Text = ""
                tampil()
                loadData()
            End If
        Catch ex As Exception
            MessageBox.Show("Failed : " & ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error
        End Try
        closedd()
    End Sub
End Class
