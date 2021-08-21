Imports DevExpress.XtraReports.UI
Module ReportModule
    Sub ReportNotaPenjualan(ByVal NomorTransaksi As String, ByVal Tanggal As Date, ByVal JumlahUang As Double, ByVal Kembalian As Double, ByVal StatusCetak As Boolean)
        Dim rpt As New rptNotePenjualan
        'rpt.FilterString = "[NomorTransaksi]='" & NomorTransaksi & "'"
        rpt.FilterString = "[NomorTransaksi]='" & NomorTransaksi & "'"
        rpt.txtNomorTransaksi.Text = " " & NomorTransaksi
        rpt.txtTanggal.Text = " " & Tanggal
        rpt.txtKembalian.Text = " " & Format(Kembalian, "n0")
        rpt.txtJumlahUang.Text = " " & Format(JumlahUang, "n0")
        Using PrintTool As New ReportPrintTool(rpt)
            If StatusCetak = True Then
                PrintTool.ShowRibbonPreviewDialog()
            Else
                PrintTool.Print()
            End If
        End Using

    End Sub
    Sub ReportLaporanInformasiBarang(ByVal kondisisql As String, ByVal Kondisilaporan As String, ByVal kondisiurut As String)
        EksekusiQuery("create or replace view view_informasibarang as select * from barang where " & kondisisql & " and KodeBarang<>'0000000000' order by " & kondisiurut & " asc")
        Dim rpt As New rptLaporanDataBarang
        rpt.txtKondisiBarang.Text = " " & Kondisilaporan
        rpt.txtTanggal.Text = Format(Now, "dddd, dd MMMM yyyy")
        Using PrintTool As New ReportPrintTool(rpt)
            PrintTool.ShowRibbonPreviewDialog()
        End Using

    End Sub
    Sub ReportLaporanPenjualan(ByVal tanggalawal As Date, ByVal tanggalakhir As Date)
        EksekusiQuery("create or replace view view_laporantransaksipenjualan as select a.NomorTransaksi,a.Tanggal,a.Potongan,count(b.KodeBarang) as JumlahItem,sum((b.HargaSatuan*b.Jumlah) -(b.HargaSatuan*b.Jumlah)*(b.PersenDiskon/100)) as TotalPenjualan,(sum((b.HargaSatuan*b.Jumlah)-(b.HargaSatuan*b.Jumlah)*(b.PersenDiskon/100))-a.Potongan) as TotalPembayaran,a.JumlahUang,a.KodePegawai from (penjualan a inner join penjualan_detil b on a.NomorTransaksi=b.NomorTransaksi) where a.Tanggal>='" & Format(tanggalawal, "yyyy-MM-dd 00:00:00") & "' and a.Tanggal<='" & Format(tanggalakhir, "yyyy-MM-dd HH:mm:ss") & "' group by a.NomorTransaksi")
        Dim rpt As New rptLaporanPenjualan
        rpt.txtTanggalAwal.Text = " " & Format(tanggalawal, "dddd, dd MMMM yyyy")
        rpt.txtTanggalAkhir.Text = Format(Now, "dddd, dd MMMM yyyy")
        Using PrintTool As New ReportPrintTool(rpt)
            PrintTool.ShowRibbonPreviewDialog()
        End Using

    End Sub

End Module
