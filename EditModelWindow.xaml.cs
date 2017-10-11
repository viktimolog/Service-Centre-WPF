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
    /// Логика взаимодействия для EditModelWindow.xaml
    /// </summary>
    public partial class EditModelWindow : Window
    {
        private Controller controller;
        private SQLActions sql;
        public EditModelWindow()
        {
            InitializeComponent();
            //controller = new Controller();
            sql = new SQLActions();
        }

        public void LoadCategories()
        {
            comboBox_CategoriesEditModel.ItemsSource = null;
            //Load Categories
            List<Category> categories = sql.getCategoriesAll();
            categories.Sort();

            comboBox_CategoriesEditModel.ItemsSource = categories;
            comboBox_CategoriesEditModel.DisplayMemberPath = "NameCategory";
            comboBox_CategoriesEditModel.SelectedIndex = 0;
            //    if (device != null) comboBox_CategoriesAddRepair.Text = device.Category;
            categories = null;
        }

        public void loadEditModelWindow()
        {
            LoadCategories();


            textBox_newNameModelEditModel.Text = comboBox_ModelEditModel.Text;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            loadEditModelWindow();
        }

        private void comboBox_CategoriesEditModel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<Brand> brands;

            Category cat = (Category)comboBox_CategoriesEditModel.SelectedItem;

            try
            {
                brands = sql.getBrandsByCategoryAll(cat.NameCategory);
            }
            catch
            {
                brands = sql.getBrandsByCategoryAll(comboBox_CategoriesEditModel.Text);
            }

            brands.Sort();

            comboBox_BrandsEditModel.ItemsSource = brands;
            if (brands.Count < 1) comboBox_ModelEditModel.ItemsSource = brands;
            comboBox_BrandsEditModel.DisplayMemberPath = "NameBrand";
            comboBox_BrandsEditModel.SelectedIndex = 0;

            textBox_newNameModelEditModel.Text = comboBox_ModelEditModel.Text;
        }

        private void comboBox_BrandsEditModel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            List<Model> models;

            Brand brand = (Brand)comboBox_BrandsEditModel.SelectedItem;

            Category cat = (Category)comboBox_CategoriesEditModel.SelectedItem;

            try
            {
                models = sql.getModelByCategoryAndBrandAll(cat.NameCategory, brand.NameBrand);
            }
            catch
            {
                models = sql.getModelByCategoryAndBrandAll(comboBox_CategoriesEditModel.Text, comboBox_BrandsEditModel.Text);
            }

            models.Sort();

            comboBox_ModelEditModel.ItemsSource = models;
            comboBox_ModelEditModel.DisplayMemberPath = "NameModel";
            comboBox_ModelEditModel.SelectedIndex = 0;

            textBox_newNameModelEditModel.Text = comboBox_ModelEditModel.Text;
        }

        private void comboBox_ModelEditModel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {

                textBox_newNameModelEditModel.Text = ((Model)comboBox_ModelEditModel.SelectedItem).NameModel;
            }
            catch
            {

                textBox_newNameModelEditModel.Text = comboBox_ModelEditModel.Text;
            }
        }

        private void bt_SaveEditModel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bool ok = (new SQLActions()).EditModel(comboBox_ModelEditModel.Text, textBox_newNameModelEditModel.Text, comboBox_CategoriesEditModel.Text, comboBox_BrandsEditModel.Text);
                if (ok) MessageBox.Show("Данные модели успешно изменены!");
                else MessageBox.Show("Такая модель уже существует!");
            }
            catch
            {
                MessageBox.Show("Not connected to DB", "Error");
            }
            Close();
        }
    }
}
