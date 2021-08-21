<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuUtama
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.ApplicationMenu1 = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnBarang = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPemasok1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnKonfigurasiServer = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPegawai = New DevExpress.XtraBars.BarButtonItem()
        Me.btnHakAkses = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPemasok = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTransaksiPenjualan = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTransaksiPembelian = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTransaksiKas = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLaporanPembelian = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLaporanPenjualan = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLaporanKas = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLaporanDataBarang = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicationMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ApplicationButtonDropDownControl = Me.ApplicationMenu1
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnBarang, Me.btnPemasok1, Me.BarButtonItem3, Me.btnKonfigurasiServer, Me.BarButtonItem5, Me.BarButtonItem6, Me.btnPegawai, Me.btnHakAkses, Me.BarButtonItem7, Me.BarButtonItem8, Me.btnPemasok, Me.btnTransaksiPenjualan, Me.btnTransaksiPembelian, Me.btnTransaksiKas, Me.btnLaporanPembelian, Me.btnLaporanPenjualan, Me.btnLaporanKas, Me.btnLaporanDataBarang, Me.BarButtonItem1})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 20
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.RibbonPage3, Me.RibbonPage2})
        Me.RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.RibbonControl.Size = New System.Drawing.Size(442, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'ApplicationMenu1
        '
        Me.ApplicationMenu1.ItemLinks.Add(Me.BarButtonItem7)
        Me.ApplicationMenu1.ItemLinks.Add(Me.BarButtonItem1)
        Me.ApplicationMenu1.ItemLinks.Add(Me.BarButtonItem8)
        Me.ApplicationMenu1.Name = "ApplicationMenu1"
        Me.ApplicationMenu1.Ribbon = Me.RibbonControl
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "LogOut"
        Me.BarButtonItem7.Glyph = Global.SistemPenjualanBarangTokoSwalayan.My.Resources.Resources.icons8_logout_rounded_down_512px
        Me.BarButtonItem7.Id = 9
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Exit"
        Me.BarButtonItem8.Glyph = Global.SistemPenjualanBarangTokoSwalayan.My.Resources.Resources.icons8_shutdown_360px
        Me.BarButtonItem8.Id = 10
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'btnBarang
        '
        Me.btnBarang.Caption = "Data Barang"
        Me.btnBarang.Id = 1
        Me.btnBarang.LargeGlyph = Global.SistemPenjualanBarangTokoSwalayan.My.Resources.Resources.icons8_Ingredients_512px_2
        Me.btnBarang.Name = "btnBarang"
        '
        'btnPemasok1
        '
        Me.btnPemasok1.Caption = "Data Pemasok"
        Me.btnPemasok1.Id = 2
        Me.btnPemasok1.LargeGlyph = Global.SistemPenjualanBarangTokoSwalayan.My.Resources.Resources.icons8_supplier_512px
        Me.btnPemasok1.Name = "btnPemasok1"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "BarButtonItem3"
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.LargeGlyph = Global.SistemPenjualanBarangTokoSwalayan.My.Resources.Resources.icons8_manager_480px_1
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'btnKonfigurasiServer
        '
        Me.btnKonfigurasiServer.Caption = "Konfigurasi Server"
        Me.btnKonfigurasiServer.Id = 4
        Me.btnKonfigurasiServer.LargeGlyph = Global.SistemPenjualanBarangTokoSwalayan.My.Resources.Resources.icons8_database_administrator_360px
        Me.btnKonfigurasiServer.Name = "btnKonfigurasiServer"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "-"
        Me.BarButtonItem5.Glyph = Global.SistemPenjualanBarangTokoSwalayan.My.Resources.Resources.icons8_timer_512px
        Me.BarButtonItem5.Id = 5
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "-"
        Me.BarButtonItem6.Glyph = Global.SistemPenjualanBarangTokoSwalayan.My.Resources.Resources.icons8_user_512px
        Me.BarButtonItem6.Id = 6
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'btnPegawai
        '
        Me.btnPegawai.Caption = "Data Pegawai"
        Me.btnPegawai.Id = 7
        Me.btnPegawai.LargeGlyph = Global.SistemPenjualanBarangTokoSwalayan.My.Resources.Resources.icons8_management_400px_1
        Me.btnPegawai.Name = "btnPegawai"
        '
        'btnHakAkses
        '
        Me.btnHakAkses.Caption = "HakAkses"
        Me.btnHakAkses.Id = 8
        Me.btnHakAkses.LargeGlyph = Global.SistemPenjualanBarangTokoSwalayan.My.Resources.Resources.icons8_access_512px_1
        Me.btnHakAkses.Name = "btnHakAkses"
        '
        'btnPemasok
        '
        Me.btnPemasok.Caption = "Data Pemasok"
        Me.btnPemasok.Id = 11
        Me.btnPemasok.LargeGlyph = Global.SistemPenjualanBarangTokoSwalayan.My.Resources.Resources.icons8_supplier_512px
        Me.btnPemasok.Name = "btnPemasok"
        '
        'btnTransaksiPenjualan
        '
        Me.btnTransaksiPenjualan.Caption = "Transaksi Penjualan"
        Me.btnTransaksiPenjualan.Id = 12
        Me.btnTransaksiPenjualan.LargeGlyph = Global.SistemPenjualanBarangTokoSwalayan.My.Resources.Resources.icons8_cash_counter_360px
        Me.btnTransaksiPenjualan.Name = "btnTransaksiPenjualan"
        '
        'btnTransaksiPembelian
        '
        Me.btnTransaksiPembelian.Caption = "Transaksi Pembelian"
        Me.btnTransaksiPembelian.Id = 13
        Me.btnTransaksiPembelian.LargeGlyph = Global.SistemPenjualanBarangTokoSwalayan.My.Resources.Resources.icons8_buying_480px
        Me.btnTransaksiPembelian.Name = "btnTransaksiPembelian"
        '
        'btnTransaksiKas
        '
        Me.btnTransaksiKas.Caption = "Transaksi Kas"
        Me.btnTransaksiKas.Id = 14
        Me.btnTransaksiKas.LargeGlyph = Global.SistemPenjualanBarangTokoSwalayan.My.Resources.Resources.icons8_General_Ledger_500px
        Me.btnTransaksiKas.Name = "btnTransaksiKas"
        '
        'btnLaporanPembelian
        '
        Me.btnLaporanPembelian.Caption = "Laporan Pembelian"
        Me.btnLaporanPembelian.Id = 15
        Me.btnLaporanPembelian.LargeGlyph = Global.SistemPenjualanBarangTokoSwalayan.My.Resources.Resources.icons8_buying_480px
        Me.btnLaporanPembelian.Name = "btnLaporanPembelian"
        '
        'btnLaporanPenjualan
        '
        Me.btnLaporanPenjualan.Caption = "Laporan Penjualan"
        Me.btnLaporanPenjualan.Id = 16
        Me.btnLaporanPenjualan.LargeGlyph = Global.SistemPenjualanBarangTokoSwalayan.My.Resources.Resources.icons8_cash_counter_360px
        Me.btnLaporanPenjualan.Name = "btnLaporanPenjualan"
        '
        'btnLaporanKas
        '
        Me.btnLaporanKas.Caption = "Laporan Kas"
        Me.btnLaporanKas.Id = 17
        Me.btnLaporanKas.LargeGlyph = Global.SistemPenjualanBarangTokoSwalayan.My.Resources.Resources.icons8_General_Ledger_500px
        Me.btnLaporanKas.Name = "btnLaporanKas"
        '
        'btnLaporanDataBarang
        '
        Me.btnLaporanDataBarang.Caption = "Laporan Data Barang"
        Me.btnLaporanDataBarang.Id = 18
        Me.btnLaporanDataBarang.LargeGlyph = Global.SistemPenjualanBarangTokoSwalayan.My.Resources.Resources.icons8_Ingredients_512px_2
        Me.btnLaporanDataBarang.Name = "btnLaporanDataBarang"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup3})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "DATA UTAMA"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnBarang)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnPemasok)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Form Input Data"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnTransaksiPenjualan)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnTransaksiPembelian)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnTransaksiKas)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Transaksi"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup4})
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Text = "LAPORAN"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnLaporanPenjualan)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnLaporanPembelian)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnLaporanKas)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnLaporanDataBarang)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "Laporan"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "PENGATURAN"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnKonfigurasiServer)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnPegawai)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnHakAkses)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "UMUM"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.ItemLinks.Add(Me.BarButtonItem6)
        Me.RibbonStatusBar.ItemLinks.Add(Me.BarButtonItem5)
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 418)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(442, 31)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Ganti Password"
        Me.BarButtonItem1.Glyph = Global.SistemPenjualanBarangTokoSwalayan.My.Resources.Resources.icons8_Password_1_512px_1
        Me.BarButtonItem1.Id = 19
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'frmMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 449)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.IsMdiContainer = True
        Me.Name = "frmMenuUtama"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "frmMenuUtama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicationMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnBarang As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPemasok1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnKonfigurasiServer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnPegawai As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents btnHakAkses As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ApplicationMenu1 As DevExpress.XtraBars.Ribbon.ApplicationMenu
    Friend WithEvents btnPemasok As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTransaksiPenjualan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnTransaksiPembelian As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTransaksiKas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLaporanPembelian As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnLaporanPenjualan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLaporanKas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLaporanDataBarang As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem


End Class
