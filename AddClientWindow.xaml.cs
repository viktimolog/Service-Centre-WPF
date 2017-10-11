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
    /// Логика взаимодействия для AddClientWindow.xaml
    /// </summary>
    public partial class AddClientWindow : Window
    {
        private Client newClient;
        public AddClientWindow(Client newClient)
        {
            InitializeComponent();
            this.newClient = newClient;
        }

        private void bt_SaveAddClient_Click(object sender, RoutedEventArgs e)
        {
            newClient.NameClient = textBox_nameClientAddClient.Text;
            newClient.Contact = textBox_ContactAddClient.Text;
            newClient.Phone = textBox_PhoneAddClient.Text;
            newClient.Address = textBox_AddressAddClient.Text;
            newClient.Email = textBox_EmailAddClient.Text;
            try
            {
                (new SQLActions()).AddClient(textBox_nameClientAddClient.Text, textBox_ContactAddClient.Text, textBox_PhoneAddClient.Text, textBox_AddressAddClient.Text, textBox_EmailAddClient.Text);
                MessageBox.Show("Новый клиент: " + textBox_nameClientAddClient.Text + " успешно добавлен!", "Успешное добавление клиента");
            }
            catch
            {
                MessageBox.Show("Not connected to DB", "Error");
            }
            Close();
        }
    }
}
