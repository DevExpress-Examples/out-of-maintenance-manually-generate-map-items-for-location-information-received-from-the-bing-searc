Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace MapControl_SearchProcessing
    Partial Public Class Form1
        Inherits Form

        Private ReadOnly Property SearchLayer() As InformationLayer
            Get
                Return CType(mapControl1.Layers("SearchLayer"), InformationLayer)
            End Get
        End Property
        Private ReadOnly Property SearchProvider() As BingSearchDataProvider
            Get
                Return CType(SearchLayer.DataProvider, BingSearchDataProvider)
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            AddHandler SearchProvider.SearchCompleted, AddressOf SearchProvider_SearchCompleted
            AddHandler SearchLayer.DataRequestCompleted, AddressOf SearchLayer_DataRequestCompleted
        End Sub

        Private Sub SearchLayer_DataRequestCompleted(ByVal sender As Object, ByVal e As RequestCompletedEventArgs)
            mapControl1.ZoomToFitLayerItems()
        End Sub

        Private Sub SearchProvider_SearchCompleted(ByVal sender As Object, ByVal e As BingSearchCompletedEventArgs)
            If e.Cancelled Then
                Return
            End If
            If e.RequestResult.ResultCode <> RequestResultCode.Success Then
                Return
            End If

            SearchLayer.Data.Items.Clear()
            If e.RequestResult.SearchResults.Count <> 0 Then
                For Each locationInformation As LocationInformation In e.RequestResult.SearchResults
                    AddMapCallout(locationInformation)
                Next locationInformation
            Else
                AddMapCallout(e.RequestResult.SearchRegion)
            End If

        End Sub

        Private Sub AddMapCallout(ByVal locationInformation As LocationInformation)
            SearchLayer.Data.Items.Add(New MapCallout() With {.Location = locationInformation.Location, .Text = locationInformation.DisplayName})
        End Sub
    End Class
End Namespace
