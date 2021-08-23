Public Class frmListPemasok
    Dim Tampung As New DataTable
    Public NilaiKiriman As Integer
    Sub TampilData()
        Tampung = EksekusiQuery("Select * From pemasok")
        GridControl1.DataSource = Tampung
        GridviewEditTampilan(GridView2)
    End Sub
    Sub PilihData()
        Select Case NilaiKiriman
            Case 1
                frmTransaksiPembelian.txtKodePemasok.Text = GridView2.GetFocusedRowCellValue("KodePemasok")
                frmTransaksiPembelian.txtNamaPemasok.Text = GridView2.GetFocusedRowCellValue("NamaPemasok")
            Case 2
                With frmLaporanPembelian
                    .txtKodePemasok.Text = GridView2.GetFocusedRowCellValue("KodePemasok")
                    .txtNamaPemasok.Text = GridView2.GetFocusedRowCellValue("NamaPemasok")
                End With
        End Select
        Me.Close()
    End Sub
    Private Sub frmListPemasok_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case e.Control And Keys.Enter
                PilihData()
            Case Keys.Escape
                Me.Close()
            Case Keys.F2
                txtCariData.Focus()
        End Select
    End Sub
    Private Sub frmListPemasok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        TampilData()
        txtCariData.Text = ""
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
End Class