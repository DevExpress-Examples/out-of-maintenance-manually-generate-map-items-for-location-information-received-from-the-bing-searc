Imports DevExpress.XtraEditors
Imports DevExpress.XtraMap
Imports System
Imports System.Text

Namespace MapControl_SearchProcessing
    Partial Public Class Form1
        Inherits XtraForm

        Private ReadOnly Property BingKey() As String
            Get
                Return "YourBingKey"
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            AddHandler SearchProvider.SearchCompleted, AddressOf OnSearchCompleted
            AddHandler SearchLayer.DataRequestCompleted, AddressOf OnDataRequestCompleted
            BingMapDataProvider.BingKey = BingKey
            SearchProvider.BingKey = BingKey
        End Sub

        Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
            SearchProvider.Search(teKeyword.Text)
        End Sub

        #Region "#SearchResultProcessing"
        Private Sub OnSearchCompleted(ByVal sender As Object, ByVal e As BingSearchCompletedEventArgs)
            If e.Cancelled Then
                Return
            End If
            If e.RequestResult.ResultCode <> RequestResultCode.Success Then
                meResult.Text = "The Bing Search service does not work for this location."
                Return
            End If

            Dim resultList As New StringBuilder("")
            Dim resCounter As Integer = 1
            For Each resultInfo As BingLocationInformation In e.RequestResult.SearchResults
                resultList.Append(String.Format("Result {0}:  " & ControlChars.CrLf, resCounter))
                resultList.Append(String.Format("Name: {0}" & ControlChars.CrLf, resultInfo.DisplayName))
                resultList.Append(String.Format("Address: {0}" & ControlChars.CrLf, resultInfo.Address.FormattedAddress))
                resultList.Append(String.Format("Confidence level: {0}" & ControlChars.CrLf, resultInfo.Confidence))
                resultList.Append(String.Format("Geographic coordinates:  {0}" & ControlChars.CrLf, resultInfo.Location))
                resultList.Append(String.Format("Match code: {0}" & ControlChars.CrLf, resultInfo.MatchCode))
                resultList.Append(String.Format("______________________________" & ControlChars.CrLf))
                resCounter += 1
            Next resultInfo
            meResult.Text = resultList.ToString()
        End Sub
        #End Region ' #SearchResultProcessing

        Private Sub OnDataRequestCompleted(ByVal sender As Object, ByVal e As RequestCompletedEventArgs)
            mapControl.ZoomToFitLayerItems(0.4)
        End Sub
    End Class
End Namespace
