using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace PassengerTransportCompany
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DatabaseContext databaseContext;

        public MainWindow()
        {
            InitializeComponent();

            databaseContext = new DatabaseContext();
            databaseContext.Employees.Load();
            phonesGrid.ItemsSource = databaseContext.Employees.Local.ToBindingList();

            Closing += MainWindow_Closing;
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            databaseContext?.Dispose();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            databaseContext?.SaveChanges();
        }
    }
}
