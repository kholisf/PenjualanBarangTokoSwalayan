<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHakAkses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHakAkses))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.csSetting = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckedListBoxControl3 = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.csLaporan = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckedListBoxControl2 = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.csDataUtama = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckedListBoxControl1 = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.txtNamaAkses = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.csSetting.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckedListBoxControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.csLaporan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckedListBoxControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.csDataUtama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckedListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNamaAkses.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(119, 49)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(184, 29)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Data Hak Akses"
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageSize = New System.Drawing.Size(25, 25)
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.Images.SetKeyName(0, "icons8_Delete_Bin_512px.png")
        Me.ImageCollection1.Images.SetKeyName(1, "icons8_edit_512px_1.png")
        Me.ImageCollection1.Images.SetKeyName(2, "icons8_refresh_512px.png")
        Me.ImageCollection1.Images.SetKeyName(3, "icons8_save_512px.png")
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "TUTUP [esc]"
        Me.BarButtonItem2.Hint = "CTRL + ESC"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(729, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 580)
        Me.barDockControlBottom.Size = New System.Drawing.Size(729, 25)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 580)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(729, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 580)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "CETAK"
        Me.BarButtonItem1.Hint = "CTRL + P"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit1.EditValue = Global.SistemPenjualanBarangTokoSwalayan.My.Resources.Resources.icons8_access_512px_1
        Me.PictureEdit1.Location = New System.Drawing.Point(12, 12)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Properties.ZoomAccelerationFactor = 1.0R
        Me.PictureEdit1.Size = New System.Drawing.Size(100, 96)
        Me.PictureEdit1.TabIndex = 3
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(12, 393)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(705, 181)
        Me.GridControl1.TabIndex = 14
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.SimpleButton4)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.SimpleButton2)
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Controls.Add(Me.GroupBox4)
        Me.GroupControl1.Controls.Add(Me.GroupBox3)
        Me.GroupControl1.Controls.Add(Me.GroupBox2)
        Me.GroupControl1.Controls.Add(Me.txtNamaAkses)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Location = New System.Drawing.Point(13, 115)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(704, 272)
        Me.GroupControl1.TabIndex = 19
        Me.GroupControl1.Text = "Input Hak Akses"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.ImageIndex = 2
        Me.SimpleButton4.ImageList = Me.ImageCollection1
        Me.SimpleButton4.Location = New System.Drawing.Point(298, 232)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(139, 34)
        Me.SimpleButton4.TabIndex = 34
        Me.SimpleButton4.Text = "REFRESH [f5]"
        Me.SimpleButton4.ToolTip = "Refresh [F5]"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.ImageIndex = 0
        Me.SimpleButton3.ImageList = Me.ImageCollection1
        Me.SimpleButton3.Location = New System.Drawing.Point(443, 232)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(139, 34)
        Me.SimpleButton3.TabIndex = 33
        Me.SimpleButton3.Text = "HAPUS [ctrl+del]"
        Me.SimpleButton3.ToolTip = "Hapus [CTRL+Delete]"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageIndex = 1
        Me.SimpleButton2.ImageList = Me.ImageCollection1
        Me.SimpleButton2.Location = New System.Drawing.Point(153, 232)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(139, 34)
        Me.SimpleButton2.TabIndex = 32
        Me.SimpleButton2.Text = "UBAH [f2]"
        Me.SimpleButton2.ToolTip = "Ubah [F2]"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageIndex = 3
        Me.SimpleButton1.ImageList = Me.ImageCollection1
        Me.SimpleButton1.Location = New System.Drawing.Point(8, 232)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(139, 34)
        Me.SimpleButton1.TabIndex = 31
        Me.SimpleButton1.Text = "SIMPAN [ctrl+ent]"
        Me.SimpleButton1.ToolTip = "Simpan [CTRL+ENTER]"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.csSetting)
        Me.GroupBox4.Controls.Add(Me.CheckedListBoxControl3)
        Me.GroupBox4.Location = New System.Drawing.Point(478, 51)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(220, 175)
        Me.GroupBox4.TabIndex = 30
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Pengaturan"
        '
        'csSetting
        '
        Me.csSetting.Location = New System.Drawing.Point(6, 150)
        Me.csSetting.MenuManager = Me.BarManager1
        Me.csSetting.Name = "csSetting"
        Me.csSetting.Properties.Caption = "Centang Semua"
        Me.csSetting.Size = New System.Drawing.Size(112, 19)
        Me.csSetting.TabIndex = 18
        '
        'CheckedListBoxControl3
        '
        Me.CheckedListBoxControl3.CheckOnClick = True
        Me.CheckedListBoxControl3.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckedListBoxControl3.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem(Nothing, "Konfigurasi Server"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(Nothing, "Data Pegawai"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(Nothing, "Hak Akses")})
        Me.CheckedListBoxControl3.Location = New System.Drawing.Point(6, 19)
        Me.CheckedListBoxControl3.Name = "CheckedListBoxControl3"
        Me.CheckedListBoxControl3.Size = New System.Drawing.Size(208, 127)
        Me.CheckedListBoxControl3.TabIndex = 17
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.csLaporan)
        Me.GroupBox3.Controls.Add(Me.CheckedListBoxControl2)
        Me.GroupBox3.Location = New System.Drawing.Point(252, 51)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(220, 175)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Laporan"
        '
        'csLaporan
        '
        Me.csLaporan.Location = New System.Drawing.Point(6, 150)
        Me.csLaporan.MenuManager = Me.BarManager1
        Me.csLaporan.Name = "csLaporan"
        Me.csLaporan.Properties.Caption = "Centang Semua"
        Me.csLaporan.Size = New System.Drawing.Size(112, 19)
        Me.csLaporan.TabIndex = 17
        '
        'CheckedListBoxControl2
        '
        Me.CheckedListBoxControl2.CheckOnClick = True
        Me.CheckedListBoxControl2.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckedListBoxControl2.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem(Nothing, "Laporan Penjualan"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(Nothing, "Laporan Pembelian"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(Nothing, "Laporan Kas"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(Nothing, "Laporan Data Barang")})
        Me.CheckedListBoxControl2.Location = New System.Drawing.Point(6, 19)
        Me.CheckedListBoxControl2.Name = "CheckedListBoxControl2"
        Me.CheckedListBoxControl2.Size = New System.Drawing.Size(208, 127)
        Me.CheckedListBoxControl2.TabIndex = 16
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.csDataUtama)
        Me.GroupBox2.Controls.Add(Me.CheckedListBoxControl1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 51)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(238, 175)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Utama"
        '
        'csDataUtama
        '
        Me.csDataUtama.Location = New System.Drawing.Point(7, 150)
        Me.csDataUtama.MenuManager = Me.BarManager1
        Me.csDataUtama.Name = "csDataUtama"
        Me.csDataUtama.Properties.Caption = "Centang Semua"
        Me.csDataUtama.Size = New System.Drawing.Size(112, 19)
        Me.csDataUtama.TabIndex = 16
        '
        'CheckedListBoxControl1
        '
        Me.CheckedListBoxControl1.CheckOnClick = True
        Me.CheckedListBoxControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckedListBoxControl1.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem(Nothing, "Data Barang"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(Nothing, "Data Pemasok"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(Nothing, "Transaksi Penjualan"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(Nothing, "Transaksi Pembelian"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(Nothing, "Transaksi kas")})
        Me.CheckedListBoxControl1.Location = New System.Drawing.Point(6, 19)
        Me.CheckedListBoxControl1.Name = "CheckedListBoxControl1"
        Me.CheckedListBoxControl1.Size = New System.Drawing.Size(226, 127)
        Me.CheckedListBoxControl1.TabIndex = 15
        Me.CheckedListBoxControl1.Tag = ""
        '
        'txtNamaAkses
        '
        Me.txtNamaAkses.Location = New System.Drawing.Point(97, 25)
        Me.txtNamaAkses.Name = "txtNamaAkses"
        Me.txtNamaAkses.Size = New System.Drawing.Size(375, 20)
        Me.txtNamaAkses.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Nama Akses :"
        '
        'frmHakAkses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 605)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmHakAkses"
        Me.Text = "frmHakAkses"
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.csSetting.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckedListBoxControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.csLaporan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckedListBoxControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.csDataUtama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckedListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNamaAkses.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents csSetting As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckedListBoxControl3 As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents csLaporan As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckedListBoxControl2 As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents csDataUtama As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckedListBoxControl1 As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents txtNamaAkses As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
