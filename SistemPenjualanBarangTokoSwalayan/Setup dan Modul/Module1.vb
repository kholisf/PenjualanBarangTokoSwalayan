Imports MySql.Data.MySqlClient
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraBars.Helpers

Module Module1

    Public Function EksekusiQuery(ByVal QueryString As String) As DataTable
        Dim Connection As New MySqlConnection(My.Settings.sKoneksi)
        Dim DataAdapter As New MySqlDataAdapter(QueryString, Connection)
        Dim DataTable As New DataTable
        DataAdapter.Fill(DataTable)
        Return DataTable
    End Function



    Public Function KodeOtomatis(ByVal NamaTabel As String, ByVal NamaKolom As String, ByVal KodeInisial As String, ByVal DigitFormat As String) As String
        Dim KodeText As String = ""

        Dim DataKode = EksekusiQuery("select max(right(" & NamaKolom & "," & DigitFormat.Length & ")) as " & NamaKolom & " from " & NamaTabel & "").Select()

        Try
            KodeText = KodeInisial & Format(DataKode(0).Item(NamaKolom) + 1, DigitFormat)
        Catch ex As Exception
            KodeText = KodeInisial & Format(1, DigitFormat)
        End Try
        Return KodeText
    End Function


    'Panggil combobox dari database
    Public Sub ComboboxTambahItem(ByVal NamaTabel As String, ByVal NamaKolom As String, ByVal NamaKomboBox As DevExpress.XtraEditors.ComboBoxEdit)
        NamaKomboBox.Properties.Items.Clear()
        Dim cari = EksekusiQuery("Select distinct(" & NamaKolom & ") as " & NamaKolom & " from " & NamaTabel & "").Select()


        For i = 0 To cari.Length - 1
            NamaKomboBox.Properties.Items.Add(cari(i).Item(NamaKolom))
        Next
    End Sub

    Sub barbuttonTampilOrTidak(ByVal namakolon As String, ByVal ParamArray componentname() As Object)
        Dim cari = EksekusiQuery("select * from hak_akses where NamaAkses='" & My.Settings.sHakAkses & "'").Select()
        Dim sp = namakolon.Split(",")

        Dim ii As Integer = 0
        
        For Each i In sp

            With cari(0)
                If .Item(i) <> 1 Then
                    componentname(ii).Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Else
                    componentname(ii).Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                End If

            End With
            ii += 1



        Next


    End Sub



    Public Sub GridviewEditTampilan(ByVal NamaGridView As DevExpress.XtraGrid.Views.Grid.GridView, Optional ByVal SembunyiKolom As String = Nothing, Optional ByVal FormatKolomKeNumeric As String = Nothing, Optional ByVal SumKolomDanMenampilkanDibawahGridview As String = Nothing, Optional ByVal DenyEditFieldNames As String = Nothing)
        
        With NamaGridView
            If SembunyiKolom <> Nothing Then
                Dim kolom = SembunyiKolom.Split(",")
                For Each i In kolom
                    .Columns(i).Visible = False

                Next
            End If
            If FormatKolomKeNumeric <> Nothing Then
                Dim kolom = FormatKolomKeNumeric.Split(",")
                For Each i In kolom
                    .Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .Columns(i).DisplayFormat.FormatString = "n" & Val(i)
                Next
            End If
            If SumKolomDanMenampilkanDibawahGridview <> Nothing Then
                .OptionsView.ShowFooter = True
                Dim kolom = SumKolomDanMenampilkanDibawahGridview.Split(",")

                For Each i In kolom
                    .Columns(i).SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Sum, "{0:n" & Val(i) & "}")
                Next

            End If
            If DenyEditFieldNames <> Nothing Then
                Dim FieldName = DenyEditFieldNames.Split(",")
                For Each i In FieldName
                    .Columns(i).OptionsColumn.AllowEdit = False
                Next
            End If


            .BestFitColumns()
        End With


    End Sub



End Module
