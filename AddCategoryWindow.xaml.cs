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
    /// Логика взаимодействия для AddCategoryWindow.xaml
    /// </summary>
    public partial class AddCategoryWindow : Window
    {
        private Device device;
        private SQLActions sql;
        public AddCategoryWindow(Device device = null)
        {
            InitializeComponent();
            this.device = device;
            sql = new SQLActions();
        }

        private void button1AddCategory_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (device == null) device = new Device();
                device.Category = textBox1AddCategory.Text;
                (new SQLActions()).AddCategory(textBox1AddCategory.Text);
                MessageBox.Show("Добавлена новая категория: " + textBox1AddCategory.Text, "Успешное добавление категории");
            }
            catch
            {
                MessageBox.Show("Not connected to DB", "Error");
            }
            Close();
        }
    }
}
