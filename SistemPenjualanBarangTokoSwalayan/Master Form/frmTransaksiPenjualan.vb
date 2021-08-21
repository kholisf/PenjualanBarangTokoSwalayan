Imports DevExpress.XtraGrid.Views.Base
Imports System.Globalization
Public Class frmTransaksiPenjualan


    Private Sub frmTransaksiPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        txtNomorTransaksi.Properties.ReadOnly = True
        txtKodeBarang.Properties.ReadOnly = True

        txtNamaBarang.Properties.ReadOnly = True
        txtNomorTransaksi.TabStop = False

        txtKodeBarang.TabStop = False
        txtNamaBarang.TabStop = False
        txtHargaSatuan.ReadOnly = True
        txtHargaSatuan.TabStop = False


        txtHargaSatuan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        txtHargaSatuan.Properties.Mask.EditMask = "n0"
        txtJumlah.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        txtJumlah.Properties.Mask.EditMask = "n0"
        txtDiskon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        txtDiskon.Properties.Mask.EditMask = "n0"
        txtPotongan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        txtPotongan.Properties.Mask.EditMask = "n0"
        txtJumlahUang.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        txtJumlahUang.Properties.Mask.EditMask = "n0"
        RefreshData()
        
    End Sub
    Dim Tampung As New DataTable
    Sub TampilTabel()
        Tampung = EksekusiQuery("select a.KodeBarang,b.NamaBarang,a.HargaSatuan,a.Jumlah,a.PersenDiskon,(a.HargaSatuan*a.Jumlah*(a.PersenDiskon/100)) as JumlahDiskon,(a.HargaSatuan*a.Jumlah)-(a.HargaSatuan*a.Jumlah*(a.PersenDiskon/100)) as JumlahHarga from (penjualan_detil a inner join barang b on a.KodeBarang=b.KodeBarang) where a.NomorTransaksi='000000000000000'")
        GridControl1.DataSource = Tampung

        GridviewEditTampilan(GridView1, , "HargaSatuan,Jumlah,JumlahDiskon,JumlahHarga", "JumlahDiskon,JumlahHarga", "KodeBarang,NamaBarang,HargaSatuan,JumlahDiskon,JumlahHarga")
        'With GridView1.GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, "JumlahHarga")
        '    .ShowInGroupColumnFooter = GridView1.Columns("JumlahHarga")
        '    .DisplayFormat = "{0:n" & Val("JumlahHarga") & "}"
        'End With
        'GridView1.OptionsView.ShowFooter = True

        'GridView1.Columns("JumlahHarga").SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Sum, "{0:n" & Val("JumlahHarga") & "}")
        GridView1.Columns("Jumlah").OptionsColumn.AllowEdit = True
        GridView1.Columns("PersenDiskon").OptionsColumn.AllowEdit = True

    End Sub
    Sub RefreshData()
        TampilTabel()
        
        txtKodeBarang.Text = ""
        txtnamabarang.Text = ""
        txtTanggal.DateTime = Format(Now, "yyyy-MM-dd HH:mm:ss")
        txtHargaSatuan.Value = 0
        txtJumlah.Value = 0
        txtDiskon.Value = 0
        txtPotongan.Value = 0
        txtJumlahUang.Value = 0
        txtNomorTransaksi.Text = KodeOtomatis("penjualan", "NomorTransaksi", "PNJ", "000000000000")

        txttanggal.Focus()
    End Sub
    

    Sub ListBarang()
        With frmListBarang

            .NilaiKiriman = 1
            .ShowDialog()
        End With
    End Sub

    Sub TampilInfo()
        If GridView1.RowCount > 0 Then
            txtInfo.Text = "Rp. " & Format(GridView1.Columns("JumlahHarga").SummaryItem.SummaryValue - txtPotongan.Value, "n0") & ",-"
        Else
            txtinfo.Text = "Rp. 0,-"
        End If
    End Sub
    Sub TambahDaftar()
        If txtKodeBarang.Text = "" Or txtnamabarang.Text = "" Or txtHargaSatuan.Value <= 0 Or txtJumlah.Value <= 0 Then
            MessageBox.Show("Kode Barang, Nama Barang, Harga Satuan, dan Jumlah wajib diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If txtDiskon.Value > 100 And txtDiskon.Value <= 0 Then
            MessageBox.Show("Persen Diskon tidak valid!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'step1
        Dim StokLama As Double = EksekusiQuery("select Stok from barang where KodeBarang='" & txtKodeBarang.Text & "'").Select()(0).Item("Stok")

        Dim CekDaftar = Tampung.Select("KodeBarang='" & txtKodeBarang.Text & "'")
        If CekDaftar.Length = 0 Then
            Dim BarisBaru = Tampung.NewRow
            With BarisBaru

                'step2
                If txtJumlah.Value > StokLama Then
                    MessageBox.Show("Stok tidak cukup!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtJumlah.Value = StokLama

                    Exit Sub
                End If

                .Item("KodeBarang") = txtKodeBarang.Text
                .Item("NamaBarang") = txtnamabarang.Text
                .Item("HargaSatuan") = txtHargaSatuan.Value
                .Item("Jumlah") = txtJumlah.Value
                .Item("PersenDiskon") = txtDiskon.Value
                .Item("JumlahDiskon") = .Item("HargaSatuan") * .Item("Jumlah") * (.Item("PersenDiskon") / 100)
                .Item("JumlahHarga") = (.Item("HargaSatuan") * .Item("Jumlah")) - .Item("JumlahDiskon")
            End With
            Tampung.Rows.Add(BarisBaru)
        Else
            With CekDaftar(0)

                'step3
                If txtJumlah.Value + .Item("Jumlah") > StokLama Then
                    MessageBox.Show("Stok tidak cukup!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtJumlah.Value = StokLama - .Item("Jumlah")
                    Exit Sub
                End If

                .Item("Jumlah") = .Item("Jumlah") + txtJumlah.Value
                .Item("JumlahDiskon") = .Item("HargaSatuan") * .Item("Jumlah") * (.Item("PersenDiskon") / 100)
                .Item("JumlahHarga") = (.Item("HargaSatuan") * .Item("Jumlah")) - .Item("JumlahDiskon")
            End With
        End If
        txtKodeBarang.Text = ""
        txtnamabarang.Text = ""
        txtHargaSatuan.Value = 0
        txtJumlah.Value = 0
        txtDiskon.Value = 0
        txtKodeBarang.Focus()
        TampilInfo()


    End Sub

    Sub HapusDaftar()
        If GridView1.RowCount > 0 Then
            GridView1.DeleteSelectedRows()
        End If
    End Sub

    Sub Simpan()

        If txtNomorTransaksi.Text = "" Or txtTanggal.Text = "" Then
            MessageBox.Show("Nomor Transaksi dan Tanggal wajib diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If GridView1.RowCount <= 0 Then
            MessageBox.Show("Daftar belanja tidak ditemukan!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If txtPotongan.Value > GridView1.Columns("JumlahHarga").SummaryItem.SummaryValue Then
            MessageBox.Show("Jumlah Potongan tidak valid!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If txtJumlahUang.Value < (GridView1.Columns("JumlahHarga").SummaryItem.SummaryValue - txtPotongan.Value) Then
            MessageBox.Show("Jumlah Uang Masih Kurang!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim TotalPenjualan As Double = 0
        Dim UangKembalian As Double = 0
        

        EksekusiQuery(" INSERT INTO penjualan(NomorTransaksi,Tanggal,Potongan,JumlahUang,KodePegawai) VALUES ('" & txtNomorTransaksi.Text & "','" & Format(txtTanggal.DateTime, "yyyy-MM-dd HH:mm:ss").Replace(".", ";") & "'," & txtPotongan.Value & "," & txtJumlahUang.Value & ",'" & My.Settings.sKodePegawai & "')")

        For Each Isi In Tampung.Select()
            EksekusiQuery("INSERT INTO penjualan_detil(NomorTransaksi,KodeBarang,HargaSatuan,Jumlah,PersenDiskon) VALUES ('" & txtNomorTransaksi.Text & "','" & Isi.Item("KodeBarang") & "'," & Isi.Item("HargaSatuan") & "," & Isi.Item("Jumlah") & "," & Isi.Item("PersenDiskon") & ")")
            Dim StokLama As Double = EksekusiQuery("select Stok from barang where KodeBarang='" & Isi.Item("KodeBarang") & "'").Select()(0).Item("Stok")
            Dim StokBaru As Double = StokLama - Isi.Item("Jumlah")
            EksekusiQuery("update barang set Stok=" & StokBaru & " where KodeBarang='" & Isi.Item("KodeBarang") & "'")
            TotalPenjualan += (Isi.Item("HargaSatuan") * Isi.Item("Jumlah")) - ((Isi.Item("HargaSatuan") * Isi.Item("Jumlah")) * (Isi.Item("PersenDiskon") / 100))


        Next
        TotalPenjualan -= txtPotongan.Value
        UangKembalian = txtJumlahUang.Value - TotalPenjualan
       



        Dim KODEKAS As String = KodeOtomatis("kas", "NomorTransaksi", "KAS", "000000000000")
        EksekusiQuery("Insert into kas (NomorTransaksi,Tanggal,Uraian,Masuk,Keluar,Saldo,KodePegawai) values ('" & KODEKAS & "','" & Format(txtTanggal.DateTime, "yyyy-MM-dd HH:mm:ss").Replace(".", ":") & "','Kas Masuk Dari penjualan dengan no. " & txtNomorTransaksi.Text & "'," & txtJumlahUang.Value & "," & UangKembalian & "," & frmTransaksiKas.HitungSaldo() + TotalPenjualan & ",'" & My.Settings.sKodePegawai & "')")

        TampilInfo()
        
        MessageBox.Show("Sukses disimpan!!" & vbCrLf & "Uang Kembalian  : Rp. " & Format(UangKembalian, "n0") & ",-", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If MessageBox.Show("Transaksi berhasil. Cetak nota transaksi ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            ReportNotaPenjualan(txtNomorTransaksi.Text, Format(txtTanggal.DateTime, "yyyy-MM-dd"), txtJumlahUang.Value, UangKembalian, True)
        End If
        RefreshData()

    End Sub

    Sub Tutup()
        Me.Close()
    End Sub

    Private Sub frmTransaksipenjualan_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
    
            Case Keys.F1
                ListBarang()
            Case Keys.End
                TambahDaftar()
            Case e.Control And Keys.Delete
                HapusDaftar()
            Case e.Control And Keys.Enter
                Simpan()
            Case Keys.F5
                RefreshData()

            Case Keys.Escape
                Tutup()
        End Select
    End Sub

    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        With GridView1
            
            Select Case e.Column.GetTextCaption

                Case "Harga Satuan"
                    .SetFocusedRowCellValue("JumlahDiskon", Val(.GetFocusedRowCellValue("HargaSatuan")) * Val(.GetFocusedRowCellValue("Jumlah")) * Val((.GetFocusedRowCellValue("PersenDiskon") / 100)))
                    .SetFocusedRowCellValue("JumlahHarga", Val(.GetFocusedRowCellValue("HargaSatuan")) * Val(.GetFocusedRowCellValue("Jumlah")) - Val(.GetFocusedRowCellValue("JumlahDiskon")))


                Case "Jumlah"
                    'step4
                    Dim StokLama As Double = EksekusiQuery("select Stok from barang where KodeBarang='" & .GetFocusedRowCellValue("KodeBarang") & "'").Select()(0).Item("Stok")

                    'step5
                    If Val(.GetFocusedRowCellValue("Jumlah")) > StokLama Then
                        MessageBox.Show("Stok tidak cukup!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        .SetFocusedRowCellValue("Jumlah", StokLama)
                    End If

                    .SetFocusedRowCellValue("JumlahDiskon", Val(.GetFocusedRowCellValue("HargaSatuan")) * Val(.GetFocusedRowCellValue("Jumlah")) * Val((.GetFocusedRowCellValue("PersenDiskon") / 100)))
                    .SetFocusedRowCellValue("JumlahHarga", Val(.GetFocusedRowCellValue("HargaSatuan")) * Val(.GetFocusedRowCellValue("Jumlah")) - Val(.GetFocusedRowCellValue("JumlahDiskon")))
                Case "Persen Diskon"

                    .SetFocusedRowCellValue("JumlahDiskon", Val(.GetFocusedRowCellValue("HargaSatuan")) * Val(.GetFocusedRowCellValue("Jumlah")) * Val((.GetFocusedRowCellValue("PersenDiskon") / 100)))
                    .SetFocusedRowCellValue("JumlahHarga", Val(.GetFocusedRowCellValue("HargaSatuan")) * Val(.GetFocusedRowCellValue("Jumlah")) - Val(.GetFocusedRowCellValue("JumlahDiskon")))

            End Select

            .RefreshData()
            .BestFitColumns()
            .ExpandAllGroups()
            TampilInfo()
        End With
    End Sub

    Private Sub GridView1_RowCountChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.RowCountChanged
        With GridView1
            
            .BestFitColumns()
            .ExpandAllGroups()

            TampilInfo()
        End With
    End Sub
    Private Sub txtKodeBarang_Click(sender As Object, e As EventArgs)
        ListBarang()

    End Sub


    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        RefreshData()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        HapusDaftar()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()

    End Sub

    Private Sub SimpleButton2_Click_1(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        TambahDaftar()
    End Sub


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Simpan()

    End Sub

    Private Sub txtKodeBarang_Click1(sender As Object, e As EventArgs) Handles txtKodeBarang.Click
        ListBarang()

    End Sub

    Private Sub txtPotongan_EditValueChanged(sender As Object, e As EventArgs) Handles txtPotongan.EditValueChanged
        TampilInfo()
    End Sub
End Class