Imports DevExpress.XtraEditors
Imports DevExpress.XtraMap
Imports System
Imports System.Text

Namespace MapControl_SearchProcessing

    Public Partial Class Form1
        Inherits XtraForm

        Private ReadOnly Property BingKey As String
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

        Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs)
            SearchProvider.Search(teKeyword.Text)
        End Sub

#Region "#SearchResultProcessing"
        Private Sub OnSearchCompleted(ByVal sender As Object, ByVal e As BingSearchCompletedEventArgs)
            If e.Cancelled Then Return
            If e.RequestResult.ResultCode <> RequestResultCode.Success Then
                meResult.Text = "The Bing Search service does not work for this location."
                Return
            End If

            Dim resultList As StringBuilder = New StringBuilder("")
            Dim resCounter As Integer = 1
            For Each resultInfo As BingLocationInformation In e.RequestResult.SearchResults
                resultList.Append(String.Format("Result {0}:  " & Microsoft.VisualBasic.Constants.vbCrLf, resCounter))
                resultList.Append(String.Format("Name: {0}" & Microsoft.VisualBasic.Constants.vbCrLf, resultInfo.DisplayName))
                resultList.Append(String.Format("Address: {0}" & Microsoft.VisualBasic.Constants.vbCrLf, resultInfo.Address.FormattedAddress))
                resultList.Append(String.Format("Confidence level: {0}" & Microsoft.VisualBasic.Constants.vbCrLf, resultInfo.Confidence))
                resultList.Append(String.Format("Geographic coordinates:  {0}" & Microsoft.VisualBasic.Constants.vbCrLf, resultInfo.Location))
                resultList.Append(String.Format("Match code: {0}" & Microsoft.VisualBasic.Constants.vbCrLf, resultInfo.MatchCode))
                resultList.Append(String.Format("______________________________" & Microsoft.VisualBasic.Constants.vbCrLf))
                resCounter += 1
            Next

            meResult.Text = resultList.ToString()
        End Sub

#End Region  ' #SearchResultProcessing
        Private Sub OnDataRequestCompleted(ByVal sender As Object, ByVal e As RequestCompletedEventArgs)
            mapControl.ZoomToFitLayerItems(0.4)
        End Sub
    End Class
End Namespace
