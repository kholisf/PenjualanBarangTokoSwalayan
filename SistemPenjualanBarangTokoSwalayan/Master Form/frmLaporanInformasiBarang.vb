Public Class frmLaporanInformasiBarang
    Dim Tampung As New DataTable
    Dim bulan As String
    Sub TentukanTanggal()
        Select Case txtBulan.SelectedIndex
            Case 0
                bulan = "01"
            Case 1
                bulan = "02"
            Case 2
                bulan = "03"
            Case 3
                bulan = "04"
            Case 4
                bulan = "05"
            Case 5
                bulan = "06"
            Case 6
                bulan = "07"
            Case 7
                bulan = "08"
            Case 8
                bulan = "09"
            Case 9
                bulan = "10"
            Case 10
                bulan = "11"
            Case 11
                bulan = "12"
        End Select
    End Sub
    Sub TampilLaporan()
        GridControl1.DataSource = Nothing
        GridView1.Columns.Clear()
        Select Case txtKategori.SelectedIndex
            Case 0
                TentukanTanggal()
                Tampung = EksekusiQuery("select * from barang where Kedaluwarsa<='" & Format(Now, "yyyy-" & bulan & "-dd HH:mm:ss") & "' and KodeBarang<>'0000000000' order by Kedaluwarsa asc")
                GridControl1.DataSource = Tampung
                GridviewEditTampilan(GridView1, , "HargaJual,HargaBeli,Stok")
            Case 1
                If txtStok.Value < 0 Then
                    MessageBox.Show("Stok tidak valid!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                Tampung = EksekusiQuery("select * from barang where Stok<='" & txtStok.Value & "' and KodeBarang<>'0000000000'")
                GridControl1.DataSource = Tampung
                GridviewEditTampilan(GridView1, , "HargaJual,HargaBeli,Stok")
            Case 2
                Tampung = EksekusiQuery("select * from barang where Kategori='" & txtKategoriBarang.Text & "'and KodeBarang<>'0000000000'")
                GridControl1.DataSource = Tampung
                GridviewEditTampilan(GridView1, , "HargaJual,HargaBeli,Stok")
        End Select
    End Sub
    Private Sub frmLaporanInformasiBarang_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
            Case Keys.Enter
                TampilLaporan()
            Case Keys.F2
                edit()
            Case e.Control And Keys.P
                cetak()
        End Select
    End Sub
    Private Sub frmLaporanInformasiBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        txtKategori.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        txtStok.Value = 0
        txtBulan.SelectedIndex = Format(Now, "MM") - 1
        txtKategori.SelectedIndex = 0
        TampilLaporan()
    End Sub
    Private Sub txtKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtKategori.SelectedIndexChanged
        Select Case txtKategori.SelectedIndex
            Case 0
                txtStok.Enabled = False
                txtBulan.Enabled = True
                txtKategoriBarang.Enabled = False
            Case 1
                txtStok.Enabled = True
                txtBulan.Enabled = False
                txtKategoriBarang.Enabled = False
            Case 2
                txtStok.Enabled = False
                txtBulan.Enabled = False
                txtKategoriBarang.Enabled = True
        End Select
    End Sub
    Sub cetak()
        Select Case txtKategori.SelectedIndex
            Case 0
                ReportLaporanInformasiBarang("Kedaluwarsa<='" & Format(Now, "yyyy-" & bulan & "-dd") & "' ", "Laporan Barang Kedaluwarsa pada bulan " & txtBulan.Text & " depan  ", "Kedaluwarsa")
            Case 1
                ReportLaporanInformasiBarang("Stok<='" & txtStok.Value & "'", "Laporan Dengan Jumlah Stok kurang dari " & txtStok.Value & "", "Stok")
            Case 2
                ReportLaporanInformasiBarang("Kategori='" & txtKategoriBarang.Text & "'", "Barang-barang Dengan Kategori " & txtKategori.Text & "", "Kategori")
        End Select
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        cetak()
    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        TampilLaporan()
    End Sub
    Private Sub txtBulan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtBulan.SelectedIndexChanged
        TentukanTanggal()
    End Sub
    Sub edit()
        If GridView1.RowCount > 0 Then
            With frmBarang
                .MdiParent = frmMenuUtama
                .WindowState = FormWindowState.Maximized
                .Show()
                .txtKodeBarang.Text = GridView1.GetFocusedRowCellValue("KodeBarang")
                .txtNamaBarang.Text = GridView1.GetFocusedRowCellValue("NamaBarang")
                .txtHargaBeli.Text = GridView1.GetFocusedRowCellValue("HargaBeli")
                .txtHargaJual.Text = GridView1.GetFocusedRowCellValue("HargaJual")
                .txtKategori.Text = GridView1.GetFocusedRowCellValue("Kategori")
                .txtKedaluwarsa.Text = GridView1.GetFocusedRowCellValue("Kedaluwarsa")
                .txtKeterangan.Text = GridView1.GetFocusedRowCellValue("Keterangan")
                .txtSatuan.Text = GridView1.GetFocusedRowCellValue("Satuan")
                .txtStok.Text = GridView1.GetFocusedRowCellValue("Stok")
            End With
        End If
    End Sub
    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        edit()
    End Sub
    Private Sub txtKategoriBarang_GotFocus(sender As Object, e As EventArgs) Handles txtKategoriBarang.GotFocus
        ComboboxTambahItem("barang", "Kategori", txtKategoriBarang)
    End Sub
End Class