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

namespace ServiceCentreWPF
{
    /// <summary>
    /// Логика взаимодействия для EditBrandWindow.xaml
    /// </summary>
    public partial class EditBrandWindow : Window
    {
        List<string> brands;
        List<string> categoriesBrands;
        public EditBrandWindow()
        {
            InitializeComponent();
            brands = new List<string>();
            categoriesBrands = new List<string>();
        }

        private void bt_SaveEditBrand_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int i = comboBox_BrandsEditBrand.SelectedIndex;
                (new SQLActions()).EditBrand(brands[i], categoriesBrands[i], textBox_nameBrandEditBrand.Text, comboBox_CategoriesEditBrand.Text);
                MessageBox.Show("Бренд успешно изменен!");
            }
            catch
            {
                MessageBox.Show("Not connected to DB", "Error");
            }
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            textBox_nameBrandEditBrand.IsEnabled = false;
            bt_SaveEditBrand.IsEnabled = false;
            comboBox_CategoriesEditBrand.IsEnabled = false;

            (new SQLActions()).getAllBrendsWithCategories(brands, categoriesBrands);
            for (int i = 0; i < brands.Count; i++)
            {
                comboBox_BrandsEditBrand.Items.Add(brands[i] + " - " + categoriesBrands[i]);
            }
            comboBox_BrandsEditBrand.SelectedIndex = 0;

            List<string> categories = new List<string>();
            categories = (new SQLActions()).getCategories();
            for (int i = 0; i < categories.Count; i++)
            {
                comboBox_CategoriesEditBrand.Items.Add(categories[i]);
            }
            comboBox_CategoriesEditBrand.SelectedIndex = 0;
        }

        private void bt_EditEditBrand_Click(object sender, RoutedEventArgs e)
        {
            comboBox_CategoriesEditBrand.IsEnabled = true;
            textBox_nameBrandEditBrand.IsEnabled = true;
            textBox_nameBrandEditBrand.Text = brands[comboBox_BrandsEditBrand.SelectedIndex];
            comboBox_CategoriesEditBrand.Text = categoriesBrands[comboBox_BrandsEditBrand.SelectedIndex];
            bt_SaveEditBrand.IsEnabled = true;
        }
    }
}
