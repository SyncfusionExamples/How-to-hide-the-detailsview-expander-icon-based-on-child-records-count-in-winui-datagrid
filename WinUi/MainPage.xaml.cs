using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Syncfusion.UI.Xaml.Data;
using Syncfusion.UI.Xaml.DataGrid;
using System.Reflection;
using System.Globalization;
using Windows.Storage;
using System.Collections.ObjectModel;
using Microsoft.UI;
using WinUIDemoApp.Model;
// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUIDemoApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();
            dataGrid.DetailsViewExpanding += DataGrid_DetailsViewExpanding;
            dataGrid.QueryDetailsViewExpanderState += DataGrid_QueryDetailsViewExpanderState;
        }

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
    }
}
