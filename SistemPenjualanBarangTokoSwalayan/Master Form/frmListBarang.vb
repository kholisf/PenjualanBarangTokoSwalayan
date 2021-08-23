Public Class frmListBarang
    Dim Tampung As New DataTable
    Public NilaiKiriman As Integer
    Sub TampilData()
        Tampung = EksekusiQuery("Select * From barang where KodeBarang<>'0000000000'")
        GridControl1.DataSource = Tampung
         GridviewEditTampilan(GridView2, , "HargaBeli,HargaJual,Stok")
    End Sub
    Sub PilihData()
        Select Case NilaiKiriman
            Case 1
                frmTransaksiPenjualan.txtKodeBarang.Text = GridView2.GetFocusedRowCellValue("KodeBarang")
                frmTransaksiPenjualan.txtNamaBarang.Text = GridView2.GetFocusedRowCellValue("NamaBarang")
                frmTransaksiPenjualan.txtHargaSatuan.Text = GridView2.GetFocusedRowCellValue("HargaJual")
            Case 2
                frmTransaksiPembelian.txtKodeBarang.Text = GridView2.GetFocusedRowCellValue("KodeBarang")
                frmTransaksiPembelian.txtNamaBarang.Text = GridView2.GetFocusedRowCellValue("NamaBarang")
                frmTransaksiPembelian.txtHargaSatuan.Text = GridView2.GetFocusedRowCellValue("HargaBeli")
        End Select
        Me.Close()
    End Sub
    Private Sub frmListBarang_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case e.Control And Keys.Enter
                PilihData()
            Case Keys.Escape
                Me.Close()
            Case Keys.F2
                txtCariData.Focus()
        End Select
    End Sub
    Private Sub frmListBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        txtCariData.Text = ""
        TampilData()
    End Sub
    Private Sub txtCariData_EditValueChanged(sender As Object, e As EventArgs) Handles txtCariData.EditValueChanged
        GridView2.FindFilterText = txtCariData.Text
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        PilihData()
    End Sub
    Private Sub GridView2_DoubleClick(sender As Object, e As EventArgs) Handles GridView2.DoubleClick
        PilihData()
    End Sub
    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Me.Close()
    End Sub
End Class