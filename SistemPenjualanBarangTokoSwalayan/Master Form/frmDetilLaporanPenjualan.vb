Public Class frmDetilLaporanPenjualan

    Dim Tampung As New DataTable
    Public NomorTransaksi, KodePegawai, NamaPegawai As String
    '    asKodePemasok, NamaPemasok
    Public Tanggal As Date
    Sub TampilTabel()


        Tampung = EksekusiQuery("select a.KodeBarang,b.NamaBarang,a.HargaSatuan,a.Jumlah,(a.HargaSatuan*a.Jumlah) as SubTotalHarga,a.PersenDiskon,((a.HargaSatuan*a.Jumlah) *(PersenDiskon/100))as JumlahDiskon,((a.HargaSatuan*a.Jumlah)-((a.HargaSatuan*a.Jumlah) *(PersenDiskon/100))) as TotalHarga from (penjualan_detil a inner join barang b on a.Kodebarang=b.Kodebarang) where a.NomorTransaksi='" & txtNomorTransaksi.Text & "'  order by Namabarang asc")
        GridControl1.DataSource = Tampung

        GridviewEditTampilan(GridView1, , "HargaSatuan,Jumlah,SubTotalHarga,JumlahDiskon,TotalHarga", "JumlahDiskon,TotalHarga")


    End Sub
    Sub Cetak()
        GridView1.ShowRibbonPrintPreview()
    End Sub

    Private Sub frmDetilLaporanPenjualan_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case e.Control And Keys.P
                Cetak()
            Case Keys.Escape
                Me.Close()

        End Select
    End Sub


    Private Sub frmDetilLaporanPenjualann_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNomorTransaksi.ReadOnly = True
        txtTanggal.ReadOnly = True
        txtPegawai.ReadOnly = True
        txtNomorTransaksi.Text = NomorTransaksi
        txtTanggal.DateTime = Tanggal
        txtPegawai.Text = NamaPegawai & "(" & KodePegawai & ")"
        TampilTabel()


    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Cetak()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()

    End Sub
End Class