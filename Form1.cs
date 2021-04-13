using SfDataGrid_Demo;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Enums;
using System.Drawing;

namespace SfDataGrid_Demo
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor

        /// <summary>
        /// Initializes the new instance for the Form.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            sfDataGrid1.DataSource = new OrderInfoCollection().OrdersListDetails;
            sfDataGrid1.SelectionChanging += OnSfDataGrid1_SelectionChanging;
            sfDataGrid1.CurrentCellActivating += OnSfDataGrid1_CurrentCellActivating;
        }

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

        #endregion
    }
}
