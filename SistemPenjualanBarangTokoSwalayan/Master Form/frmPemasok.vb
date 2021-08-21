Imports DevExpress.XtraGrid.Views.Base
Imports System.Globalization
Public Class frmPemasok

    Private Sub frmPemasok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        txtKodePemasok.Properties.ReadOnly = True
        txtKodePemasok.TabStop = False
        RefreshData()


    End Sub
    Dim Tampung As New DataTable
    Sub TampilData()
        Tampung = EksekusiQuery("Select * From pemasok")
        GridControl1.DataSource = Tampung
        GridviewEditTampilan(GridView1)
    End Sub
    Sub RefreshData()
        TampilData()
        txtKodePemasok.Text = KodeOtomatis("pemasok", "KodePemasok", "PMK", "0000000")
        txtNamaPemasok.Text = ""
        txtAlamat.Text = ""
        txtKeterangan.Text = ""
        txtNamaPemasok.Text = ""
        txtNomorTelepon.Text = ""
        txtNamaPemasok.Text = ""
        txtNamaPemasok.Focus()
    End Sub

    Sub SimpanData()
        If txtKodePemasok.Text = "" Or txtNamaPemasok.Text = "" Or txtKeterangan.Text = "" Or txtAlamat.Text = "" Or txtNomorTelepon.Text = "" Then
            MessageBox.Show("Kode Pemasok, Nama Pemasok, Alamat,dan Nomor Telepon wajib di isi!", "validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim Cari = EksekusiQuery("SELECT * FROM pemasok WHERE KodePemasok='" & txtKodePemasok.Text & "'").Select()

        If Cari.Length = 0 Then
            EksekusiQuery("INSERT INTO pemasok(KodePemasok,NamaPemasok,Alamat,NomorTelepon,Keterangan) VALUES ('" & txtKodePemasok.Text & "','" & txtNamaPemasok.Text & "','" & txtAlamat.Text & "','" & txtNomorTelepon.Text & "','" & txtKeterangan.Text & "')")
        Else
            EksekusiQuery("UPDATE pemasok SET  NamaPemasok='" & txtNamaPemasok.Text & "',Alamat='" & txtAlamat.Text & "',NomorTelepon='" & txtNomorTelepon.Text & "',Keterangan='" & txtKeterangan.Text & "' WHERE KodePemasok='" & txtKodePemasok.Text & "'")
        End If
        RefreshData()
        MessageBox.Show("Data Berhasil Disimpan!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Sub UbahData()
        If GridView1.RowCount > 0 Then
            txtKodePemasok.Text = GridView1.GetFocusedRowCellValue("KodePemasok")
            txtNamaPemasok.Text = GridView1.GetFocusedRowCellValue("NamaPemasok")
            txtAlamat.Text = GridView1.GetFocusedRowCellValue("Alamat")
            txtNomorTelepon.Text = GridView1.GetFocusedRowCellValue("NomorTelepon")
            txtKeterangan.Text = GridView1.GetFocusedRowCellValue("Keterangan")
            txtNamaPemasok.Focus()
        End If

    End Sub

    Sub HapusData()
        If GridView1.RowCount > 0 Then
            If MessageBox.Show("Data akan di hapus!!" & vbCrLf & "Lanjut?", "Validasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                EksekusiQuery("DELETE FROM pemasok WHERE KodePemasok='" & GridView1.GetFocusedRowCellValue("KodePemasok") & "'")
                RefreshData()
            End If
        End If
    End Sub



    Private Sub frmPemasok_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Sub CetakData()
        GridControl1.ShowRibbonPrintPreview()

    End Sub


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
        SimpanData()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs)
        UbahData()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs)
        HapusData()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs)
        RefreshData()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()

    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        SimpanData()
    End Sub

    Private Sub SimpleButton3_Click_1(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        HapusData()

    End Sub

    Private Sub SimpleButton4_Click_1(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        RefreshData()

    End Sub

    Private Sub SimpleButton2_Click_1(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        UbahData()

    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        CetakData()

    End Sub
End Class