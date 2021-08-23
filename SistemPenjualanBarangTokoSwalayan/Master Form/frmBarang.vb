Imports DevExpress.XtraGrid.Views.Base
Imports System.Globalization
Public Class frmBarang
    Private Sub frmBarang_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub frmBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        txtKodeBarang.Properties.ReadOnly = True
        txtKodeBarang.TabStop = False
        RefreshData()
    End Sub
    Dim Tampung As New DataTable
    Sub TampilData()
        Tampung = EksekusiQuery("Select * From barang where KodeBarang<>'0000000000'")
        GridControl1.DataSource = Tampung
        GridviewEditTampilan(GridView1, , "HargaJual,HargaBeli,Stok")
    End Sub
    Sub RefreshData()
        TampilData()
        txtKodeBarang.Text = KodeOtomatis("barang", "KodeBarang", "BRG", "0000000")
        txtNamaBarang.Text = ""
        txtKategori.Text = ""
        txtSatuan.Text = ""
        txtHargaBeli.Value = 0
        txtHargaJual.Value = 0
        txtStok.Value = 0
        txtKedaluwarsa.DateTime = Format(Now, "yyyy-MM-dd")
        txtKeterangan.Text = ""

        txtNamaBarang.Focus()
    End Sub

    Sub SimpanData()
        If txtKodeBarang.Text = "" Or txtNamaBarang.Text = "" Or txtKategori.Text = "" Or txtSatuan.Text = "" Or txtHargaBeli.Value <= 0 Or txtHargaJual.Value <= 0 Or txtStok.Value < 0 Then
            MessageBox.Show("Kode Barang, Nama Barang, Kategori, Satuan, Harga beli, Harga Jual, Stok dan Kedaluwarsa wajib di isi!", "validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If txtKedaluwarsa.DateTime <= Format(Now, "yyyy-MM-dd") Then
            If MessageBox.Show("Apakah Barang Memiliki tanggal kedaluwarsa ", "Validasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                MessageBox.Show("Tanggal Kedaluwarsa yang di tambah tidak Benar!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                Dim Keterangan = EksekusiQuery("select Keterangan from barang where KodeBarang='" & txtKodeBarang.Text & "'").Select()
                If Keterangan.Length = 0 Then
                    txtKeterangan.Text = "Barang Tidak Memiliki Tanggal Kadaluwarsa!!, " & txtKeterangan.Text
                Else
                    Dim isi() As String = Keterangan(0).Item("Keterangan").split("!!")
                    If isi(0) <> "Barang Tidak Memiliki Tanggal Kadaluwarsa" Then
                        txtKeterangan.Text = "Barang Tidak Memiliki Tanggal Kadaluwarsa!!, " & txtKeterangan.Text
                    End If
                End If
            End If
        End If
        Dim Cari = EksekusiQuery("SELECT * FROM barang WHERE KodeBarang='" & txtKodeBarang.Text & "'").Select()

        If Cari.Length = 0 Then
            EksekusiQuery("INSERT INTO barang(KodeBarang,NamaBarang,Kategori,Satuan,HargaBeli,HargaJual,Stok,Kedaluwarsa,Keterangan) VALUES ('" & txtKodeBarang.Text & "','" & txtNamaBarang.Text & "','" & txtKategori.Text & "','" & txtSatuan.Text & "','" & txtHargaBeli.Value & "','" & txtHargaJual.Value & "','" & txtStok.Value & "','" & Format(txtKedaluwarsa.DateTime, "yyyy-MM-dd") & "','" & txtKeterangan.Text & "')")
        Else
            EksekusiQuery("UPDATE barang SET  NamaBarang='" & txtNamaBarang.Text & "',Kategori='" & txtKategori.Text & "',Satuan='" & txtSatuan.Text & "',HargaBeli='" & txtHargaBeli.Value & "',HargaJual='" & txtHargaJual.Value & "',Stok='" & txtStok.Value & "',Kedaluwarsa='" & Format(txtKedaluwarsa.DateTime, "yyyy-MM-dd") & "',Keterangan='" & txtKeterangan.Text & "'WHERE KodeBarang='" & txtKodeBarang.Text & "'")
        End If
        RefreshData()
        MessageBox.Show("Data Berhasil Disimpan!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Sub UbahData()
        If GridView1.RowCount > 0 Then
            txtKodeBarang.Text = GridView1.GetFocusedRowCellValue("KodeBarang")
            txtNamaBarang.Text = GridView1.GetFocusedRowCellValue("NamaBarang")
            txtKategori.Text = GridView1.GetFocusedRowCellValue("Kategori")
            txtSatuan.Text = GridView1.GetFocusedRowCellValue("Satuan")
            txtHargaBeli.Value = GridView1.GetFocusedRowCellValue("HargaBeli")
            txtHargaJual.Value = GridView1.GetFocusedRowCellValue("HargaJual")
            txtStok.Value = GridView1.GetFocusedRowCellValue("Stok")
            txtKedaluwarsa.DateTime = Format(GridView1.GetFocusedRowCellValue("Kedaluwarsa"), "yyyy-MM-dd")
            txtKeterangan.Text = GridView1.GetFocusedRowCellValue("Keterangan")
            txtNamaBarang.Focus()
        End If

    End Sub

    Sub HapusData()
        If GridView1.RowCount > 0 Then
            EksekusiQuery("UPDATE penjualan_detil set KodeBarang='0000000000' WHERE KodeBarang='" & GridView1.GetFocusedRowCellValue("KodeBarang") & "'")
            EksekusiQuery("UPDATE pembelian_detil set KodeBarang='0000000000' WHERE KodeBarang='" & GridView1.GetFocusedRowCellValue("KodeBarang") & "'")
            If MessageBox.Show("Data akan di hapus." & vbCrLf & "Lanjut?", "Validasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                EksekusiQuery("DELETE FROM barang WHERE KodeBarang='" & GridView1.GetFocusedRowCellValue("KodeBarang") & "'")
                RefreshData()
            End If
        End If
    End Sub
    Sub CetakData()
        GridControl1.ShowRibbonPrintPreview()

    End Sub
    Private Sub txtSatuan_GotFocus(sender As Object, e As EventArgs)
        ComboboxTambahItem("barang", "Satuan", txtSatuan)

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

    Private Sub txtKategori_GotFocus1(sender As Object, e As EventArgs) Handles txtKategori.GotFocus
        ComboboxTambahItem("barang", "Kategori", txtKategori)
    End Sub

    Private Sub txtSatuan_GotFocus1(sender As Object, e As EventArgs) Handles txtSatuan.GotFocus
        ComboboxTambahItem("barang", "Satuan", txtSatuan)
    End Sub
End Class