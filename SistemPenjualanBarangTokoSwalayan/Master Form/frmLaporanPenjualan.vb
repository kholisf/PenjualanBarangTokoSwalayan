Public Class frmLaporanPenjualan

    Dim Tampung As New DataTable
    Sub TampilLaporan()
        GridControl1.DataSource = Nothing
        GridView1.Columns.Clear()

        Select Case txtKategori.SelectedIndex
            Case 0

                Tampung = EksekusiQuery("select a.NomorTransaksi,a.Tanggal,a.Potongan,count(b.KodeBarang) as JumlahItem,sum((b.HargaSatuan*b.Jumlah) -(b.HargaSatuan*b.Jumlah)*(b.PersenDiskon/100)) as TotalPenjualan,(sum((b.HargaSatuan*b.Jumlah)-(b.HargaSatuan*b.Jumlah)*(b.PersenDiskon/100))-a.Potongan) as TotalPembayaran,a.JumlahUang,a.KodePegawai from (penjualan a inner join penjualan_detil b on a.NomorTransaksi=b.NomorTransaksi) where a.Tanggal>='" & Format(txtTanggalAwal.DateTime, "yyyy-MM-dd 00:00:00") & "' and a.Tanggal<='" & Format(txtTanggalAkhir.DateTime, "yyyy-MM-dd HH:mm:ss") & "' group by a.NomorTransaksi")
                GridControl1.DataSource = Tampung
                GridviewEditTampilan(GridView1, "KodePegawai", "Potongan,TotalPenjualan,TotalPembayaran,JumlahUang", "TotalPembayaran,JumlahUang")

            Case 1

                'If txtKodePemasok.Text = "" Or txtNamaPemasok.Text = "" Then
                '    MessageBox.Show("Pilih dahulu pemasok!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                '    Exit Sub
                'End If
                'Tampung = EksekusiQuery("select a.NomorTransaksi,a.Tanggal,a.KodePemasok,b.NamaPemasok,sum(c.HargaObat*c.Jumlah) as TotalPembelian,a.Keterangan,a.KodePegawai from (pembelian a inner join pemasok b on a.KodePemasok=b.KodePemasok inner join pembelian_detil c on a.NomorTransaksi=c.NomorTransaksi) where a.KodePemasok='" & txtKodePemasok.Text & "' group by a.NomorTransaksi;")
                'GridControl1.DataSource = Tampung
                'GridviewEditTampilan(GridView1, "KodePemasok,KodePegawai", "TotalPembelian", "TotalPembelian")
        End Select


    End Sub

    Private Sub frmLaporanPenjualan_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            'Case Keys.F1
            '    ListPemasok()
            Case Keys.Escape
                Me.Close()
            Case Keys.Enter
                TampilLaporan()
            Case Keys.F2
                DetilLaporan()
            Case e.Control And Keys.P
                cetak()

        End Select
    End Sub


    Private Sub frmLaporanPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        txtKategori.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        txtTanggalAkhir.DateTime = Now
        txtTanggalAwal.DateTime = Now
        txtKategori.SelectedIndex = 0
        TampilLaporan()

    End Sub

    Private Sub txtKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtKategori.SelectedIndexChanged
        Select Case txtKategori.SelectedIndex
            Case 0
                txtTanggalAkhir.Enabled = True
                txtTanggalAwal.Enabled = True
    
                'Case 1

                '    txtTanggalAkhir.Enabled = False
                '    txtTanggalAwal.Enabled = False


        End Select

    End Sub




    Sub cetak()
        Select Case txtKategori.SelectedIndex
            Case 0
                ReportLaporanPenjualan(Format(txtTanggalAwal.DateTime, "yyyy-MM-dd 00:00:00"), Format(txtTanggalAkhir.DateTime, "yyyy-MM-dd HH:mm:ss"))
            Case 1

        End Select


    End Sub
    Sub DetilLaporan()
        If GridView1.RowCount > 0 And GridView1.GetFocusedRowCellValue("NomorTransaksi") <> "" Then


            Dim cari = EksekusiQuery("select a.KodePegawai,b.NamaPegawai from penjualan a inner join pegawai b on a.KodePegawai=b.KodePegawai where NomorTransaksi='" & GridView1.GetFocusedRowCellValue("NomorTransaksi") & "'").Select()

            With frmDetilLaporanPenjualan
                .NomorTransaksi = GridView1.GetFocusedRowCellValue("NomorTransaksi")
                .Tanggal = GridView1.GetFocusedRowCellValue("Tanggal")
                .KodePegawai = cari(0).Item("KodePegawai")
                .NamaPegawai = cari(0).Item("NamaPegawai")
                .StartPosition = FormStartPosition.CenterScreen
                .ShowDialog()

            End With
        End If
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

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        DetilLaporan()
    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        DetilLaporan()

    End Sub
End Class