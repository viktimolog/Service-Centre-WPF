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
    /// Логика взаимодействия для EditClientWindow.xaml
    /// </summary>
    public partial class EditClientWindow : Window
    {
        private Client client;
        private List<Client> clients;
        private SQLActions sql;
        public List<Client> Clients { get { return clients; } }
        public EditClientWindow(Client client = null)
        {
            InitializeComponent();
            this.client = client;
            clients = new List<Client>();
            sql = new SQLActions();
        }

        public void textsforTextboxes(Client client)
        {
            textBox_ContactEditClient.Text = client.Contact;
            textBox_PhoneEditClient.Text = client.Phone;
            textBox_AddressEditClient.Text = client.Address;
            textBox_EmailEditClient.Text = client.Email;
            textBox_NewNameClientEditClient.Text = client.NameClient;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            comboBox_nameClientEditClient.ItemsSource = sql.getClients();
            comboBox_nameClientEditClient.DisplayMemberPath = "NameClient";
            comboBox_nameClientEditClient.SelectedIndex = 0;

            if (client != null) comboBox_nameClientEditClient.Text = client.NameClient;
            else comboBox_nameClientEditClient.SelectedIndex = 0;

            textsforTextboxes((Client)comboBox_nameClientEditClient.SelectedItem);
        }

        private void comboBox_nameClientEditClient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            textsforTextboxes((Client)comboBox_nameClientEditClient.SelectedItem);
        }

        private void bt_SaveEditClient_Click(object sender, RoutedEventArgs e)
        {
            if (client == null) client = new Client();
            client.NameClient = textBox_NewNameClientEditClient.Text;
            client.Contact = textBox_ContactEditClient.Text;
            client.Phone = textBox_PhoneEditClient.Text;
            client.Address = textBox_AddressEditClient.Text;
            client.Email = textBox_EmailEditClient.Text;
            try
            {
                (new SQLActions()).EditClient(comboBox_nameClientEditClient.Text, textBox_NewNameClientEditClient.Text, textBox_ContactEditClient.Text, textBox_PhoneEditClient.Text,
                    textBox_AddressEditClient.Text, textBox_EmailEditClient.Text);
                MessageBox.Show("Данные клиента успешно изменены!");
            }
            catch
            {
                MessageBox.Show("Not connected to DB", "Error");
            }
            Close();
        }
    }
}
