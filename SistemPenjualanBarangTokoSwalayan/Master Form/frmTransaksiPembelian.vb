Imports DevExpress.XtraGrid.Views.Base
Imports System.Globalization
Public Class frmTransaksiPembelian
    Private Sub frmTransaksiPembelian_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                ListBarang()
            Case Keys.F2
                ListPemasok()
            Case e.Control And Keys.Enter
                Simpan()
            Case Keys.Enter
                TambahDaftar()
            Case e.Control And Keys.Delete
                HapusItem()
            Case Keys.F5
                RefreshData()
            Case Keys.Escape
                tutup()
        End Select
    End Sub
    Private Sub frmTransaksiPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        txtNomorTransaksi.Properties.ReadOnly = True
        txtNamaBarang.Properties.ReadOnly = True
        txtKodeBarang.Properties.ReadOnly = True
        txtHargaSatuan.Properties.ReadOnly = True
        txtNomorTransaksi.TabStop = False
        txtNamaPemasok.Properties.ReadOnly = True
        txtNamaPemasok.TabStop = False
        txtKodePemasok.Properties.ReadOnly = True
        txtKodePemasok.TabStop = False
        txtNamaBarang.TabStop = False
        txtKodeBarang.TabStop = False
        txtHargaSatuan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        txtHargaSatuan.Properties.Mask.EditMask = "n0"
        txtJumlah.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        txtJumlah.Properties.Mask.EditMask = "n0"
        txtDiskon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        txtDiskon.Properties.Mask.EditMask = "n0"
        RefreshData()
    End Sub
    Dim Tampung As New DataTable
    Sub TampilTabel()
        Tampung = EksekusiQuery("select a.KodeBarang,b.NamaBarang,a.HargaSatuan,a.Jumlah,a.PersenDiskon,(a.HargaSatuan*a.Jumlah*(a.PersenDiskon/100)) as JumlahDiskon,(a.HargaSatuan*a.Jumlah)-(a.HargaSatuan*a.Jumlah*(a.PersenDiskon/100))as JumlahHarga from (pembelian_detil a inner join barang b on a.KodeBarang=b.KodeBarang) where a.NomorTransaksi ='000000000000000'")
        GridControl1.DataSource = Tampung
        GridviewEditTampilan(GridView1, , "HargaSatuan,Jumlah,JumlahDiskon,JumlahHarga", "JumlahHarga,JumlahDiskon", "KodeBarang,NamaBarang,HargaSatuan,JumlahDiskon,JumlahHarga")
    End Sub
    Sub RefreshData()
        txtKodeBarang.Text = ""
        txtNamaPemasok.Text = ""
        txtKodePemasok.Text = ""
        txtNamaBarang.Text = ""
        txtTanggal.DateTime = Now
        txtTanggal.ReadOnly = True
        txtHargaSatuan.Value = 0
        txtJumlah.Value = 0
        txtDiskon.Value = 0
        txtPotongan.Value = 0
        txtNomorTransaksi.Text = KodeOtomatis("pembelian", "NomorTransaksi", "PMB", "000000000000")
        txtKodePemasok.Focus()
        TampilTabel()
    End Sub
    Sub ListPemasok()
        With frmListPemasok
            .NilaiKiriman = 1
            .ShowDialog()
        End With
    End Sub
    Sub ListBarang()
        With frmListBarang
            .NilaiKiriman = 2
            .ShowDialog()
        End With
    End Sub
    Sub TampilInfo()
        If GridView1.RowCount > 0 Then
            txtInfo.Text = "Rp." & Format(GridView1.Columns("JumlahHarga").SummaryItem.SummaryValue - txtPotongan.Value, "#,##0") & ",-"
        Else
            txtInfo.Text = "Rp. 0,-"
        End If
    End Sub
    Sub tutup()
        Me.Close()
    End Sub
    Sub TambahDaftar()
        If txtKodeBarang.Text = "" Or txtNamaBarang.Text = "" Or txtHargaSatuan.Value <= 0 Or txtJumlah.Value <= 0 Then
            MessageBox.Show("KodeBarang,NamaBarang,hargaSatuan, dan Jumlah wajib diisi!", "validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If txtDiskon.Value > 100 Then
            MessageBox.Show("PersenDiskon Tidak Valid", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim CekDaftar = Tampung.Select("KodeBarang='" & txtKodeBarang.Text & "'")
        If CekDaftar.Length = 0 Then
            Dim BarisBaru = Tampung.NewRow
            With BarisBaru
                .Item("KodeBarang") = txtKodeBarang.Text
                .Item("NamaBarang") = txtNamaBarang.Text
                .Item("HargaSatuan") = txtHargaSatuan.Value
                .Item("Jumlah") = txtJumlah.Value
                .Item("PersenDiskon") = txtDiskon.Value
                .Item("JumlahDiskon") = .Item("HargaSatuan") * .Item("Jumlah") * (.Item("PersenDiskon") / 100)
                .Item("JumlahHarga") = .Item("HargaSatuan") * .Item("Jumlah") - .Item("PersenDiskon")
            End With
            Tampung.Rows.Add(BarisBaru)
        Else
            With CekDaftar(0)
                .Item("Jumlah") = .Item("Jumlah") + txtJumlah.Value
                .Item("JumlahDiskon") = .Item("HargaSatuan") * .Item("Jumlah") * (.Item("PersenDiskon") / 100)
                .Item("JumlahHarga") = .Item("HargaSatuan") * .Item("Jumlah") - .Item("JumlahDiskon")
            End With
        End If
        txtKodeBarang.Text = ""
        txtNamaBarang.Text = ""
        txtHargaSatuan.Value = 0
        txtJumlah.Value = 0
        txtDiskon.Value = 0
        txtKodeBarang.Focus()
    End Sub
    Sub HapusItem()
        If GridView1.RowCount > 0 Then
            GridView1.DeleteSelectedRows()
        End If
    End Sub
    Sub Simpan()
        If txtNomorTransaksi.Text = "" Or txtTanggal.Text = "" Or txtKodePemasok.Text = "" Or txtNamaPemasok.Text = "" Or txtNamaPemasok.Text = "" Then
            MessageBox.Show("NomorTransaksi,Tanggal,KodePemasok, dan NamaPemasok wajib diisi!", "validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If GridView1.RowCount <= 0 Then
            MessageBox.Show("Daftar Belanja tidak valid!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If txtPotongan.Value > GridView1.Columns("JumlahHarga").SummaryItem.SummaryValue Then
            MessageBox.Show("Jumlah potongan Tidak valid!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim TotalPembelian As Double = 0
        For Each i In Tampung.Select()
            TotalPembelian += (i.Item("HargaSatuan") * i.Item("Jumlah")) - ((i.Item("HargaSatuan") * i.Item("Jumlah")) * (i.Item("PersenDiskon") / 100))
        Next
        EksekusiQuery("insert into pembelian(NomorTransaksi,Tanggal,KodePemasok,Potongan,TotalPembelian,KodePegawai) value ('" & txtNomorTransaksi.Text & "','" & Format(txtTanggal.DateTime, "yyyy-MM-dd HH:mm:ss").Replace(".", ":") & "','" & txtKodePemasok.Text & "','" & txtPotongan.Value & "','" & TotalPembelian & "','" & My.Settings.sKodePegawai & "')")
        For Each Isi In Tampung.Select()
            EksekusiQuery("insert into pembelian_detil(NomorTransaksi,KodeBarang,HargaSatuan,Jumlah,PersenDiskon) value('" & txtNomorTransaksi.Text & "','" & Isi.Item("KodeBarang") & "'," & Isi.Item("HargaSatuan") & "," & Isi.Item("Jumlah") & "," & Isi.Item("PersenDiskon") & ")")
            Dim StokLama As Double = EksekusiQuery("select Stok from barang where KodeBarang='" & Isi.Item("KodeBarang") & "'").Select()(0).Item("Stok")
            Dim StokBaru As Double = StokLama + Isi.Item("Jumlah")
            EksekusiQuery("update barang set stok=" & StokBaru & " where KodeBarang='" & Isi.Item("KodeBarang") & "'")
        Next
        Dim KODEKAS As String = KodeOtomatis("kas", "NomorTransaksi", "KAS", "000000000000")
        EksekusiQuery("INSERT INTO kas(NomorTransaksi,Tanggal,Uraian,Masuk,Keluar,Saldo,KodePegawai)  VALUES ('" & KODEKAS & "','" & Format(txtTanggal.DateTime, "yyyy-MM-dd HH:mm:ss").Replace(".", ":") & "','Kas keluar dari pembelian dengan no. " & txtNomorTransaksi.Text & "',0," & TotalPembelian & "," & frmTransaksiKas.HitungSaldo() - TotalPembelian & ",'" & My.Settings.sKodePegawai & "')")
        RefreshData()
        TampilInfo()
        MessageBox.Show("Sukses disimpan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        With GridView1
            Select Case e.Column.GetTextCaption
                Case "HargaSatuan"
                    .SetFocusedRowCellValue("JumlahDiskon", Val(.GetFocusedRowCellValue("HargaSatuan")) * Val(.GetFocusedRowCellValue("Jumlah")) * Val((.GetFocusedRowCellValue("PersenDiskon") / 100)))
                    .SetFocusedRowCellValue("JumlahHarga", Val(.GetFocusedRowCellValue(("HargaSatuan")) * Val(.GetFocusedRowCellValue("Jumlah"))) - Val(.GetFocusedRowCellValue("JumlahDiskon")))
                Case "Jumlah"
                    .SetFocusedRowCellValue("JumlahDiskon", Val(.GetFocusedRowCellValue("HargaSatuan")) * Val(.GetFocusedRowCellValue("Jumlah")) * Val((.GetFocusedRowCellValue("PersenDiskon") / 100)))
                    .SetFocusedRowCellValue("JumlahHarga", Val(.GetFocusedRowCellValue(("HargaSatuan")) * Val(.GetFocusedRowCellValue("Jumlah"))) - Val(.GetFocusedRowCellValue("JumlahDiskon")))
                Case "PersenDiskon"
                    .SetFocusedRowCellValue("JumlahDiskon", Val(.GetFocusedRowCellValue("HargaSatuan")) * Val(.GetFocusedRowCellValue("Jumlah")) * Val((.GetFocusedRowCellValue("PersenDiskon") / 100)))
                    .SetFocusedRowCellValue("JumlahHarga", Val(.GetFocusedRowCellValue(("HargaSatuan")) * Val(.GetFocusedRowCellValue("Jumlah"))) - Val(.GetFocusedRowCellValue("JumlahDiskon")))
            End Select
            .RefreshData()
            .BestFitColumns()
            .ExpandAllGroups()
            TampilInfo()
        End With
    End Sub
    Private Sub GridView1_RowCountChanged(sender As Object, e As EventArgs) Handles GridView1.RowCountChanged
        With GridView1
            .BestFitColumns()
            .ExpandAllGroups()
            TampilInfo()
        End With
    End Sub
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        HapusItem()
    End Sub
    Private Sub SimpleButton2_Click_1(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        TambahDaftar()
    End Sub
    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        RefreshData()
    End Sub
    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub
    Private Sub txtKodePemasok_Click(sender As Object, e As EventArgs) Handles txtKodePemasok.Click
        ListPemasok()
    End Sub
    Private Sub txtKodeBarang_Click(sender As Object, e As EventArgs) Handles txtKodeBarang.Click
        ListBarang()
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Simpan()
    End Sub
    Private Sub txtPotongan_EditValueChanged(sender As Object, e As EventArgs) Handles txtPotongan.EditValueChanged
        TampilInfo()
    End Sub
End Class