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
using System.Data.Entity;
using Products.Model;


namespace Products
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ProductDataBaseEntities1 db = new ProductDataBaseEntities1();
    
        public MainWindow()
        {
            InitializeComponent();
            db.ProductTableSet.Load();
            BaseGrid.ItemsSource = db.ProductTableSet.Local;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            db.ProductTableSet.Add(new ProductTableSet()
            {
                Quantity = bxDescription.Text,
                Id = Convert.ToInt32(bxId.Text),
                Description = bxDescription.Text
            });
            db.SaveChanges();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            db.SaveChanges();
        }
    }
}
