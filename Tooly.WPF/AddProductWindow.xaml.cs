using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Tooly.WPF
{
    /// <summary>
    /// Interaction logic for AddProductWindow.xaml
    /// </summary>
    public partial class AddProductWindow : Window
    {
        public AddProductWindow()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            string? name = nameTextBox.Text;
            string? category = categoryComboBox.SelectedValue.ToString();

            if(string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Naam mag niet leeg zijn.", "Fout", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if(string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Categorie mag niet leeg zijn.", "Fout", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }
    }
}
