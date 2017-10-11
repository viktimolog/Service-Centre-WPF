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
    /// Логика взаимодействия для AddModelWindow.xaml
    /// </summary>
    public partial class AddModelWindow : Window
    {
        private Device device;
        private SQLActions sql;
        public AddModelWindow(Device device = null)
        {
            InitializeComponent();
            this.device = device;
            sql = new SQLActions();
        }

        private void bt_AddModel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (device == null) device = new Device();
                device.Category = comboBox_CategoriesAddModel.Text;
                device.Brand = comboBox_BrandsAddModel.Text;
                device.Model = textBox1AddModel.Text;
                (new SQLActions()).AddModel(textBox1AddModel.Text, comboBox_BrandsAddModel.Text, comboBox_CategoriesAddModel.Text);
                MessageBox.Show("Добавлена новая модель: " + textBox1AddModel.Text + " бренда " + comboBox_BrandsAddModel.Text + " в категории " + comboBox_CategoriesAddModel.Text, "Успешное добавление модели");
            }
            catch
            {
                MessageBox.Show("Not connected to DB", "Error");
            }
            Close();
        }

        private void comboBox_CategoriesAddModel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Category cat = (Category)comboBox_CategoriesAddModel.SelectedItem;//вытащили из нового значения категории ее название, comboBox_CategoriesAddModel.Text возвращает предыдущее значение!!!
            
            List<Brand> brands = sql.getBrandsByCategoryAll(cat.NameCategory);
            brands.Sort();

            comboBox_BrandsAddModel.ItemsSource = brands;
            comboBox_BrandsAddModel.DisplayMemberPath = "NameBrand";
            comboBox_BrandsAddModel.SelectedIndex = 0;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Load Categories
            List<Category> categories = sql.getCategoriesAll();
            categories.Sort();

            comboBox_CategoriesAddModel.ItemsSource = categories;
            comboBox_CategoriesAddModel.DisplayMemberPath = "NameCategory";
            comboBox_CategoriesAddModel.SelectedIndex = 0;
            if (device != null) comboBox_CategoriesAddModel.Text = device.Category;


            //Load BrandsByCategory
            List<Brand>brands = sql.getBrandsByCategoryAll(comboBox_CategoriesAddModel.Text);
            brands.Sort();

            comboBox_BrandsAddModel.ItemsSource = brands;
            comboBox_BrandsAddModel.DisplayMemberPath = "NameBrand";
            comboBox_BrandsAddModel.SelectedIndex = 0;
            if (device != null) comboBox_BrandsAddModel.Text = device.Brand;
        }
    }
}
