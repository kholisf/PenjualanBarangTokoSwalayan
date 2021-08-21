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
End Module
