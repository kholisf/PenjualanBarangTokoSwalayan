Public Class frmGantiPassword

    Private Sub frmGantiPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilpassword()


        SimpleButton1.Enabled = False
        
    End Sub
    Sub simpan()
        
        If txtPLama.Text = My.Settings.sPassword Then
            EksekusiQuery("update pegawai set Password='" & txtUlangiPBaru.Text & "' where KodePegawai='" & My.Settings.sKodePegawai & "'")
            MessageBox.Show("Password Berhasil di ubah!!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()


        Else
            MessageBox.Show("Password Lama yang di masukkan salah !!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If


    End Sub
    Sub tampilpassword()
        If CheckEdit1.CheckState = CheckState.Checked Then
            txtPBaru.Properties.UseSystemPasswordChar = False
            txtPLama.Properties.UseSystemPasswordChar = False
            txtUlangiPBaru.Properties.UseSystemPasswordChar = False
        Else
            txtPBaru.Properties.UseSystemPasswordChar = True
            txtPLama.Properties.UseSystemPasswordChar = True
            txtUlangiPBaru.Properties.UseSystemPasswordChar = True
        End If
    End Sub
    Sub CekPasswordBaru()

        If txtPBaru.Text = "" Or txtUlangiPBaru.Text = "" Then
            SimpleButton1.Enabled = False
            Label4.Text = ""
        Else
            If txtPBaru.Text = txtUlangiPBaru.Text Then
                Label4.Text = "Password Sudah Benar"
                SimpleButton1.Enabled = True

            Else
                Label4.Text = "Password Tidak Sesuai Dengan Yang Baru"
                SimpleButton1.Enabled = False
            End If

        End If

        

    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

    Private Sub CheckEdit1_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckStateChanged
        tampilpassword()

    End Sub

    Private Sub txtUlangiPBaru_EditValueChanged(sender As Object, e As EventArgs) Handles txtUlangiPBaru.EditValueChanged
        CekPasswordBaru()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        simpan()
    End Sub

    Private Sub txtPBaru_EditValueChanged(sender As Object, e As EventArgs) Handles txtPBaru.EditValueChanged
        CekPasswordBaru()
    End Sub
End Class