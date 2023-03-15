using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace syncfusion_wpf_app_datagrid
{
    /// <summary>
    /// Interaction logic for Datagrid1.xaml
    /// </summary>
    public partial class Datagrid1 : UserControl
    {
        public Datagrid1()
        {
            InitializeComponent();
            datagrid.AutoGeneratingColumn += DataGrid1_AutoGeneratingColumn;
        }

        private void DataGrid1_AutoGeneratingColumn(object? sender, AutoGeneratingColumnArgs e)
        {
            e.Column.TextAlignment= TextAlignment.Center;
            e.Column.VerticalAlignment = VerticalAlignment.Center;
        }
    }
}
