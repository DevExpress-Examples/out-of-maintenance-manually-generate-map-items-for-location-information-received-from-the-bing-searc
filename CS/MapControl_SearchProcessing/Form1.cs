using System.Windows.Forms;
using DevExpress.XtraMap;

namespace MapControl_SearchProcessing {
    public partial class Form1 : Form {
        InformationLayer SearchLayer { get { return (InformationLayer)mapControl1.Layers["SearchLayer"]; } }
        BingSearchDataProvider SearchProvider { get { return (BingSearchDataProvider)SearchLayer.DataProvider; } }

        public Form1() {
            InitializeComponent();
            SearchProvider.SearchCompleted += SearchProvider_SearchCompleted;
            SearchLayer.DataRequestCompleted += SearchLayer_DataRequestCompleted;
        }

        void SearchLayer_DataRequestCompleted(object sender, RequestCompletedEventArgs e) {
            mapControl1.ZoomToFitLayerItems();
        }

        void SearchProvider_SearchCompleted(object sender, BingSearchCompletedEventArgs e) {
            if (e.Cancelled) return;
            if (e.RequestResult.ResultCode != RequestResultCode.Success) return;

            SearchLayer.Data.Items.Clear();
            if (e.RequestResult.SearchResults.Count != 0)
                foreach (LocationInformation locationInformation 
                    in e.RequestResult.SearchResults)
                    AddMapCallout(locationInformation);
            else
                AddMapCallout(e.RequestResult.SearchRegion);

        }

        void AddMapCallout(LocationInformation locationInformation) {
            SearchLayer.Data.Items.Add(new MapCallout() {
                Location = locationInformation.Location,
                Text = locationInformation.DisplayName
            });
        }
    }
}
