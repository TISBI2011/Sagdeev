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
using SagdeevPractic1.Models;

namespace SagdeevPractic1.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        Computer contextComputer;
        public AddPage()
        {
            InitializeComponent();
            ClassCB.ItemsSource = App.DB.Class.ToList();
            contextComputer = new Computer();
            DataContext = contextComputer;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            contextComputer.State = StateCB.Text;
            App.DB.Computer.Add(contextComputer);
            App.DB.SaveChanges();
            NavigationService.Navigate(new DGPage());
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
