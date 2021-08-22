<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransaksiPenjualan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransaksiPenjualan))
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GridSplitContainer1 = New DevExpress.XtraGrid.GridSplitContainer()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.txtPotongan = New DevExpress.XtraEditors.SpinEdit()
        Me.txtInfo = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtJumlahUang = New DevExpress.XtraEditors.SpinEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtTanggal = New DevExpress.XtraEditors.DateEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNomorTransaksi = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.txtDiskon = New DevExpress.XtraEditors.SpinEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKodeBarang = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtNamaBarang = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtHargaSatuan = New DevExpress.XtraEditors.SpinEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtJumlah = New DevExpress.XtraEditors.SpinEdit()
        Me.txtKembalianuang = New System.Windows.Forms.Label()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridSplitContainer1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPotongan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJumlahUang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomorTransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtDiskon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKodeBarang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNamaBarang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHargaSatuan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJumlah.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton4.ImageIndex = 2
        Me.SimpleButton4.ImageList = Me.ImageCollection1
        Me.SimpleButton4.Location = New System.Drawing.Point(158, 455)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(139, 34)
        Me.SimpleButton4.TabIndex = 12
        Me.SimpleButton4.Text = "REFRESH [f5]"
        Me.SimpleButton4.ToolTip = "Refresh [F5]"
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageSize = New System.Drawing.Size(24, 24)
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.Images.SetKeyName(0, "icons8_Delete_Bin_512px.png")
        Me.ImageCollection1.Images.SetKeyName(1, "icons8_edit_512px_1.png")
        Me.ImageCollection1.Images.SetKeyName(2, "icons8_refresh_512px.png")
        Me.ImageCollection1.Images.SetKeyName(3, "icons8_save_512px.png")
        Me.ImageCollection1.Images.SetKeyName(4, "icons8_add_512px.png")
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.ImageIndex = 3
        Me.SimpleButton1.ImageList = Me.ImageCollection1
        Me.SimpleButton1.Location = New System.Drawing.Point(10, 455)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(139, 34)
        Me.SimpleButton1.TabIndex = 11
        Me.SimpleButton1.Text = "SIMPAN [ctrl+ent]"
        Me.SimpleButton1.ToolTip = "Simpan [CTRL+ENTER]"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit1.EditValue = Global.SistemPenjualanBarangTokoSwalayan.My.Resources.Resources.icons8_cash_counter_360px
        Me.PictureEdit1.Location = New System.Drawing.Point(12, 12)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Properties.ZoomAccelerationFactor = 1.0R
        Me.PictureEdit1.Size = New System.Drawing.Size(100, 96)
        Me.PictureEdit1.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(119, 49)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(294, 29)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "TRANSAKSI PENJUALAN"
        '
        'GridSplitContainer1
        '
        Me.GridSplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridSplitContainer1.Grid = Nothing
        Me.GridSplitContainer1.Location = New System.Drawing.Point(12, 305)
        Me.GridSplitContainer1.Name = "GridSplitContainer1"
        Me.GridSplitContainer1.Size = New System.Drawing.Size(600, 188)
        Me.GridSplitContainer1.TabIndex = 13
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(10, 320)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(766, 99)
        Me.GridControl1.TabIndex = 13
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 429)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Potongan : "
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2})
        Me.BarManager1.MaxItemId = 2
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "HAPUS [ctrl+del]"
        Me.BarButtonItem1.Hint = "Hapus [Delete]"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "TUTUP [esc]"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(788, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 499)
        Me.barDockControlBottom.Size = New System.Drawing.Size(788, 25)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 499)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(788, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 499)
        '
        'txtPotongan
        '
        Me.txtPotongan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPotongan.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPotongan.Location = New System.Drawing.Point(78, 429)
        Me.txtPotongan.Name = "txtPotongan"
        Me.txtPotongan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPotongan.Properties.DisplayFormat.FormatString = "d"
        Me.txtPotongan.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtPotongan.Properties.EditFormat.FormatString = "d"
        Me.txtPotongan.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtPotongan.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtPotongan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtPotongan.Size = New System.Drawing.Size(152, 20)
        Me.txtPotongan.TabIndex = 9
        '
        'txtInfo
        '
        Me.txtInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInfo.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfo.Location = New System.Drawing.Point(510, 461)
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.Size = New System.Drawing.Size(266, 29)
        Me.txtInfo.TabIndex = 46
        Me.txtInfo.Text = "Rp. 0 ,-"
        Me.txtInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(525, 432)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Jumlah Uang : "
        '
        'txtJumlahUang
        '
        Me.txtJumlahUang.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtJumlahUang.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtJumlahUang.Location = New System.Drawing.Point(609, 429)
        Me.txtJumlahUang.Name = "txtJumlahUang"
        Me.txtJumlahUang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtJumlahUang.Properties.DisplayFormat.FormatString = "d"
        Me.txtJumlahUang.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtJumlahUang.Properties.EditFormat.FormatString = "d"
        Me.txtJumlahUang.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtJumlahUang.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtJumlahUang.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtJumlahUang.Size = New System.Drawing.Size(167, 20)
        Me.txtJumlahUang.TabIndex = 10
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtTanggal)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.txtNomorTransaksi)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Location = New System.Drawing.Point(13, 114)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(297, 74)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Input Data Transaksi"
        '
        'txtTanggal
        '
        Me.txtTanggal.EditValue = Nothing
        Me.txtTanggal.Location = New System.Drawing.Point(108, 49)
        Me.txtTanggal.MenuManager = Me.BarManager1
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTanggal.Size = New System.Drawing.Size(175, 20)
        Me.txtTanggal.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tanggal : "
        '
        'txtNomorTransaksi
        '
        Me.txtNomorTransaksi.Location = New System.Drawing.Point(108, 23)
        Me.txtNomorTransaksi.Name = "txtNomorTransaksi"
        Me.txtNomorTransaksi.Size = New System.Drawing.Size(176, 20)
        Me.txtNomorTransaksi.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nomor Transaksi : "
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.txtDiskon)
        Me.GroupControl2.Controls.Add(Me.Label7)
        Me.GroupControl2.Controls.Add(Me.Label3)
        Me.GroupControl2.Controls.Add(Me.txtKodeBarang)
        Me.GroupControl2.Controls.Add(Me.txtNamaBarang)
        Me.GroupControl2.Controls.Add(Me.SimpleButton2)
        Me.GroupControl2.Controls.Add(Me.txtHargaSatuan)
        Me.GroupControl2.Controls.Add(Me.Label4)
        Me.GroupControl2.Controls.Add(Me.Label5)
        Me.GroupControl2.Controls.Add(Me.Label6)
        Me.GroupControl2.Controls.Add(Me.txtJumlah)
        Me.GroupControl2.Location = New System.Drawing.Point(13, 195)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(545, 119)
        Me.GroupControl2.TabIndex = 2
        Me.GroupControl2.Text = "Tambah Barang"
        '
        'txtDiskon
        '
        Me.txtDiskon.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDiskon.Location = New System.Drawing.Point(359, 52)
        Me.txtDiskon.Name = "txtDiskon"
        Me.txtDiskon.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDiskon.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtDiskon.Properties.Mask.EditMask = "n0"
        Me.txtDiskon.Size = New System.Drawing.Size(153, 20)
        Me.txtDiskon.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(290, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Diskon (%) :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Kode Barang [f1] : "
        '
        'txtKodeBarang
        '
        Me.txtKodeBarang.Location = New System.Drawing.Point(109, 26)
        Me.txtKodeBarang.Name = "txtKodeBarang"
        Me.txtKodeBarang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtKodeBarang.Size = New System.Drawing.Size(175, 20)
        Me.txtKodeBarang.TabIndex = 3
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.Location = New System.Drawing.Point(109, 52)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNamaBarang.Size = New System.Drawing.Size(175, 20)
        Me.txtNamaBarang.TabIndex = 4
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageIndex = 4
        Me.SimpleButton2.ImageList = Me.ImageCollection1
        Me.SimpleButton2.Location = New System.Drawing.Point(359, 78)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(139, 34)
        Me.SimpleButton2.TabIndex = 8
        Me.SimpleButton2.Text = "TAMBAH ITEM [ent]"
        Me.SimpleButton2.ToolTip = "Tambah Item [ENTER]"
        '
        'txtHargaSatuan
        '
        Me.txtHargaSatuan.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtHargaSatuan.Location = New System.Drawing.Point(109, 78)
        Me.txtHargaSatuan.Name = "txtHargaSatuan"
        Me.txtHargaSatuan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtHargaSatuan.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtHargaSatuan.Properties.Mask.EditMask = "n0"
        Me.txtHargaSatuan.Size = New System.Drawing.Size(175, 20)
        Me.txtHargaSatuan.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Nama Barang :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Harga Satuan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(290, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Jumlah Beli : "
        '
        'txtJumlah
        '
        Me.txtJumlah.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtJumlah.Location = New System.Drawing.Point(359, 26)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtJumlah.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtJumlah.Properties.Mask.EditMask = "n0"
        Me.txtJumlah.Size = New System.Drawing.Size(153, 20)
        Me.txtJumlah.TabIndex = 6
        '
        'txtKembalianuang
        '
        Me.txtKembalianuang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKembalianuang.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKembalianuang.Location = New System.Drawing.Point(564, 285)
        Me.txtKembalianuang.Name = "txtKembalianuang"
        Me.txtKembalianuang.Size = New System.Drawing.Size(214, 29)
        Me.txtKembalianuang.TabIndex = 57
        Me.txtKembalianuang.Text = "Kembalian = Rp. 0 ,-"
        Me.txtKembalianuang.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmTransaksiPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 524)
        Me.Controls.Add(Me.txtKembalianuang)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtJumlahUang)
        Me.Controls.Add(Me.txtInfo)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.txtPotongan)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmTransaksiPenjualan"
        Me.Text = "Form Transaksi Penjualan"
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridSplitContainer1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPotongan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJumlahUang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomorTransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtDiskon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKodeBarang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNamaBarang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHargaSatuan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJumlah.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridSplitContainer1 As DevExpress.XtraGrid.GridSplitContainer
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents txtPotongan As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtInfo As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtJumlahUang As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtDiskon As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtKodeBarang As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtNamaBarang As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtHargaSatuan As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtJumlah As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNomorTransaksi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtTanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtKembalianuang As System.Windows.Forms.Label
End Class
