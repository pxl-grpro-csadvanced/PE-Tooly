using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tooly.WPF.Models;
using Tooly.WPF.Repositories;

namespace Tooly.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ProductRepository _productRepository;

        public MainWindow()
        {
            InitializeComponent();

            _productRepository = new ProductRepository();
            RefreshProductData();
        }

        private void RefreshProductData()
        {
            productsListBox.Items.Clear();
            foreach(Product p in _productRepository.GetAll())
            {
                productsListBox.Items.Add(p);
            }
        }

        private void productsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(productsListBox.SelectedItem is Product selectedProduct)
            {
                nameTextBox.Text = selectedProduct.Name;
                categoryTextBox.Text = selectedProduct.Category;
            }
            else
            {
                nameTextBox.Clear();
                categoryTextBox.Clear();
            }
        }

        private void addProductButton_Click(object sender, RoutedEventArgs e)
        {
            AddProductWindow window = new AddProductWindow();
            window.ShowDialog();
        }
    }
}