Public Class frmMenuUtama 
    Private Sub frmMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hakakses()
        BarButtonItem6.Caption = My.Settings.sNamaPegawai & " / " & My.Settings.sHakAkses
    End Sub
    Sub hakakses()
        If My.Settings.sKodePegawai <> "PGW0000000" Then
            Dim cari = EksekusiQuery("select * from hak_akses where NamaAkses='" & My.Settings.sHakAkses & "'").Select()
            With cari(0)
                '===========================================MENU UTAMA===========================================
                If .Item("Barang") = 0 And .Item("Pemasok") = 0 And .Item("TransaksiPenjualan") = 0 And .Item("TransaksiPembelian") = 0 And .Item("TransaksiKas") = 0 Then
                    RibbonPage1.Visible = False
                Else
                    RibbonPage1.Visible = True
                    If .Item("Barang") = 0 And .Item("Pemasok") = 0 Then
                        RibbonPageGroup1.Visible = False
                    Else
                        RibbonPageGroup1.Visible = True
                        barbuttonTampilOrTidak("Barang,Pemasok", btnBarang, btnPemasok)
                    End If

                    If .Item("TransaksiPenjualan") = 0 And .Item("TransaksiPembelian") = 0 And .Item("TransaksiKas") = 0 Then
                        RibbonPageGroup3.Visible = False
                    Else
                        RibbonPageGroup3.Visible = True
                        barbuttonTampilOrTidak("TransaksiPenjualan,TransaksiPembelian,TransaksiKas", btnTransaksiPenjualan, btnTransaksiPembelian, btnTransaksiKas)
                    End If
                End If
                '===========================================LAPORAN===========================================
                If .Item("LaporanPembelian") = 0 And .Item("LaporanPenjualan") = 0 And .Item("LaporanKas") = 0 And .Item("LaporanInfoDataBarang") = 0 Then
                    RibbonPage3.Visible = False
                    RibbonPageGroup4.Visible = False
                Else
                    RibbonPage3.Visible = True
                    barbuttonTampilOrTidak("LaporanPembelian,LaporanPenjualan,LaporanKas,LaporanInfoDataBarang", btnLaporanPembelian, btnLaporanPenjualan, btnLaporanKas, btnLaporanDataBarang)
                End If
                '===========================================PENGATURAN===========================================  
                'Ribbon Setting
                If .Item("KonfigurasiServer") = 0 And .Item("Pegawai") = 0 And .Item("HakAkses") = 0 Then
                    RibbonPage2.Visible = False
                    RibbonPageGroup2.Visible = False
                Else
                    RibbonPage2.Visible = True
                    RibbonPageGroup2.Visible = True

                    barbuttonTampilOrTidak("KonfigurasiServer,Pegawai,HakAkses", btnKonfigurasiServer, btnPegawai, btnHakAkses)
                End If
            End With
        End If
    End Sub
    Private Sub btnBarang_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBarang.ItemClick
        With frmBarang
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub
    Private Sub btnKonfigurasiServer_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnKonfigurasiServer.ItemClick
        frmSetupKonfigurasiServer.ShowDialog()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BarButtonItem5.Caption = "Jam :" & Format(Now, "HH:mm:ss") & " Hari : " & Format(Now, "dddd") & " Tanggal : " & Format(Now, "dd MMMM yyyy")
    End Sub
    Private Sub btnPegawai_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPegawai.ItemClick
        With frmPegawai
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub
    Private Sub btnHakAkses_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnHakAkses.ItemClick
        With frmHakAkses
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub
    Private Sub BarButtonItem7_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        If MessageBox.Show("Yakin Ingin Logout?", "validasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.Dispose()
            frmLogin.ShowDialog()
            frmLogin.txtPassword.Text = ""
            Me.Close()
        End If
    End Sub
    Private Sub BarButtonItem8_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        If MessageBox.Show("Yakin Ingin Menutup Aplikasi?", "validasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
    Private Sub btnPemasok_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPemasok.ItemClick
        With frmPemasok
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub
    Private Sub btnTransaksiPenjualan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTransaksiPenjualan.ItemClick
        With frmTransaksiPenjualan
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub
    Private Sub btnTransaksiPembelian_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTransaksiPembelian.ItemClick
        With frmTransaksiPembelian
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub
    Private Sub btnTransaksiKas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTransaksiKas.ItemClick
        With frmTransaksiKas
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLaporanPembelian.ItemClick
        With frmLaporanPembelian
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub
    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLaporanPenjualan.ItemClick
        With frmLaporanPenjualan
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub
    Private Sub BarButtonItem9_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLaporanDataBarang.ItemClick
        With frmLaporanInformasiBarang
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub
    Private Sub btnLaporanKas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLaporanKas.ItemClick
        With frmLaporanKas
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub
    Private Sub BarButtonItem1_ItemClick1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        With frmGantiPassword
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
        End With
    End Sub
End Class