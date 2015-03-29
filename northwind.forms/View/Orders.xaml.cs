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
using System.Windows.Shapes;

namespace Northwind.Forms.View
{
    /// <summary>
    /// Interaction logic for Orders.xaml
    /// </summary>
    public partial class Orders : Window
    {
        public Orders()
        {          
            InitializeComponent();
        }

        private void DataGridOrders_OnLoaded(object sender, RoutedEventArgs e)
        {
            OrderGridSettings();
            DetailGridSettings();
        }

        private void OrderGridSettings()
        {
            DataGridOrders.Columns[14].Visibility = Visibility.Hidden;
            DataGridOrders.Columns[15].Visibility = Visibility.Hidden;
            DataGridOrders.Columns[16].Visibility = Visibility.Hidden;
            DataGridOrders.Columns[17].Visibility = Visibility.Hidden;
        }

        private void DetailGridSettings()
        {
            DataGridOrderDetails.Columns[5].Visibility = Visibility.Hidden;
            DataGridOrderDetails.Columns[6].Visibility = Visibility.Hidden;
            
        }
    }


}
