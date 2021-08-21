Imports MySql.Data.MySqlClient
Public Class frmSetupKonfigurasiServer

    Private Sub frmSetupKonfigurasiServer_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode

            Case e.Control And Keys.Enter
                SimpanKoneksi()
            Case Keys.Enter
                TesKonesi()
            Case Keys.Escape
                Me.Close()


        End Select
    End Sub

    

    Sub TampilData()

        txtNamaServer.Text = My.Settings.sNamaServer
        txtUsername.Text = My.Settings.sUsername
        txtPassword.Text = My.Settings.sPassword
        txtNamaDatabase.Text = My.Settings.sNamaDatabase


    End Sub

    Sub TesKonesi()
        If txtNamaServer.Text = "" Or txtUsername.Text = "" Or txtNamaDatabase.Text = "" Then
            MessageBox.Show("Nama Server, Username, dan Nama Database Wajib diisi!", "Pengecekan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub

        End If

        Try
            Dim Kon As New MySqlConnection("server=" & txtNamaServer.Text & ";user id=" & txtUsername.Text & "; password=" & txtPassword.Text & "; database=" & txtNamaDatabase.Text & "")
            Kon.Open()
            Kon.Close()
            MessageBox.Show("Koneksi Ke Server Berhasil.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub SimpanKoneksi()
        If txtNamaServer.Text = "" Or txtUsername.Text = "" Or txtNamaDatabase.Text = "" Then
            MessageBox.Show("Nama Server, Username, dan Nama Database Wajib diisi!", "Pengecekan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub

        End If

        Try
            Dim Kon As New MySqlConnection("server=" & txtNamaServer.Text & ";user id=" & txtUsername.Text & "; password=" & txtPassword.Text & "; database=" & txtNamaDatabase.Text & " ;convert zero datetime=true")
            Kon.Open()
            Kon.Close()
            My.Settings.sNamaServer = txtNamaServer.Text
            My.Settings.sUsername = txtUsername.Text
            My.Settings.sPassword = txtPassword.Text
            My.Settings.sNamaDatabase = txtNamaDatabase.Text
            My.Settings.sKoneksi = "server=" & txtNamaServer.Text & ";user id=" & txtUsername.Text & "; password=" & txtPassword.Text & "; database=" & txtNamaDatabase.Text & " ;convert zero datetime=true"
            My.Settings.Save()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        TesKonesi()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        SimpanKoneksi()

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Me.Close()

    End Sub

    Private Sub frmSetupKonfigurasiServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        txtPassword.Properties.UseSystemPasswordChar = True
        TampilData()
    End Sub
End Class
