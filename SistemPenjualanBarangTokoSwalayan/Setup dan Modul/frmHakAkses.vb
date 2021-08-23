Public Class frmHakAkses
    Private Sub frmHakAkses_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case e.Control And Keys.Enter
                SimpanAkses()
            Case Keys.F2
                UbahData()
            Case Keys.Escape
                Me.Close()
            Case Keys.F5
                RefreshData()
            Case e.Control And Keys.Delete
                HapusData()
        End Select
    End Sub
    Private Sub frmHakAkses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        RefreshData()
    End Sub
    Dim TransaksiPenjualan, TransaksiPembelian, TransaksiKas, Barang, Pemasok, Pegawai, KonfigurasiServer, HakAkses, LaporanPenjualan, LaporanPembelian, LaporanKas, LaporanDataBarang As String
    Sub cekakses()
        'cek box untuk FormMaster'
        With CheckedListBoxControl1
            If .Items(0).CheckState = CheckState.Checked Then
                Barang = "1"
            Else
                Barang = "0"
            End If
            If .Items(1).CheckState = CheckState.Checked Then
                Pemasok = "1"
            Else
                Pemasok = "0"
            End If
            If .Items(2).CheckState = CheckState.Checked Then
                TransaksiPenjualan = "1"
            Else
                TransaksiPenjualan = "0"
            End If
            If .Items(3).CheckState = CheckState.Checked Then
                TransaksiPembelian = "1"
            Else
                TransaksiPembelian = "0"
            End If
            If .Items(4).CheckState = CheckState.Checked Then
                TransaksiKas = "1"
            Else
                TransaksiKas = "0"
            End If
        End With
        '======================================================================================
        With CheckedListBoxControl2
            If .Items(0).CheckState = CheckState.Checked Then
                LaporanPenjualan = "1"
            Else
                LaporanPenjualan = "0"
            End If
            If .Items(1).CheckState = CheckState.Checked Then
                LaporanPembelian = "1"
            Else
                LaporanPembelian = "0"
            End If
            If .Items(2).CheckState = CheckState.Checked Then
                LaporanKas = "1"
            Else
                LaporanKas = "0"
            End If
            If .Items(3).CheckState = CheckState.Checked Then
                LaporanDataBarang = "1"
            Else
                LaporanDataBarang = "0"
            End If
        End With
        '======================================================================================
        With CheckedListBoxControl3
            If .Items(0).CheckState = CheckState.Checked Then
                KonfigurasiServer = "1"
            Else
                KonfigurasiServer = "0"
            End If
            If .Items(1).CheckState = CheckState.Checked Then
                Pegawai = "1"
            Else
                Pegawai = "0"
            End If
            If .Items(2).CheckState = CheckState.Checked Then
                HakAkses = "1"
            Else
                HakAkses = "0"
            End If
        End With
    End Sub
    Sub SimpanAkses()
        If txtNamaAkses.Text = "" Then
            MessageBox.Show("Nama Hak Akses wajib di isi!", "validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        cekakses()
        Dim Cari = EksekusiQuery("SELECT * FROM hak_akses WHERE NamaAkses='" & txtNamaAkses.Text & "'").Select()
        If Cari.Length = 0 Then
            EksekusiQuery("INSERT INTO hak_akses(NamaAkses,TransaksiPenjualan,TransaksiPembelian,TransaksiKas,Barang,Pemasok,Pegawai,KonfigurasiServer,HakAkses,LaporanPenjualan,LaporanPembelian,LaporanKas,LaporanInfoDataBarang) VALUES ('" & txtNamaAkses.Text & "','" & TransaksiPenjualan & "','" & TransaksiPembelian & "','" & TransaksiKas & "','" & Barang & "','" & Pemasok & "','" & Pegawai & "','" & KonfigurasiServer & "','" & HakAkses & "','" & LaporanPenjualan & "','" & LaporanPembelian & "','" & LaporanKas & "','" & LaporanDataBarang & "')")
        Else
            EksekusiQuery("UPDATE hak_akses SET  TransaksiPenjualan='" & TransaksiPenjualan & "',TransaksiPembelian='" & TransaksiPembelian & "',TransaksiKas='" & TransaksiKas & "',Barang='" & Barang & "',Pemasok='" & Pemasok & "',Pegawai='" & Pegawai & "',KonfigurasiServer='" & KonfigurasiServer & "' ,HakAkses='" & HakAkses & "',LaporanPenjualan='" & LaporanPenjualan & "',LaporanPembelian='" & LaporanPembelian & "',LaporanKas='" & LaporanKas & "',LaporanInfoDataBarang='" & LaporanDataBarang & "' WHERE NamaAkses='" & txtNamaAkses.Text & "'")
        End If
        RefreshData()
        MessageBox.Show("Data Berhasil Disimpan!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Sub AmbilData()
        If GridView1.GetFocusedRowCellValue("Barang") = "0" And GridView1.GetFocusedRowCellValue("Pemasok") = "0" And GridView1.GetFocusedRowCellValue("TransaksiPembelian") = "0" And GridView1.GetFocusedRowCellValue("TransaksiPenjualan") = "0" And GridView1.GetFocusedRowCellValue("TransaksiKas") = "0" Then
            CheckedListBoxControl1.UnCheckAll()
        Else
            Dim isi() As String = {"Barang", "Pemasok", "TransaksiPenjualan", "TransaksiPembelian", "TransaksiKas"}
            For i = 0 To isi.Length - 1
                With CheckedListBoxControl1
                    If GridView1.GetFocusedRowCellValue(isi(i)) = "1" Then
                        .Items(i).CheckState = CheckState.Checked
                    Else
                        .Items(i).CheckState = CheckState.Unchecked
                    End If
                End With
            Next
        End If
        If GridView1.GetFocusedRowCellValue("LaporanPembelian") = "0" And GridView1.GetFocusedRowCellValue("LaporanPenjualan") = "0" And GridView1.GetFocusedRowCellValue("LaporanKas") = "0" And GridView1.GetFocusedRowCellValue("LaporanInfoDataBarang") = "0" Then
            CheckedListBoxControl2.UnCheckAll()
        Else
            Dim isi() As String = {"LaporanPenjualan", "LaporanPembelian", "LaporanKas", "LaporanInfoDataBarang"}

            For i = 0 To isi.Length - 1
                With CheckedListBoxControl2
                    If GridView1.GetFocusedRowCellValue(isi(i)) = "1" Then
                        .Items(i).CheckState = CheckState.Checked
                    Else
                        .Items(i).CheckState = CheckState.Unchecked
                    End If
                End With
            Next
        End If
        If GridView1.GetFocusedRowCellValue("KonfigurasiServer") = "0" And GridView1.GetFocusedRowCellValue("Pegawai") = "0" And GridView1.GetFocusedRowCellValue("HakAkses") = "0" Then
            CheckedListBoxControl3.UnCheckAll()
        Else
            Dim isi() As String = {"KonfigurasiServer", "Pegawai", "HakAkses"}
            For i = 0 To isi.Length - 1
                With CheckedListBoxControl3
                    If GridView1.GetFocusedRowCellValue(isi(i)) = "1" Then
                        .Items(i).CheckState = CheckState.Checked
                    Else
                        .Items(i).CheckState = CheckState.Unchecked
                    End If
                End With
            Next
        End If
    End Sub
    Sub UbahData()
        If GridView1.RowCount > 0 Then
            txtNamaAkses.Text = GridView1.GetFocusedRowCellValue("NamaAkses")
            AmbilData()
            txtNamaAkses.Properties.ReadOnly = True
            txtNamaAkses.TabStop = False
            CheckedListBoxControl1.Focus()
        End If
    End Sub
    Dim Tampung As New DataTable
    Sub TampilData()
        Tampung = EksekusiQuery("Select * From hak_akses")
        GridControl1.DataSource = Tampung
    End Sub
    Sub RefreshData()
        TampilData()
        txtNamaAkses.Text = ""
        CheckedListBoxControl1.UnCheckAll()
        CheckedListBoxControl2.UnCheckAll()
        CheckedListBoxControl3.UnCheckAll()
        txtNamaAkses.Properties.ReadOnly = False
        txtNamaAkses.Focus()
    End Sub
    Sub HapusData()
        If GridView1.RowCount > 0 Then
            If MessageBox.Show("Data akan di hapus!!" & vbCrLf & "Lanjut?", "Validasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                EksekusiQuery("DELETE FROM hak_akses WHERE NamaAkses='" & GridView1.GetFocusedRowCellValue("NamaAkses") & "'")
                RefreshData()
            End If
        End If
    End Sub
    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
        SimpanAkses()
    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs)
        UbahData()
    End Sub
    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs)
        RefreshData()
    End Sub
    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs)
        HapusData()
    End Sub
    Private Sub csLaporan_CheckStateChanged(sender As Object, e As EventArgs)
        If csLaporan.CheckState = CheckState.Checked Then
            CheckedListBoxControl2.CheckAll()
        Else
            CheckedListBoxControl2.UnCheckAll()
        End If
    End Sub
    Private Sub csDataUtama_CheckStateChanged(sender As Object, e As EventArgs)
        If csDataUtama.CheckState = CheckState.Checked Then
            CheckedListBoxControl1.CheckAll()
        Else
            CheckedListBoxControl1.UnCheckAll()
        End If
    End Sub
    Private Sub csSetting_CheckStateChanged(sender As Object, e As EventArgs)
        If csSetting.CheckState = CheckState.Checked Then
            CheckedListBoxControl3.CheckAll()
        Else
            CheckedListBoxControl3.UnCheckAll()
        End If
    End Sub
    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        SimpanAkses()
    End Sub
    Private Sub SimpleButton2_Click_1(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        UbahData()
    End Sub
    Private Sub SimpleButton4_Click_1(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        RefreshData()
    End Sub
    Private Sub SimpleButton3_Click_1(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        HapusData()
    End Sub
End Class