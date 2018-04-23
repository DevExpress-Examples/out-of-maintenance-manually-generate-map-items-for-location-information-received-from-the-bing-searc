namespace MapControl_SearchProcessing {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.TilesLayer = new DevExpress.XtraMap.ImageLayer();
            this.BingMapDataProvider = new DevExpress.XtraMap.BingMapDataProvider();
            this.SearchLayer = new DevExpress.XtraMap.InformationLayer();
            this.SearchProvider = new DevExpress.XtraMap.BingSearchDataProvider();
            this.mapControl = new DevExpress.XtraMap.MapControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.teKeyword = new DevExpress.XtraEditors.TextEdit();
            this.meResult = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSearchResults = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciKeyword = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teKeyword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meResult.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSearchResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciKeyword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // TilesLayer
            // 
            this.TilesLayer.DataProvider = this.BingMapDataProvider;
            // 
            // SearchLayer
            // 
            this.SearchLayer.DataProvider = this.SearchProvider;
            this.SearchLayer.Name = "SearchLayer";
            // 
            // mapControl
            // 
            this.mapControl.Layers.Add(this.TilesLayer);
            this.mapControl.Layers.Add(this.SearchLayer);
            this.mapControl.Location = new System.Drawing.Point(6, 6);
            this.mapControl.Name = "mapControl";
            this.mapControl.ShowSearchPanel = false;
            this.mapControl.Size = new System.Drawing.Size(396, 316);
            this.mapControl.TabIndex = 0;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnSearch);
            this.layoutControl1.Controls.Add(this.teKeyword);
            this.layoutControl1.Controls.Add(this.meResult);
            this.layoutControl1.Controls.Add(this.mapControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(638, 328);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(406, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(226, 22);
            this.btnSearch.StyleController = this.layoutControl1;
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // teKeyword
            // 
            this.teKeyword.Location = new System.Drawing.Point(484, 6);
            this.teKeyword.Name = "teKeyword";
            this.teKeyword.Size = new System.Drawing.Size(148, 20);
            this.teKeyword.StyleController = this.layoutControl1;
            this.teKeyword.TabIndex = 6;
            // 
            // meResult
            // 
            this.meResult.Location = new System.Drawing.Point(406, 72);
            this.meResult.Name = "meResult";
            this.meResult.Size = new System.Drawing.Size(226, 250);
            this.meResult.StyleController = this.layoutControl1;
            this.meResult.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.lciSearchResults,
            this.lciKeyword,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlGroup1.Size = new System.Drawing.Size(638, 328);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.mapControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(400, 320);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // lciSearchResults
            // 
            this.lciSearchResults.Control = this.meResult;
            this.lciSearchResults.Location = new System.Drawing.Point(400, 50);
            this.lciSearchResults.Name = "lciSearchResults";
            this.lciSearchResults.Size = new System.Drawing.Size(230, 270);
            this.lciSearchResults.Text = "Search Results:";
            this.lciSearchResults.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciSearchResults.TextSize = new System.Drawing.Size(75, 13);
            // 
            // lciKeyword
            // 
            this.lciKeyword.Control = this.teKeyword;
            this.lciKeyword.Location = new System.Drawing.Point(400, 0);
            this.lciKeyword.Name = "lciKeyword";
            this.lciKeyword.Size = new System.Drawing.Size(230, 24);
            this.lciKeyword.Text = "Keyword:";
            this.lciKeyword.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnSearch;
            this.layoutControlItem5.Location = new System.Drawing.Point(400, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(230, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 328);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.Name = "Form1";
            this.Text = "Search Result Processing Example";
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teKeyword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meResult.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSearchResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciKeyword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraMap.MapControl mapControl;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit teKeyword;
        private DevExpress.XtraEditors.MemoEdit meResult;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem lciSearchResults;
        private DevExpress.XtraLayout.LayoutControlItem lciKeyword;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraMap.ImageLayer TilesLayer;
        private DevExpress.XtraMap.BingMapDataProvider BingMapDataProvider;
        private DevExpress.XtraMap.InformationLayer SearchLayer;
        private DevExpress.XtraMap.BingSearchDataProvider SearchProvider;
    }
}

