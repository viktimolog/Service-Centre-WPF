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
    /// Логика взаимодействия для AddBrandWindow.xaml
    /// </summary>
    public partial class AddBrandWindow : Window
    {
        private Device device;
        private SQLActions sql;
        public AddBrandWindow(Device device = null)
        {
            InitializeComponent();
            this.device = device;
            sql = new SQLActions();
        }

        private void bt_AddBrandAddBrand_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (device == null) device = new Device();
                device.Brand = textBox1AddBrand.Text;
                sql.AddBrand(textBox1AddBrand.Text, comboBox_CategoriesAddBrand.Text);
                MessageBox.Show("Добавлен новый бренд: " + textBox1AddBrand.Text + " в категории " + comboBox_CategoriesAddBrand.Text, "Успешное добавление бренда");
            }
            catch
            {
                MessageBox.Show("Not connected to DB", "Error");
            }
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Load Categories
            List<Category> categories = sql.getCategoriesAll();
            categories.Sort();

            comboBox_CategoriesAddBrand.ItemsSource = categories;
            comboBox_CategoriesAddBrand.SelectedIndex = 0;          
            if (device != null) comboBox_CategoriesAddBrand.Text = device.Category;
        }
    }
}
