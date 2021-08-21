<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptNotePenjualan
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
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtTanggal = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.Toko_swalayanDataSet1 = New SistemPenjualanBarangTokoSwalayan.toko_swalayanDataSet()
        Me.View_notaPenjualanTableAdapter = New SistemPenjualanBarangTokoSwalayan.toko_swalayanDataSetTableAdapters.view_notaPenjualanTableAdapter()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtJumlahUang = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtKembalian = New DevExpress.XtraReports.UI.XRLabel()
        Me.View_NotePenjualan2TableAdapter1 = New SistemPenjualanBarangTokoSwalayan.toko_swalayanDataSetTableAdapters.view_NotePenjualan2TableAdapter()
        Me.txtTotalHarga = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtNomorTransaksi = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toko_swalayanDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.Detail.Dpi = 100.0!
        Me.Detail.HeightF = 30.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable2
        '
        Me.XrTable2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.Dpi = 100.0!
        Me.XrTable2.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0.0001602173!, 0.0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100.0!)
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(726.9998!, 30.0!)
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UsePadding = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell7, Me.XrTableCell8, Me.XrTableCell9, Me.XrTableCell12, Me.XrTableCell10})
        Me.XrTableRow2.Dpi = 100.0!
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "view_NotePenjualan2.NamaBarang")})
        Me.XrTableCell7.Dpi = 100.0!
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.StylePriority.UseTextAlignment = False
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell7.Weight = 1.8107104595341093R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "view_NotePenjualan2.HargaSatuan", "{0:n0}")})
        Me.XrTableCell8.Dpi = 100.0!
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.StylePriority.UseTextAlignment = False
        Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell8.Weight = 0.91140328853887942R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "view_NotePenjualan2.Jumlah", "{0:n0}")})
        Me.XrTableCell9.Dpi = 100.0!
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell9.Weight = 0.45656102891365274R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "view_NotePenjualan2.JumlahDiskon")})
        Me.XrTableCell12.Dpi = 100.0!
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.StylePriority.UseTextAlignment = False
        Me.XrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell12.Weight = 1.076982965110006R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "view_NotePenjualan2.TotalHarga", "{0:n0}")})
        Me.XrTableCell10.Dpi = 100.0!
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.StylePriority.UseTextAlignment = False
        Me.XrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell10.Weight = 1.3553520350043817R
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
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.XrLabel5, Me.txtTanggal, Me.txtNomorTransaksi, Me.XrLabel3, Me.XrLabel1})
        Me.ReportHeader.Dpi = 100.0!
        Me.ReportHeader.HeightF = 69.0!
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
        'XrLabel5
        '
        Me.XrLabel5.Dpi = 100.0!
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(469.1833!, 46.0!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(82.20834!, 23.0!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Tanggal : "
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
        Me.XrLabel1.Text = "Note Pembelian "
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
        Me.XrTable1.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Dpi = 100.0!
        Me.XrTable1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0.00003814697!, 0.0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100.0!)
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(727.0!, 30.0!)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UsePadding = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell4, Me.XrTableCell11, Me.XrTableCell5})
        Me.XrTableRow1.Dpi = 100.0!
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Dpi = 100.0!
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseTextAlignment = False
        Me.XrTableCell2.Text = "Nama Barang"
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell2.Weight = 1.61353413536115R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Dpi = 100.0!
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StylePriority.UseTextAlignment = False
        Me.XrTableCell3.Text = "Harga Satuan"
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell3.Weight = 0.8121560597135028R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Dpi = 100.0!
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseTextAlignment = False
        Me.XrTableCell4.Text = "Jumlah"
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell4.Weight = 0.40684363848177907R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Dpi = 100.0!
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.StylePriority.UseTextAlignment = False
        Me.XrTableCell11.Text = "Diskon"
        Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell11.Weight = 0.95970611721987042R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Dpi = 100.0!
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StylePriority.UseTextAlignment = False
        Me.XrTableCell5.Text = "Total Harga"
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell5.Weight = 1.2077603890426223R
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
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel4, Me.XrLabel10, Me.XrLabel6, Me.XrLabel7, Me.txtJumlahUang, Me.txtTotalHarga, Me.XrLabel9, Me.txtKembalian})
        Me.ReportFooter.Dpi = 100.0!
        Me.ReportFooter.HeightF = 93.00006!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrLabel4
        '
        Me.XrLabel4.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel4.Dpi = 100.0!
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 1.000023!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(411.8502!, 23.00001!)
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Total"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel6.Dpi = 100.0!
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 24.00003!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(551.3917!, 23.00001!)
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "JumlahUang : "
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel7.Dpi = 100.0!
        Me.XrLabel7.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 47.00003!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(551.3917!, 23.00001!)
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Kembalian : "
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtJumlahUang
        '
        Me.txtJumlahUang.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.txtJumlahUang.Dpi = 100.0!
        Me.txtJumlahUang.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.txtJumlahUang.LocationFloat = New DevExpress.Utils.PointFloat(551.3917!, 24.00002!)
        Me.txtJumlahUang.Name = "txtJumlahUang"
        Me.txtJumlahUang.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtJumlahUang.SizeF = New System.Drawing.SizeF(175.6083!, 23.00001!)
        Me.txtJumlahUang.StylePriority.UseBorders = False
        Me.txtJumlahUang.StylePriority.UseFont = False
        Me.txtJumlahUang.StylePriority.UseTextAlignment = False
        Me.txtJumlahUang.Text = "JumlahUang"
        Me.txtJumlahUang.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'txtKembalian
        '
        Me.txtKembalian.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.txtKembalian.Dpi = 100.0!
        Me.txtKembalian.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.txtKembalian.LocationFloat = New DevExpress.Utils.PointFloat(551.3917!, 47.00003!)
        Me.txtKembalian.Name = "txtKembalian"
        Me.txtKembalian.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtKembalian.SizeF = New System.Drawing.SizeF(175.6083!, 23.00001!)
        Me.txtKembalian.StylePriority.UseBorders = False
        Me.txtKembalian.StylePriority.UseFont = False
        Me.txtKembalian.StylePriority.UseTextAlignment = False
        Me.txtKembalian.Text = "Kembalian"
        Me.txtKembalian.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'View_NotePenjualan2TableAdapter1
        '
        Me.View_NotePenjualan2TableAdapter1.ClearBeforeFill = True
        '
        'txtTotalHarga
        '
        Me.txtTotalHarga.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.txtTotalHarga.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "view_NotePenjualan2.TotalHarga")})
        Me.txtTotalHarga.Dpi = 100.0!
        Me.txtTotalHarga.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.txtTotalHarga.LocationFloat = New DevExpress.Utils.PointFloat(551.3917!, 1.0!)
        Me.txtTotalHarga.Name = "txtTotalHarga"
        Me.txtTotalHarga.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTotalHarga.SizeF = New System.Drawing.SizeF(175.6083!, 23.00001!)
        Me.txtTotalHarga.StylePriority.UseBorders = False
        Me.txtTotalHarga.StylePriority.UseFont = False
        Me.txtTotalHarga.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0:n0}"
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.txtTotalHarga.Summary = XrSummary2
        Me.txtTotalHarga.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel10
        '
        Me.XrLabel10.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "view_NotePenjualan2.JumlahDiskon")})
        Me.XrLabel10.Dpi = 100.0!
        Me.XrLabel10.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(411.8502!, 0.0!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(139.5413!, 23.00001!)
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:n0}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel10.Summary = XrSummary1
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel9
        '
        Me.XrLabel9.Dpi = 100.0!
        Me.XrLabel9.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(0.00007947286!, 70.00004!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(727.0!, 23.00002!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Trimakasih Atas Kunjungan Anda"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.Dpi = 100.0!
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 46.0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(116.5833!, 23.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Nomor Transasi : "
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtNomorTransaksi
        '
        Me.txtNomorTransaksi.Dpi = 100.0!
        Me.txtNomorTransaksi.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.txtNomorTransaksi.LocationFloat = New DevExpress.Utils.PointFloat(116.5833!, 46.0!)
        Me.txtNomorTransaksi.Name = "txtNomorTransaksi"
        Me.txtNomorTransaksi.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtNomorTransaksi.SizeF = New System.Drawing.SizeF(208.5917!, 23.0!)
        Me.txtNomorTransaksi.StylePriority.UseFont = False
        Me.txtNomorTransaksi.StylePriority.UseTextAlignment = False
        Me.txtNomorTransaksi.Text = "xxxx"
        Me.txtNomorTransaksi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'rptNotePenjualan
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader, Me.ReportFooter})
        Me.DataAdapter = Me.View_NotePenjualan2TableAdapter1
        Me.DataMember = "view_NotePenjualan2"
        Me.DataSource = Me.Toko_swalayanDataSet1
        Me.Margins = New System.Drawing.Printing.Margins(50, 50, 50, 50)
        Me.PageHeight = 583
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A5Rotated
        Me.Version = "16.1"
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toko_swalayanDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
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
    Friend WithEvents txtKembalian As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtJumlahUang As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents View_NotePenjualan2TableAdapter1 As SistemPenjualanBarangTokoSwalayan.toko_swalayanDataSetTableAdapters.view_NotePenjualan2TableAdapter
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtNomorTransaksi As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtTotalHarga As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
End Class
