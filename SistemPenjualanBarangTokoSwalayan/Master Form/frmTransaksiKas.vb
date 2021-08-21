Imports DevExpress.XtraGrid.Views.Base
Imports System.Globalization
Public Class frmTransaksiKas

    Private Sub frmTransaksiKas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case e.Control And Keys.Enter
                SimpanData()
            Case Keys.F5
                RefreshData()
            Case Keys.Escape
                Me.Close()




        End Select
    End Sub

    Private Sub frmTransaksiKas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        txtNomorTransaksi.Properties.ReadOnly = True
        txtNomorTransaksi.TabStop = False

        RefreshData()



      
    End Sub




    Function HitungSaldo() As Double
        Dim Hasil As Double
        Try
            Hasil = EksekusiQuery("select if (sum(Masuk-Keluar)<>0,sum(Masuk-Keluar),0) as Saldo from kas").Select()(0).Item("Saldo")
        Catch ex As Exception
            Hasil = 0
        End Try
        Return Hasil
    End Function

    Dim Tampung As New DataTable
    Sub TampilData()
        Tampung = EksekusiQuery("Select Tanggal,NomorTransaksi,Uraian,Masuk,Keluar,Saldo,KodePegawai from kas where date_format(Tanggal,'%Y-%m-%d') ='" & Format(Now, "yyyy-MM-dd") & "'")
        GridControl1.DataSource = Tampung
        GridviewEditTampilan(GridView1, "KodePegawai", "Masuk,Keluar,Saldo", "Masuk,Keluar")

    End Sub
    Sub RefreshData()
        TampilData()
        txtNomorTransaksi.Text = KodeOtomatis("kas", "NomorTransaksi", "KAS", "000000000000")
        txtTanggal.DateTime = Now
        txtUraian.Text = ""
        txtStatusKas.Text = ""
        txtNominal.Value = 0
        txtTanggal.Focus()

    End Sub

    Sub SimpanData()
        If txtNomorTransaksi.Text = "" Or txtTanggal.Text = "" Or txtUraian.Text = "" Or txtStatusKas.Text = "" Or txtNominal.Value <= 0 Then
            MessageBox.Show("Nomor Transaksi, Tanggal, Uraian, Status Kas, dan Nominal wajib di isi!", "validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub

        End If
        Select Case txtStatusKas.SelectedIndex
            Case 0
                EksekusiQuery("INSERT INTO kas(NomorTransaksi,Tanggal,Uraian,Masuk,Keluar,Saldo,KodePegawai)  VALUES ('" & txtNomorTransaksi.Text & "','" & Format(txtTanggal.DateTime, "yyyy-MM-dd HH:mm:ss").Replace(".", ":") & "','" & txtUraian.Text & "'," & txtNominal.Value & ",0," & HitungSaldo() + txtNominal.Value & ",'" & My.Settings.sKodePegawai & "')")
            Case 1
                EksekusiQuery("INSERT INTO kas(NomorTransaksi,Tanggal,Uraian,Masuk,Keluar,Saldo,KodePegawai)  VALUES ('" & txtNomorTransaksi.Text & "','" & Format(txtTanggal.DateTime, "yyyy-MM-dd") & "','" & txtUraian.Text & "',0," & txtNominal.Value & "," & HitungSaldo() - txtNominal.Value & ",'" & My.Settings.sKodePegawai & "')")
        End Select


        RefreshData()
        MessageBox.Show("Transaksi Berhasil Disimpan.:", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub









    


    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        RefreshData()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()

    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        SimpanData()
    End Sub
End Class