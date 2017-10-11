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
    /// Логика взаимодействия для AddRepairWindow.xaml
    /// </summary>
    public partial class AddRepairWindow : Window
    {
        private Controller controller;
        private SQLActions sql;
        private Client client;
        private Device device;
        public AddRepairWindow()
        {
            InitializeComponent();
            controller = new Controller();
            sql = new SQLActions();
            client = null;
            device = null;
        }

        public void textsforTextboxes(Client client)
        {
            if (client == null) client = new Client();
            textBox_ContactAddRepair.Text = client.Contact;
            textBox_PhoneAddRepair.Text = client.Phone;
            textBox_AddressAddRepair.Text = client.Address;
            textBox_EmailAddRepair.Text = client.Email;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            loadAddRepairWindow();
        }

        public void LoadClients()
        {
            //Load Clients          
            List<Client> clients = sql.getClients();
            clients.Sort();

            comboBox_nameClientAddRepair.ItemsSource = clients;
            comboBox_nameClientAddRepair.DisplayMemberPath = "NameClient";
             
            if (client != null)
            {
                comboBox_nameClientAddRepair.Text = client.NameClient;
                textBox_ContactAddRepair.Text = client.Contact;
                textBox_PhoneAddRepair.Text = client.Phone;
                textBox_AddressAddRepair.Text = client.Address;
                textBox_EmailAddRepair.Text = client.Email;
            }
            else comboBox_nameClientAddRepair.SelectedIndex = 0;
            clients = null;
        }

        public void LoadCategories()
        {
            comboBox_CategoriesAddRepair.ItemsSource = null;
            //Load Categories
            List<Category> categories = sql.getCategoriesAll();
            categories.Sort();

            comboBox_CategoriesAddRepair.ItemsSource = categories;
            comboBox_CategoriesAddRepair.DisplayMemberPath = "NameCategory";
            comboBox_CategoriesAddRepair.SelectedIndex = 0;
            if (device != null) comboBox_CategoriesAddRepair.Text = device.Category;
            categories = null;
        }

        public void LoadBrandsByCategory()
        {
            List<Brand> brands = sql.getBrandsByCategoryAll(comboBox_CategoriesAddRepair.Text);

            brands.Sort();

            comboBox_BrandsAddRepair.ItemsSource = brands;
            comboBox_BrandsAddRepair.DisplayMemberPath = "NameBrand";
            comboBox_BrandsAddRepair.SelectedIndex = 0;
            if (device != null) comboBox_BrandsAddRepair.Text = device.Brand;
            brands = null;
        }
              public void LoadModelByCategoryAndBrand()
              {

           Brand brand = (Brand)comboBox_BrandsAddRepair.SelectedItem;

            List<Model> models = sql.getModelByCategoryAndBrandAll(comboBox_CategoriesAddRepair.Text, brand.NameBrand);

                  models.Sort();

                  comboBox_ModelsAddRepair.ItemsSource = models;
                  comboBox_ModelsAddRepair.DisplayMemberPath = "NameModel";
                  comboBox_ModelsAddRepair.SelectedIndex = 0;          
                  if (device != null) comboBox_ModelsAddRepair.Text = device.Model;
                  models = null;
              }


        public void LoadEngineers()
        {
            comboBox_EngineerAddRepair.ItemsSource = null;
            //Load Engineers
            List<Engineer> engineers = sql.getEngineersAll();
            engineers.Sort();
            comboBox_EngineerAddRepair.ItemsSource = engineers;
            comboBox_EngineerAddRepair.DisplayMemberPath = "NameEngineer";
            comboBox_EngineerAddRepair.SelectedIndex = 0;
            engineers = null;
        }

        public void LoadStatusRepairs()
        {
            comboBox_StatusRepairAddRepair.ItemsSource = null;
            List<StatusRepair> statusesRepairs = sql.getStatusAll();
            comboBox_StatusRepairAddRepair.ItemsSource = statusesRepairs;
            comboBox_StatusRepairAddRepair.DisplayMemberPath = "NameStatus";
            comboBox_StatusRepairAddRepair.SelectedIndex = 0;
            //comboBox_StatusRepairAddRepair.Text = "В работе";
            statusesRepairs = null;
        }

        public void LoadTypesRepairs()
        {
            comboBox_TypeRepairAddRepair.ItemsSource = null;
            List<TypeRepair> typesRepairs = sql.getTypesAll();
            comboBox_TypeRepairAddRepair.ItemsSource = typesRepairs;
            comboBox_TypeRepairAddRepair.DisplayMemberPath = "NameType";
            comboBox_TypeRepairAddRepair.SelectedIndex = 0;
            // comboBox_TypeRepair.Text = "Не гарантийный";
            typesRepairs = null;
        }
        public void loadAddRepairWindow(Client client = null, Device device = null)
        {
            textBox_NumberAddRepair.IsEnabled = false;
            textBox_DateAddRepair.IsEnabled = false;
            textBox_AddressAddRepair.IsEnabled = false;
            textBox_ContactAddRepair.IsEnabled = false;
            textBox_EmailAddRepair.IsEnabled = false;
            textBox_PhoneAddRepair.IsEnabled = false;
            
            this.client = client;
            this.device = device;

            LoadClients();

            LoadCategories();

   //         LoadBrandsByCategory();

      //      LoadModelByCategoryAndBrand();


            LoadEngineers();

            LoadStatusRepairs();

            LoadTypesRepairs();

            /*   comboBox_EngineerAddRepair.Text = "Горбачев";
               comboBox_TypeRepairAddRepair.Text = "Не гарантийный";
               comboBox_CategoriesAddRepair.Text = "Ноутбук";*/
        }
        public Client getClient()
        {
            client.NameClient = comboBox_nameClientAddRepair.Text;
            client.Contact = textBox_ContactAddRepair.Text;
            client.Phone = textBox_PhoneAddRepair.Text;
            client.Address = textBox_AddressAddRepair.Text;
            client.Email = textBox_EmailAddRepair.Text;
            return client;
        }

        public Device getDevice()
        {
            device.Category = comboBox_CategoriesAddRepair.Text;
            device.Brand = comboBox_BrandsAddRepair.Text;
            device.Model = comboBox_ModelsAddRepair.Text;
            return device;
        }

        private void bt_AddClientAddRepair_Click(object sender, RoutedEventArgs e)
        {
             Client newClient = new Client();//нужен пустой
            (new AddClientWindow(newClient)).ShowDialog();
              try{
            client = newClient;
          //  MessageBox.Show(client.Phone);
                loadAddRepairWindow(client);
            }            catch { loadAddRepairWindow(); }
        }

        private void bt_EditClientAddRepair_Click(object sender, RoutedEventArgs e)
        {
            if (client == null) client = new Client();
            client = getClient();

            (new EditClientWindow(client)).ShowDialog();

            loadAddRepairWindow(client);
        }

        private void comboBox_nameClientAddRepair_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            textsforTextboxes((Client)comboBox_nameClientAddRepair.SelectedValue);
        }

        private void comboBox_CategoriesAddRepair_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {            
            List<Brand> brands;

            Category cat = (Category)comboBox_CategoriesAddRepair.SelectedItem;//вытащили из нового значения категории ее название, comboBox_CategoriesAddModel.Text возвращает предыдущее значение!!!

            try
            {
                brands = sql.getBrandsByCategoryAll(cat.NameCategory);
            }
            catch
            {
                brands = sql.getBrandsByCategoryAll(comboBox_CategoriesAddRepair.Text);
            }

            brands.Sort();

            comboBox_BrandsAddRepair.ItemsSource = brands;
            if(brands.Count<1)comboBox_ModelsAddRepair.ItemsSource = brands;
            comboBox_BrandsAddRepair.DisplayMemberPath = "NameBrand";
            comboBox_BrandsAddRepair.SelectedIndex = 0;
        }

        private void comboBox_BrandsAddRepair_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {          
            List<Model> models;
            //   LoadModelByCategoryAndBrand();  //Инженеры улетают

            Brand brand = (Brand)comboBox_BrandsAddRepair.SelectedItem;

            Category cat = (Category)comboBox_CategoriesAddRepair.SelectedItem;

            try
            {
                models = sql.getModelByCategoryAndBrandAll(cat.NameCategory, brand.NameBrand);
            }
            catch
            {
                models = sql.getModelByCategoryAndBrandAll(comboBox_CategoriesAddRepair.Text, comboBox_BrandsAddRepair.Text);
            }

            models.Sort();

            comboBox_ModelsAddRepair.ItemsSource = models;
            comboBox_ModelsAddRepair.DisplayMemberPath = "NameModel";
            comboBox_ModelsAddRepair.SelectedIndex = 0;
        }

        private void bt_SaveNewRepairAddRepair_Click(object sender, RoutedEventArgs e)
        {
            int price = 0;
            try
            {
                price = Convert.ToInt32(textBox_PriceAddRepair.Text);
            }
            catch
            {
                price = 0;
                //MessageBox.Show("Цена установлена 0", "Неккоректно введена цена!");
            }

            try
            {
                (new SQLActions()).AddRepair(comboBox_nameClientAddRepair.Text, comboBox_CategoriesAddRepair.Text, comboBox_BrandsAddRepair.Text, comboBox_ModelsAddRepair.Text
                    , textBox_SNAddRepair.Text, comboBox_TypeRepairAddRepair.Text, textBox_DefectAddRepair.Text, textBox_kitViewAddRepair.Text, comboBox_EngineerAddRepair.Text
                    , textBox_ResultAddRepair.Text, price, comboBox_StatusRepairAddRepair.Text);
                // MessageBox.Show("Ремонт добавлен успешно!", "Успешное добавление нового ремонта");
            }
            catch
            {
                MessageBox.Show("Not connected to DB", "Error");
            }
            Close();
        }

        private void bt_NewModelAddRepair_Click(object sender, RoutedEventArgs e)
        {
            if (device == null) device = new Device();
            device = getDevice();
            (new AddModelWindow(device)).ShowDialog();

            LoadModelByCategoryAndBrand();
        }

        private void bt_NewBrandAddRepair_Click(object sender, RoutedEventArgs e)
        {
            if (device == null) device = new Device();
            device = getDevice();
            (new AddBrandWindow(device)).ShowDialog();

            LoadBrandsByCategory();
        }

        private void bt_NewCategoryAddRepair_Click(object sender, RoutedEventArgs e)
        {
            if (device == null) device = new Device();
            device = getDevice();
            (new AddCategoryWindow(device)).ShowDialog();

            LoadCategories();
        }
    }
}
