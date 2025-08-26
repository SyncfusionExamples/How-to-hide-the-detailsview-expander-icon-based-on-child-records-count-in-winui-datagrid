# How to hide the detailsview expander icon based on child records count in WinUI DataGrid

This example describes how to hide the detailsview expander icon based on child records count in [WinUI DataGrid](https://www.syncfusion.com/winui-controls/datagrid) (SfDataGrid).

By default, the state of expander icon is visible for all the data rows in parent DataGrid even if its `RelationalColumn` property has an empty collection or null.

You can customize hiding the details view expander icon by handling the `SfDataGrid.QueryDetailsViewExpanderState` event. This event occurs when expander icon is changed on expanding or collapsing the details view. You can hide the expander icon by setting the `ExpanderVisibility` property to `false` in the `SfDataGrid.QueryDetailsViewExpanderState` event based on condition.

``` csharp
dataGrid.DetailsViewExpanding += DataGrid_DetailsViewExpanding;
dataGrid.QueryDetailsViewExpanderState += DataGrid_QueryDetailsViewExpanderState;

private void DataGrid_DetailsViewExpanding(object sender, GridDetailsViewExpandingEventArgs e)
{
    var employeeInfo = e.Record as Employee;
    if (employeeInfo != null)
    {
        if (employeeInfo.Sales.Count == 0)
            e.Cancel = true;
    }
}

private void DataGrid_QueryDetailsViewExpanderState(object sender, QueryDetailsViewExpanderStateEventArgs e)
{
    var employeeInfo = e.Record as Employee;
    if (employeeInfo != null)
    {
        if (employeeInfo.Sales.Count == 0)
        {
            e.ExpanderVisibility = false;
        }
    }
}
```

The following screenshot illustrates hiding expander icon state based on child items count.

![hide the detailsview expander](hide_the_detailsview_expander_icon.png)