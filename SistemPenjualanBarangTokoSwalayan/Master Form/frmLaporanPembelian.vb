Public Class frmLaporanPembelian

    Dim Tampung As New DataTable
    Sub TampilLaporan()
        GridControl1.DataSource = Nothing
        GridView1.Columns.Clear()

        Select Case txtKategori.SelectedIndex
            Case 0

                Tampung = EksekusiQuery("select a.Tanggal,a.NomorTransaksi,a.KodePemasok,b.NamaPemasok,count(c.KodeBarang) as JumlahItem,a.Potongan,sum((c.HargaSatuan*c.Jumlah) -(c.HargaSatuan*c.Jumlah)*(c.PersenDiskon/100)) as TotalPembelian,(sum((c.HargaSatuan*c.Jumlah)-(c.HargaSatuan*c.Jumlah)*(c.PersenDiskon/100))-a.Potongan) as TotalPembayaran,b.Keterangan,a.KodePegawai from (pembelian a inner join pemasok b on a.KodePemasok=b.KodePemasok inner join pembelian_detil c on a.NomorTransaksi=c.NomorTransaksi) where a.Tanggal>='" & Format(txtTanggalAwal.DateTime, "yyyy-MM-dd 00:00:00") & "' and a.Tanggal<='" & Format(txtTanggalAkhir.DateTime, "yyyy-MM-dd HH:mm:ss") & "' group by a.NomorTransaksi")
                GridControl1.DataSource = Tampung
                GridviewEditTampilan(GridView1, "KodePemasok,KodePegawai", "TotalPembelian,TotalPembayaran", "TotalPembelian,TotalPembayaran")

            Case 1

                If txtKodePemasok.Text = "" Or txtNamaPemasok.Text = "" Then
                    MessageBox.Show("Pilih dahulu pemasok!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                Tampung = EksekusiQuery("select a.Tanggal,a.NomorTransaksi,a.KodePemasok,b.NamaPemasok,count(c.KodeBarang) as JumlahItem,a.Potongan,sum((c.HargaSatuan*c.Jumlah) -(c.HargaSatuan*c.Jumlah)*(c.PersenDiskon/100)) as TotalPembelian,(sum((c.HargaSatuan*c.Jumlah)-(c.HargaSatuan*c.Jumlah)*(c.PersenDiskon/100))-a.Potongan) as TotalPembayaran,b.Keterangan,a.KodePegawai from (pembelian a inner join pemasok b on a.KodePemasok=b.KodePemasok inner join pembelian_detil c on a.NomorTransaksi=c.NomorTransaksi) where a.KodePemasok='" & txtKodePemasok.Text & "' group by a.NomorTransaksi;")
                GridControl1.DataSource = Tampung
                GridviewEditTampilan(GridView1, "KodePemasok,KodePegawai", "Potonngan,TotalPembelian,TotalPembayaran", "TotalPembelian,TotalPembayaran")
        End Select


    End Sub

    Private Sub frmLaporanPembelian_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                ListPemasok()
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


    Private Sub frmLaporanPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        txtKategori.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        txtTanggalAkhir.DateTime = Now
        txtTanggalAwal.DateTime = Now
        txtKategori.SelectedIndex = 0
        txtKodePemasok.ReadOnly = True
        txtNamaPemasok.ReadOnly = True
        TampilLaporan()

    End Sub

    Private Sub txtKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtKategori.SelectedIndexChanged
        Select Case txtKategori.SelectedIndex
            Case 0
                txtTanggalAkhir.Enabled = True
                txtTanggalAwal.Enabled = True
                txtNamaPemasok.Enabled = False
                txtKodePemasok.Enabled = False
            Case 1

                txtTanggalAkhir.Enabled = False
                txtTanggalAwal.Enabled = False
                txtKodePemasok.Enabled = True
                txtNamaPemasok.Enabled = True

        End Select

    End Sub





    Sub ListPemasok()
        With frmListPemasok
            .NilaiKiriman = 2
            .ShowDialog()

        End With
    End Sub

    Private Sub txtKodePemasok_Click(sender As Object, e As EventArgs)
        ListPemasok()

    End Sub
    Sub cetak()
        GridControl1.ShowRibbonPrintPreview()

    End Sub
    Sub DetilLaporan()
        If GridView1.RowCount > 0 And GridView1.GetFocusedRowCellValue("NomorTransaksi") <> "" Then

            Dim cari = EksekusiQuery("select a.KodePegawai,b.NamaPegawai from pembelian a inner join pegawai b on a.KodePegawai=b.KodePegawai where NomorTransaksi='" & GridView1.GetFocusedRowCellValue("NomorTransaksi") & "'").Select()

            With frmDetilLaporanPembelian
                .NomorTransaksi = GridView1.GetFocusedRowCellValue("NomorTransaksi")
                .Tanggal = GridView1.GetFocusedRowCellValue("Tanggal")
                .KodePemasok = GridView1.GetFocusedRowCellValue("KodePemasok")
                .NamaPemasok = GridView1.GetFocusedRowCellValue("NamaPemasok")

                If cari.Length > 0 Then
                    .KodePegawai = cari(0).Item("KodePegawai")
                    .NamaPegawai = cari(0).Item("NamaPegawai")
                End If
                
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

    Private Sub txtKodePemasok_Click1(sender As Object, e As EventArgs) Handles txtKodePemasok.Click
        ListPemasok()

    End Sub
End Class