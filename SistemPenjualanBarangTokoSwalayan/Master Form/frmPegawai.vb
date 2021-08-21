Imports DevExpress.XtraGrid.Views.Base
Imports System.Globalization
Public Class frmPegawai

    Private Sub frmPegawai_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case e.Control And Keys.Enter
                SimpanData()
            Case Keys.F5
                RefreshData()
            Case Keys.Escape
                Me.Close()
            Case Keys.F2
                UbahData()
            Case e.Control And Keys.Delete
                HapusData()
            Case e.Control And Keys.P
                CetakData()

        End Select
    End Sub

    Private Sub frmPegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        txtKodePegawai.Properties.ReadOnly = True
        txtKodePegawai.TabStop = False
        txtNamaAkses.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor

        RefreshData()
        txtPassword.Properties.UseSystemPasswordChar = True

    End Sub
    Dim Tampung As New DataTable
    Sub TampilData()
        Tampung = EksekusiQuery("Select * From Pegawai where KodePegawai<>'PGW0000000'")
        GridControl1.DataSource = Tampung
        GridviewEditTampilan(GridView1, "Password")
        'With GridView1
        '    .Columns("Password").Visible = False
        '    .BestFitColumns()

        'End With

    End Sub



    Sub RefreshData()
        TampilData()
        txtKodePegawai.Text = KodeOtomatis("pegawai", "KodePegawai", "PGW", "0000000")
        txtNamaPegawai.Text = ""
        txtJabatan.Text = ""
        txtAlamat.Text = ""
        txtEmail.Text = ""
        txtNamaAkses.Text = ""
        txtNomorTelepon.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtNamaPegawai.Focus()
    End Sub

    Sub SimpanData()
        If txtKodePegawai.Text = "" Or txtNamaPegawai.Text = "" Or txtJabatan.Text = "" Or txtAlamat.Text = "" Or txtNomorTelepon.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Or txtNamaAkses.Text = "" Then
            MessageBox.Show("Kode Pegawai, Nama Pegawai, Jabatan, Alamat, Nomor telepon,Username,Pasword dan Nama Akses wajib di isi!", "validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim Cari = EksekusiQuery("SELECT * FROM pegawai WHERE KodePegawai='" & txtKodePegawai.Text & "'").Select()
        If Cari.Length = 0 Then
            EksekusiQuery("INSERT INTO pegawai(KodePegawai,NamaPegawai,Jabatan,Alamat,NomorTelepon,Email,Username,Password,NamaAkses) VALUES ('" & txtKodePegawai.Text & "','" & txtNamaPegawai.Text & "','" & txtJabatan.Text & "','" & txtAlamat.Text & "','" & txtNomorTelepon.Text & "','" & txtEmail.Text & "','" & txtUsername.Text & "','" & txtPassword.Text & "','" & txtNamaAkses.Text & "')")
        Else
            EksekusiQuery("UPDATE pegawai SET  NamaPegawai='" & txtNamaPegawai.Text & "',Jabatan='" & txtJabatan.Text & "',Alamat='" & txtAlamat.Text & "',NomorTelepon='" & txtNomorTelepon.Text & "',Email='" & txtEmail.Text & "',Username='" & txtUsername.Text & "',Password='" & txtPassword.Text & "',NamaAkses='" & txtNamaAkses.Text & "'WHERE KodePegawai='" & txtKodePegawai.Text & "'")
        End If
        RefreshData()
        MessageBox.Show("Data Berhasil Disimpan.:", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Sub UbahData()


        If My.Settings.sHakAkses <> "Pemilik" And My.Settings.sHakAkses <> "Pengembang" Then
            Dim PasswordSendiri As String = InputBox("Masukkan Password Anda")
            If PasswordSendiri <> GridView1.GetFocusedRowCellValue("Password") Then
                If MessageBox.Show("Password salah!", "Validasi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Retry Then
                    UbahData()
                    
                End If

                Exit Sub
            End If
        End If
        If GridView1.RowCount > 0 Then
            txtKodePegawai.Text = GridView1.GetFocusedRowCellValue("KodePegawai")
            txtNamaPegawai.Text = GridView1.GetFocusedRowCellValue("NamaPegawai")
            txtJabatan.Text = GridView1.GetFocusedRowCellValue("Jabatan")
            txtAlamat.Text = GridView1.GetFocusedRowCellValue("Alamat")
            txtNomorTelepon.Text = GridView1.GetFocusedRowCellValue("NomorTelepon")
            txtEmail.Text = GridView1.GetFocusedRowCellValue("Email")
            txtNamaAkses.Text = GridView1.GetFocusedRowCellValue("NamaAkses")
            txtUsername.Text = GridView1.GetFocusedRowCellValue("Username")
            txtPassword.Text = GridView1.GetFocusedRowCellValue("Password")
            txtNamaPegawai.Focus()
        End If
    End Sub

    Sub HapusData()
        If GridView1.RowCount > 0 Then
            If MessageBox.Show("Data akan di hapus." & vbCrLf & "Lanjut?", "Validasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                EksekusiQuery("DELETE FROM pegawai WHERE KodePegawai='" & GridView1.GetFocusedRowCellValue("KodePegawai") & "'")
                RefreshData()
            End If
        End If
    End Sub
    Sub CetakData()
        GridControl1.ShowRibbonPrintPreview()

    End Sub




    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        SimpanData()
    End Sub

    Private Sub SimpleButton2_Click_1(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        UbahData()
    End Sub

    Private Sub SimpleButton4_Click_1(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        RefreshData()
    End Sub

    Private Sub SimpleButton3_Click_1(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        HapusData()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        CetakData()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()

    End Sub

    Private Sub txtNamaAkses_GotFocus1(sender As Object, e As EventArgs) Handles txtNamaAkses.GotFocus
        ComboboxTambahItem("hak_akses", "NamaAkses", txtNamaAkses)
    End Sub
End Class