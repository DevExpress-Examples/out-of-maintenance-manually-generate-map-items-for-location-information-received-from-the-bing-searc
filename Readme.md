<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128576873/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T188838)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/MapControl_SearchProcessing/Form1.cs) (VB: [Form1.vb](./VB/MapControl_SearchProcessing/Form1.vb))
* [Program.cs](./CS/MapControl_SearchProcessing/Program.cs) (VB: [Program.vb](./VB/MapControl_SearchProcessing/Program.vb))
<!-- default file list end -->
# Manually generate map items for location information received from the Bing Search provider


This example demonstrates how to manually process location information received from the Bing Search data provider.


<h3>Description</h3>

For this, create a&nbsp;<a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapBingSearchDataProvidertopic">BingSearchDataProvider</a> object, assign it to the&nbsp;<a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapInformationLayer_DataProvidertopic">InformationLayer.DataProvider</a> property and handle the&nbsp;object's <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingSearchDataProvider_SearchCompletedtopic">SearchCompleted</a> event. The event handler arguments has the&nbsp;<a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingSearchCompletedEventArgs_RequestResulttopic">RequestResult</a>&nbsp;property that stores a collection of&nbsp;<a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapSearchRequestResult_SearchResultstopic">SearchResults</a>&nbsp; represented by the&nbsp;<a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapLocationInformationtopic">LocationInformation</a>&nbsp;objects.

<br/>


