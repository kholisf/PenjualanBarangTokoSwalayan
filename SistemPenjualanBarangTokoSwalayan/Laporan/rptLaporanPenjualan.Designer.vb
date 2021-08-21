<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptLaporanPenjualan
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtTanggalAkhir = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtTanggal = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtTanggalAwal = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.Toko_swalayanDataSet1 = New SistemPenjualanBarangTokoSwalayan.toko_swalayanDataSet()
        Me.View_notaPenjualanTableAdapter = New SistemPenjualanBarangTokoSwalayan.toko_swalayanDataSetTableAdapters.view_notaPenjualanTableAdapter()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.View_NotePenjualan2TableAdapter1 = New SistemPenjualanBarangTokoSwalayan.toko_swalayanDataSetTableAdapters.view_NotePenjualan2TableAdapter()
        Me.View_informasibarangTableAdapter1 = New SistemPenjualanBarangTokoSwalayan.toko_swalayanDataSetTableAdapters.view_informasibarangTableAdapter()
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toko_swalayanDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable3})
        Me.Detail.Dpi = 100.0!
        Me.Detail.HeightF = 30.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 100.0!
        Me.TopMargin.HeightF = 50.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 100.0!
        Me.BottomMargin.HeightF = 50.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.txtTanggalAkhir, Me.txtTanggal, Me.txtTanggalAwal, Me.XrLabel3, Me.XrLabel1})
        Me.ReportHeader.Dpi = 100.0!
        Me.ReportHeader.HeightF = 69.00003!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLabel2
        '
        Me.XrLabel2.Dpi = 100.0!
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 23.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(727.0!, 23.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'txtTanggalAkhir
        '
        Me.txtTanggalAkhir.Dpi = 100.0!
        Me.txtTanggalAkhir.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.txtTanggalAkhir.LocationFloat = New DevExpress.Utils.PointFloat(443.9174!, 46.00001!)
        Me.txtTanggalAkhir.Name = "txtTanggalAkhir"
        Me.txtTanggalAkhir.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTanggalAkhir.SizeF = New System.Drawing.SizeF(107.4742!, 23.0!)
        Me.txtTanggalAkhir.StylePriority.UseFont = False
        Me.txtTanggalAkhir.StylePriority.UseTextAlignment = False
        Me.txtTanggalAkhir.Text = "Tanggal Cetak :"
        Me.txtTanggalAkhir.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtTanggal
        '
        Me.txtTanggal.Dpi = 100.0!
        Me.txtTanggal.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.txtTanggal.LocationFloat = New DevExpress.Utils.PointFloat(551.3917!, 46.0!)
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTanggal.SizeF = New System.Drawing.SizeF(175.6083!, 23.0!)
        Me.txtTanggal.StylePriority.UseFont = False
        Me.txtTanggal.StylePriority.UseTextAlignment = False
        Me.txtTanggal.Text = "dd-MM-yyyy"
        Me.txtTanggal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtTanggalAwal
        '
        Me.txtTanggalAwal.Dpi = 100.0!
        Me.txtTanggalAwal.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.txtTanggalAwal.LocationFloat = New DevExpress.Utils.PointFloat(95.30662!, 46.00003!)
        Me.txtTanggalAwal.Name = "txtTanggalAwal"
        Me.txtTanggalAwal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTanggalAwal.SizeF = New System.Drawing.SizeF(208.5917!, 23.0!)
        Me.txtTanggalAwal.StylePriority.UseFont = False
        Me.txtTanggalAwal.StylePriority.UseTextAlignment = False
        Me.txtTanggalAwal.Text = "xxxx"
        Me.txtTanggalAwal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.Dpi = 100.0!
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 46.0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(95.30661!, 23.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Dari tanggal :"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.Dpi = 100.0!
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(727.0!, 23.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Laporan Penjualan"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.PageHeader.Dpi = 100.0!
        Me.PageHeader.HeightF = 30.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Dpi = 100.0!
        Me.XrTable1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100.0!)
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(727.0001!, 30.0!)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UsePadding = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell4, Me.XrTableCell11, Me.XrTableCell5, Me.XrTableCell1, Me.XrTableCell6, Me.XrTableCell14})
        Me.XrTableRow1.Dpi = 100.0!
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Dpi = 100.0!
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseTextAlignment = False
        Me.XrTableCell2.Text = "Tanggal"
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell2.Weight = 0.65547878060125275R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Dpi = 100.0!
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StylePriority.UseTextAlignment = False
        Me.XrTableCell3.Text = "Nomor Transaksi"
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell3.Weight = 0.57393496623258677R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Dpi = 100.0!
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseTextAlignment = False
        Me.XrTableCell4.Text = "Potongan"
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell4.Weight = 0.50889451045496481R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Dpi = 100.0!
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.StylePriority.UseTextAlignment = False
        Me.XrTableCell11.Text = "Jumlah Item"
        Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell11.Weight = 0.35177702981133979R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Dpi = 100.0!
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StylePriority.UseTextAlignment = False
        Me.XrTableCell5.Text = "Total Penjualan"
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell5.Weight = 0.65663109924707153R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell1.Dpi = 100.0!
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StylePriority.UseBorders = False
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        Me.XrTableCell1.Text = "Total pembayaran"
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell1.Weight = 0.68330627721958326R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Dpi = 100.0!
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.StylePriority.UseTextAlignment = False
        Me.XrTableCell6.Text = "Jumlah Uang"
        Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell6.Weight = 0.733380478833423R
        '
        'XrTableCell14
        '
        Me.XrTableCell14.Dpi = 100.0!
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.StylePriority.UseTextAlignment = False
        Me.XrTableCell14.Text = "Kode Pegawai"
        Me.XrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell14.Weight = 0.83659769610892742R
        '
        'Toko_swalayanDataSet1
        '
        Me.Toko_swalayanDataSet1.DataSetName = "toko_swalayanDataSet"
        Me.Toko_swalayanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'View_notaPenjualanTableAdapter
        '
        Me.View_notaPenjualanTableAdapter.ClearBeforeFill = True
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.ReportFooter.Dpi = 100.0!
        Me.ReportFooter.HeightF = 93.00006!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrTable2
        '
        Me.XrTable2.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrTable2.Dpi = 100.0!
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(727.0!, 24.99998!)
        Me.XrTable2.StylePriority.UseBorders = False
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell7, Me.XrTableCell8, Me.XrTableCell9})
        Me.XrTableRow2.Dpi = 100.0!
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Dpi = 100.0!
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Weight = 1.0R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Dpi = 100.0!
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Weight = 1.0R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Dpi = 100.0!
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Weight = 1.0R
        '
        'View_NotePenjualan2TableAdapter1
        '
        Me.View_NotePenjualan2TableAdapter1.ClearBeforeFill = True
        '
        'View_informasibarangTableAdapter1
        '
        Me.View_informasibarangTableAdapter1.ClearBeforeFill = True
        '
        'XrTable3
        '
        Me.XrTable3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable3.Dpi = 100.0!
        Me.XrTable3.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100.0!)
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(727.0001!, 30.0!)
        Me.XrTable3.StylePriority.UseBorders = False
        Me.XrTable3.StylePriority.UseFont = False
        Me.XrTable3.StylePriority.UsePadding = False
        Me.XrTable3.StylePriority.UseTextAlignment = False
        Me.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell10, Me.XrTableCell12, Me.XrTableCell13, Me.XrTableCell15, Me.XrTableCell16, Me.XrTableCell17, Me.XrTableCell18, Me.XrTableCell19})
        Me.XrTableRow3.Dpi = 100.0!
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 1.0R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Dpi = 100.0!
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.StylePriority.UseTextAlignment = False
        Me.XrTableCell10.Text = "Tanggal"
        Me.XrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell10.Weight = 0.65547878060125275R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.Dpi = 100.0!
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.StylePriority.UseTextAlignment = False
        Me.XrTableCell12.Text = "Nomor Transaksi"
        Me.XrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell12.Weight = 0.57393496623258677R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.Dpi = 100.0!
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.StylePriority.UseTextAlignment = False
        Me.XrTableCell13.Text = "Potongan"
        Me.XrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell13.Weight = 0.50889451045496481R
        '
        'XrTableCell15
        '
        Me.XrTableCell15.Dpi = 100.0!
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.StylePriority.UseTextAlignment = False
        Me.XrTableCell15.Text = "Jumlah Item"
        Me.XrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell15.Weight = 0.35177702981133979R
        '
        'XrTableCell16
        '
        Me.XrTableCell16.Dpi = 100.0!
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.StylePriority.UseTextAlignment = False
        Me.XrTableCell16.Text = "Total Penjualan"
        Me.XrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell16.Weight = 0.65663109924707153R
        '
        'XrTableCell17
        '
        Me.XrTableCell17.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell17.Dpi = 100.0!
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.StylePriority.UseBorders = False
        Me.XrTableCell17.StylePriority.UseTextAlignment = False
        Me.XrTableCell17.Text = "Total pembayaran"
        Me.XrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell17.Weight = 0.68330627721958326R
        '
        'XrTableCell18
        '
        Me.XrTableCell18.Dpi = 100.0!
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.StylePriority.UseTextAlignment = False
        Me.XrTableCell18.Text = "Jumlah Uang"
        Me.XrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell18.Weight = 0.733380478833423R
        '
        'XrTableCell19
        '
        Me.XrTableCell19.Dpi = 100.0!
        Me.XrTableCell19.Name = "XrTableCell19"
        Me.XrTableCell19.StylePriority.UseTextAlignment = False
        Me.XrTableCell19.Text = "Kode Pegawai"
        Me.XrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell19.Weight = 0.83659769610892742R
        '
        'rptLaporanPenjualan
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader, Me.ReportFooter})
        Me.DataAdapter = Me.View_informasibarangTableAdapter1
        Me.DataMember = "view_informasibarang"
        Me.DataSource = Me.Toko_swalayanDataSet1
        Me.Margins = New System.Drawing.Printing.Margins(50, 50, 50, 50)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Version = "16.1"
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toko_swalayanDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtTanggalAkhir As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtTanggal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Toko_swalayanDataSet1 As SistemPenjualanBarangTokoSwalayan.toko_swalayanDataSet
    Friend WithEvents View_notaPenjualanTableAdapter As SistemPenjualanBarangTokoSwalayan.toko_swalayanDataSetTableAdapters.view_notaPenjualanTableAdapter
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents View_NotePenjualan2TableAdapter1 As SistemPenjualanBarangTokoSwalayan.toko_swalayanDataSetTableAdapters.view_NotePenjualan2TableAdapter
    Friend WithEvents txtTanggalAwal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents View_informasibarangTableAdapter1 As SistemPenjualanBarangTokoSwalayan.toko_swalayanDataSetTableAdapters.view_informasibarangTableAdapter
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
End Class
