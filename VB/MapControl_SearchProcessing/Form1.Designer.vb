Namespace MapControl_SearchProcessing

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.TilesLayer = New DevExpress.XtraMap.ImageLayer()
            Me.BingMapDataProvider = New DevExpress.XtraMap.BingMapDataProvider()
            Me.SearchLayer = New DevExpress.XtraMap.InformationLayer()
            Me.SearchProvider = New DevExpress.XtraMap.BingSearchDataProvider()
            Me.mapControl = New DevExpress.XtraMap.MapControl()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.btnSearch = New DevExpress.XtraEditors.SimpleButton()
            Me.teKeyword = New DevExpress.XtraEditors.TextEdit()
            Me.meResult = New DevExpress.XtraEditors.MemoEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciSearchResults = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciKeyword = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.mapControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.teKeyword.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.meResult.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciSearchResults), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciKeyword), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' TilesLayer
            ' 
            Me.TilesLayer.DataProvider = Me.BingMapDataProvider
            ' 
            ' SearchLayer
            ' 
            Me.SearchLayer.DataProvider = Me.SearchProvider
            Me.SearchLayer.Name = "SearchLayer"
            ' 
            ' mapControl
            ' 
            Me.mapControl.Layers.Add(Me.TilesLayer)
            Me.mapControl.Layers.Add(Me.SearchLayer)
            Me.mapControl.Location = New System.Drawing.Point(6, 6)
            Me.mapControl.Name = "mapControl"
            Me.mapControl.ShowSearchPanel = False
            Me.mapControl.Size = New System.Drawing.Size(396, 316)
            Me.mapControl.TabIndex = 0
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.btnSearch)
            Me.layoutControl1.Controls.Add(Me.teKeyword)
            Me.layoutControl1.Controls.Add(Me.meResult)
            Me.layoutControl1.Controls.Add(Me.mapControl)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(638, 328)
            Me.layoutControl1.TabIndex = 1
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' btnSearch
            ' 
            Me.btnSearch.Location = New System.Drawing.Point(406, 30)
            Me.btnSearch.Name = "btnSearch"
            Me.btnSearch.Size = New System.Drawing.Size(226, 22)
            Me.btnSearch.StyleController = Me.layoutControl1
            Me.btnSearch.TabIndex = 7
            Me.btnSearch.Text = "Search"
            AddHandler Me.btnSearch.Click, New System.EventHandler(AddressOf Me.btnSearch_Click)
            ' 
            ' teKeyword
            ' 
            Me.teKeyword.Location = New System.Drawing.Point(484, 6)
            Me.teKeyword.Name = "teKeyword"
            Me.teKeyword.Size = New System.Drawing.Size(148, 20)
            Me.teKeyword.StyleController = Me.layoutControl1
            Me.teKeyword.TabIndex = 6
            ' 
            ' meResult
            ' 
            Me.meResult.Location = New System.Drawing.Point(406, 72)
            Me.meResult.Name = "meResult"
            Me.meResult.Size = New System.Drawing.Size(226, 250)
            Me.meResult.StyleController = Me.layoutControl1
            Me.meResult.TabIndex = 4
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.lciSearchResults, Me.lciKeyword, Me.layoutControlItem5})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(638, 328)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.mapControl
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(400, 320)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' lciSearchResults
            ' 
            Me.lciSearchResults.Control = Me.meResult
            Me.lciSearchResults.Location = New System.Drawing.Point(400, 50)
            Me.lciSearchResults.Name = "lciSearchResults"
            Me.lciSearchResults.Size = New System.Drawing.Size(230, 270)
            Me.lciSearchResults.Text = "Search Results:"
            Me.lciSearchResults.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciSearchResults.TextSize = New System.Drawing.Size(75, 13)
            ' 
            ' lciKeyword
            ' 
            Me.lciKeyword.Control = Me.teKeyword
            Me.lciKeyword.Location = New System.Drawing.Point(400, 0)
            Me.lciKeyword.Name = "lciKeyword"
            Me.lciKeyword.Size = New System.Drawing.Size(230, 24)
            Me.lciKeyword.Text = "Keyword:"
            Me.lciKeyword.TextSize = New System.Drawing.Size(75, 13)
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.btnSearch
            Me.layoutControlItem5.Location = New System.Drawing.Point(400, 24)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(230, 26)
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(638, 328)
            Me.Controls.Add(Me.layoutControl1)
            Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None
            Me.Name = "Form1"
            Me.Text = "Search Result Processing Example"
            CType((Me.mapControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.teKeyword.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.meResult.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciSearchResults), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciKeyword), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private mapControl As DevExpress.XtraMap.MapControl

        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private btnSearch As DevExpress.XtraEditors.SimpleButton

        Private teKeyword As DevExpress.XtraEditors.TextEdit

        Private meResult As DevExpress.XtraEditors.MemoEdit

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private lciSearchResults As DevExpress.XtraLayout.LayoutControlItem

        Private lciKeyword As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private TilesLayer As DevExpress.XtraMap.ImageLayer

        Private BingMapDataProvider As DevExpress.XtraMap.BingMapDataProvider

        Private SearchLayer As DevExpress.XtraMap.InformationLayer

        Private SearchProvider As DevExpress.XtraMap.BingSearchDataProvider
    End Class
End Namespace
