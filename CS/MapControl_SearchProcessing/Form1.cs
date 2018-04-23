using DevExpress.XtraEditors;
using DevExpress.XtraMap;
using System;
using System.Text;

namespace MapControl_SearchProcessing {
    public partial class Form1 : XtraForm {
        
        string BingKey { get { return "YourBingKey"; } }

        public Form1() {
            InitializeComponent();
            SearchProvider.SearchCompleted += OnSearchCompleted;
            SearchLayer.DataRequestCompleted += OnDataRequestCompleted;
            BingMapDataProvider.BingKey = BingKey;
            SearchProvider.BingKey = BingKey;
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            SearchProvider.Search(teKeyword.Text);
        }

        #region #SearchResultProcessing
        void OnSearchCompleted(object sender, BingSearchCompletedEventArgs e) {
            if(e.Cancelled) return;
            if(e.RequestResult.ResultCode != RequestResultCode.Success) {
                meResult.Text = "The Bing Search service does not work for this location.";
                return;
            }

            StringBuilder resultList = new StringBuilder("");
            int resCounter = 1;
            foreach(BingLocationInformation resultInfo in e.RequestResult.SearchResults) {
                resultList.Append(String.Format("Result {0}:  \r\n", resCounter));
                resultList.Append(String.Format("Name: {0}\r\n", resultInfo.DisplayName));              
                resultList.Append(String.Format("Address: {0}\r\n", resultInfo.Address.FormattedAddress));
                resultList.Append(String.Format("Confidence level: {0}\r\n", resultInfo.Confidence));
                resultList.Append(String.Format("Geographic coordinates:  {0}\r\n", resultInfo.Location));
                resultList.Append(String.Format("Match code: {0}\r\n", resultInfo.MatchCode));
                resultList.Append(String.Format("______________________________\r\n"));
                resCounter++;
            }
            meResult.Text = resultList.ToString();
        }
        #endregion #SearchResultProcessing

        void OnDataRequestCompleted(object sender, RequestCompletedEventArgs e) {
            mapControl.ZoomToFitLayerItems(0.4);
        }
    }
}
