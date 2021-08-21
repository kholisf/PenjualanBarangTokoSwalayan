Public Class frmDetilLaporanPembelian

    Dim Tampung As New DataTable
    Public NomorTransaksi, KodePemasok, NamaPemasok, KodePegawai, NamaPegawai As String
    Public Tanggal As Date
    Sub TampilTabel()
        'Tampung = EksekusiQuery("select a.KodeBarang,b.NamaBarang,a.HargaSatuan,a.Jumlah As JumlahBeli,(a.HargaSatuan*a.Jumlah) as TotalHarga,(a.HargaSatuan*a.Jumlah)-((a.HargaSatuan*a.Jumlah) *(PersenDiskon/100))")

        Tampung = EksekusiQuery("select a.KodeBarang,b.NamaBarang,a.HargaSatuan,a.Jumlah,(a.HargaSatuan*a.Jumlah) as SubTotalHarga,a.PersenDiskon,((a.HargaSatuan*a.Jumlah) *(PersenDiskon/100))as JumlahDiskon,((a.HargaSatuan*a.Jumlah)-((a.HargaSatuan*a.Jumlah) *(PersenDiskon/100))) as TotalHarga from (pembelian_detil a inner join barang b on a.Kodebarang=b.Kodebarang) where a.NomorTransaksi='" & txtNomorTransaksi.Text & "'  order by Namabarang asc")
        GridControl1.DataSource = Tampung

        GridviewEditTampilan(GridView1, , "HargaSatuan,Jumlah,SubTotalHarga,JumlahDiskon,TotalHarga", "JumlahDiskon,TotalHarga")

        'GridviewEditTampilan(GridView1,,"HargaSatuan
    End Sub
    Sub Cetak()
        ReportLaporanPembelianDetil(txtNomorTransaksi.Text, txtTanggal.DateTime, NamaPegawai & "(" & KodePegawai & ")", NamaPemasok & "(" & KodePemasok & ")")
    End Sub

    Private Sub frmDetilLaporanPembelian_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case e.Control And Keys.P
                Cetak()
            Case Keys.Escape
                Me.Close()

        End Select
    End Sub


    Private Sub frmDetilLaporanPembeliann_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNomorTransaksi.ReadOnly = True
        txtTanggal.ReadOnly = True
        txtPemasok.ReadOnly = True
        TxtPegawai.ReadOnly = True
        txtNomorTransaksi.Text = NomorTransaksi
        txtTanggal.DateTime = Tanggal
        txtPemasok.Text = NamaPemasok & "(" & KodePemasok & ")"
        TxtPegawai.Text = NamaPegawai & "(" & KodePegawai & ")"
        TampilTabel()


    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Cetak()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()

    End Sub
End Class