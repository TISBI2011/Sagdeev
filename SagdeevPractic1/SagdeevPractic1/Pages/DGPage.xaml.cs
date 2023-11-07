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

namespace SagdeevPractic1.Pages
{
    /// <summary>
    /// Логика взаимодействия для DGPage.xaml
    /// </summary>
    public partial class DGPage : Page
    {
        public DGPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DGPCs.ItemsSource = App.DB.Computer.ToList();
            DGPCs.Columns.Add(new DataGridTextColumn { Header = "IP", Binding = new Binding("Ip") });
            DGPCs.Columns.Add(new DataGridTextColumn { Header = "Class", Binding = new Binding("ClassId") });
            DGPCs.Columns.Add(new DataGridTextColumn { Header = "State", Binding = new Binding("State") });
        }
    }
}
