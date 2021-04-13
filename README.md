# How to make DataGrid to allow only a specific number of items to be selected

## About the sample

This sample illustrates how to make DataGrid to allow only a specific number of items to be selected.

[WinForms DataGrid](https://www.syncfusion.com/winforms-ui-controls/datagrid) (SfDataGrid) allows you to select multiple rows or cells by setting the [SelectionMode](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.DataGrid.SfDataGrid.html#Syncfusion_WinForms_DataGrid_SfDataGrid_SelectionMode) property as  Multiple. You can make SfDataGrid to allow only a specific number of items to be selected by using the [SfDataGrid.SelectionChanging](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.DataGrid.SfDataGrid.html#Syncfusion_WinForms_DataGrid_SfDataGrid_SelectionChanging) and [SfDataGrid.CurrentCellActivating](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.DataGrid.SfDataGrid.html#Syncfusion_WinForms_DataGrid_SfDataGrid_CurrentCellActivating) events.

```C#

sfDataGrid1.SelectionChanging += OnSfDataGrid1_SelectionChanging;
sfDataGrid1.CurrentCellActivating += OnSfDataGrid1_CurrentCellActivating;

private void OnSfDataGrid1_CurrentCellActivating(object sender, Syncfusion.WinForms.DataGrid.Events.CurrentCellActivatingEventArgs e)
{
    if ((sender as SfDataGrid).SelectedItems.Count == 2 && !(sender as SfDataGrid).SelectedItems.Contains(e.DataRow.RowData))
        e.Cancel = true;
}

private void OnSfDataGrid1_SelectionChanging(object sender, Syncfusion.WinForms.DataGrid.Events.SelectionChangingEventArgs e)
{
    if (e.RemovedItems.Count ==0 && (sender as SfDataGrid).SelectedItems.Count == 2)
        e.Cancel = true;
}

```

## Requirements to run the demo

Visual Studio 2015 and above versions
