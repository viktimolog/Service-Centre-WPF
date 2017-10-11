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
    /// Логика взаимодействия для EditCategoryWindow.xaml
    /// </summary>
    public partial class EditCategoryWindow : Window
    {
        public EditCategoryWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            textBox1EditCategory.IsEnabled = false;
            bt_SaveEditCategory.IsEnabled = false;

            List<string> categories = new List<string>();
            categories = (new SQLActions()).getCategories();
            for (int i = 0; i < categories.Count; i++)
            {
                comboBox1EditCategory.Items.Add(categories[i]);
            }
            comboBox1EditCategory.SelectedIndex = 0;
        }

        private void bt_EditEditCategory_Click(object sender, RoutedEventArgs e)
        {
            textBox1EditCategory.IsEnabled = true;
            bt_SaveEditCategory.IsEnabled = true;

            comboBox1EditCategory.IsEnabled = false;
            bt_EditEditCategory.IsEnabled = false;

            textBox1EditCategory.Text = comboBox1EditCategory.Text;
        }

        private void bt_SaveEditCategory_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                (new SQLActions()).EditCategory(comboBox1EditCategory.Text, textBox1EditCategory.Text);
                MessageBox.Show("Категория " + comboBox1EditCategory.Text + " изменена на " + textBox1EditCategory.Text, "Успешное изменение категории");
            }
            catch
            {
                MessageBox.Show("Not connected to DB", "Error");
            }
            Close();
        }
    }    
}
