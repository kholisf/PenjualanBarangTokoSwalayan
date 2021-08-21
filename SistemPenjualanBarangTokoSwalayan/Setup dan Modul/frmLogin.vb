Imports MySql.Data.MySqlClient
Public Class frmLogin
    Sub login()
        Try
            If txtUsername.Text = "" Or txtPassword.Text = "" Then
                MessageBox.Show("Username dan Password wajib diisi", "validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Dim Cari = EksekusiQuery("select * from pegawai where binary Username='" & txtUsername.Text & "' and  binary Password='" & txtPassword.Text & "'").Select()
            If Cari.Length > 0 Then
                My.Settings.sKodePegawai = Cari(0).Item("KodePegawai")
                My.Settings.sNamaPegawai = Cari(0).Item("NamaPegawai")
                My.Settings.sUsername = Cari(0).Item("Username")
                My.Settings.sPassword = Cari(0).Item("Password")
                My.Settings.sHakAkses = Cari(0)("NamaAkses")
                frmMenuUtama.Show()
                Me.Close()
            Else
                MessageBox.Show("Username/Password salah!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            If MessageBox.Show("Koneksi ke server gagal!" & vbCrLf & "Lanjutkan ke Konfigurasi server", "Validasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                frmSetupKonfigurasiServer.ShowDialog()
            End If
        End Try

    End Sub
    Sub tampilpassword()
        If CheckEdit1.CheckState = CheckState.Checked Then
            txtPassword.Properties.UseSystemPasswordChar = False
        Else
            txtPassword.Properties.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub frmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                login()
            Case Keys.Escape
                Application.Exit()
        End Select
    End Sub
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.KeyPreview = True
        txtUsername.Focus()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        login()
    End Sub
    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Application.Exit()
    End Sub
    
    
    Private Sub CheckEdit1_CheckStateChanged1(sender As Object, e As EventArgs) Handles CheckEdit1.CheckStateChanged
        tampilpassword()
    End Sub

    Private Sub txtPassword_GotFocus1(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        tampilpassword()
    End Sub
End Class
