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
    /// Логика взаимодействия для EditRepairWindow.xaml
    /// </summary>
    public partial class EditRepairWindow : Window
    {
        private int idRepair;
        private Controller controller;
        private SQLActions sql;
        private Client client;
        private Device device;
        private Repair repair;
        public EditRepairWindow(int idRepair)
        {
            InitializeComponent();
            controller = new Controller();
            sql = new SQLActions();
            client = null;
            device = null;
            repair = new Repair();
            this.idRepair = idRepair;
        }

        public void LoadBrandsByCategory()
        {
            List<Brand> brands = sql.getBrandsByCategoryAll(comboBox_CategoriesEditRepair.Text);

            brands.Sort();

            comboBox_BrandsEditRepair.ItemsSource = brands;
            comboBox_BrandsEditRepair.DisplayMemberPath = "NameBrand";
            comboBox_BrandsEditRepair.SelectedIndex = 0;
            if (device != null) comboBox_BrandsEditRepair.Text = device.Brand;
            brands = null;
        }
        public void LoadModelByCategoryAndBrand()
        {

            Brand brand = (Brand)comboBox_BrandsEditRepair.SelectedItem;

            List<Model> models = sql.getModelByCategoryAndBrandAll(comboBox_CategoriesEditRepair.Text, brand.NameBrand);

            models.Sort();

            comboBox_ModelsEditRepair.ItemsSource = models;
            comboBox_ModelsEditRepair.DisplayMemberPath = "NameModel";
            comboBox_ModelsEditRepair.SelectedIndex = 0;
            if (device != null) comboBox_ModelsEditRepair.Text = device.Model;
            models = null;
        }
        public void textsforTextboxes(Client client)
        {
            if (client == null) client = new Client();
            textBox_ContactEditRepair.Text = client.Contact;
            textBox_PhoneEditRepair.Text = client.Phone;
            textBox_AddressEditRepair.Text = client.Address;
            textBox_EmailEditRepair.Text = client.Email;
        }
        public Client getClient()
        {
            client.NameClient = comboBox_nameClientEditRepair.Text;
            client.Contact = textBox_ContactEditRepair.Text;
            client.Phone = textBox_PhoneEditRepair.Text;
            client.Address = textBox_AddressEditRepair.Text;
            client.Email = textBox_EmailEditRepair.Text;
            return client;
        }
        public Device getDevice()
        {
            device.Category = comboBox_CategoriesEditRepair.Text;
            device.Brand = comboBox_BrandsEditRepair.Text;
            device.Model = comboBox_ModelsEditRepair.Text;
            return device;
        }

        public void LoadClients()
        {
            //Load Clients          
            List<Client> clients = sql.getClients();
            clients.Sort();

            comboBox_nameClientEditRepair.ItemsSource = clients;
            comboBox_nameClientEditRepair.DisplayMemberPath = "NameClient";

            if (client != null)
            {
                comboBox_nameClientEditRepair.Text = client.NameClient;
                textBox_ContactEditRepair.Text = client.Contact;
                textBox_PhoneEditRepair.Text = client.Phone;
                textBox_AddressEditRepair.Text = client.Address;
                textBox_EmailEditRepair.Text = client.Email;
            }
            else comboBox_nameClientEditRepair.SelectedIndex = 0;
            clients = null;
        }

        public void LoadCategories()
        {
            comboBox_CategoriesEditRepair.ItemsSource = null;
            //Load Categories
            List<Category> categories = sql.getCategoriesAll();
            categories.Sort();

            comboBox_CategoriesEditRepair.ItemsSource = categories;
            comboBox_CategoriesEditRepair.DisplayMemberPath = "NameCategory";
            comboBox_CategoriesEditRepair.SelectedIndex = 0;
            if (device != null) comboBox_CategoriesEditRepair.Text = device.Category;
            categories = null;
        }


        public void LoadEngineers()
        {
            //Load Engineers
            List<Engineer> engineers = sql.getEngineersAll();
            engineers.Sort();
            comboBox_EngineerEditRepair.ItemsSource = engineers;
            comboBox_EngineerEditRepair.DisplayMemberPath = "NameEngineer";
            comboBox_EngineerEditRepair.SelectedIndex = 0;
            engineers = null;
        }

        public void LoadStatusRepairs()
        {
            List<StatusRepair> statusesRepairs = sql.getStatusAll();
            comboBox_StatusRepairEditRepair.ItemsSource = statusesRepairs;
            comboBox_StatusRepairEditRepair.DisplayMemberPath = "NameStatus";
            comboBox_StatusRepairEditRepair.SelectedIndex = 0;
            //comboBox_StatusRepairAddRepair.Text = "В работе";
            statusesRepairs = null;
        }

        public void LoadTypesRepairs()
        {
            List<TypeRepair> typesRepairs = sql.getTypesAll();
            comboBox_TypeRepairEditRepair.ItemsSource = typesRepairs;
            comboBox_TypeRepairEditRepair.DisplayMemberPath = "NameType";
            comboBox_TypeRepairEditRepair.SelectedIndex = 0;
            // comboBox_TypeRepair.Text = "Не гарантийный";
            typesRepairs = null;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            loadEditRepairWindow(client, device);
        }

        public void loadEditRepairWindow(Client client = null, Device device = null)
        {
            textBox_NumberEditRepair.IsEnabled = false;
            textBox_DateEditRepair.IsEnabled = false;
            textBox_AddressEditRepair.IsEnabled = false;
            textBox_ContactEditRepair.IsEnabled = false;
            textBox_EmailEditRepair.IsEnabled = false;
            textBox_PhoneEditRepair.IsEnabled = false;

            this.client = client;
            this.device = device;
            //Load Repair number
            textBox_NumberEditRepair.Text = idRepair.ToString();

            //Load Date
            textBox_DateEditRepair.Text = (sql.getDateByIdRepair(idRepair)).ToString();
   
            LoadClients();


            LoadCategories();


         
      /*      LoadBrandsByCategory();


            LoadModelByCategoryAndBrand();*/


            LoadEngineers();

            LoadStatusRepairs();


            LoadTypesRepairs();

            //get Repair
          //  if (client == null && device == null)
          //  {

                comboBox_nameClientEditRepair.Text = sql.getNameClientByIdRepair(idRepair);
                textsforTextboxes((Client)comboBox_nameClientEditRepair.SelectedItem);

                sql.getRepair(idRepair, repair);

                textBox_SNEditRepair.Text = repair.SN;
                textBox_DefectEditRepair.Text = repair.Defect;
                textBox_kitViewEditRepair.Text = repair.KitView;
                textBox_ResultEditRepair.Text = repair.Result;
                textBox_PriceEditRepair.Text = repair.Price.ToString();

                comboBox_CategoriesEditRepair.Text = sql.getNameCategoryByIdModel(repair.IdModel);

                comboBox_BrandsEditRepair.Text = sql.getNameBrandByIdModel(repair.IdModel);

                comboBox_ModelsEditRepair.Text = sql.getNameModelByIdModel(repair.IdModel);

                comboBox_EngineerEditRepair.Text = sql.getEngineerById(repair.IdEngineer);

                comboBox_StatusRepairEditRepair.Text = sql.getStatusById(repair.IdStatus);

                comboBox_TypeRepairEditRepair.Text = sql.getTypeRepairById(repair.IdType);
         //   }

        }

        private void comboBox_nameClientEditRepair_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            textsforTextboxes((Client)comboBox_nameClientEditRepair.SelectedValue);
        }

        private void bt_AddClientEditRepair_Click(object sender, RoutedEventArgs e)
        {
            Client newClient = new Client();//нужен пустой
            (new AddClientWindow(newClient)).ShowDialog();
            try
            {
                client = newClient;
                //  MessageBox.Show(client.Phone);
                loadEditRepairWindow(client);
            }
            catch { loadEditRepairWindow(); }
        }

        private void bt_EditClientEditRepair_Click(object sender, RoutedEventArgs e)
        {
            if (client == null) client = new Client();
            client = getClient();

            (new EditClientWindow(client)).ShowDialog();

            loadEditRepairWindow(client);
        }

        private void comboBox_CategoriesEditRepair_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<Brand> brands;

            Category cat = (Category)comboBox_CategoriesEditRepair.SelectedItem;//вытащили из нового значения категории ее название, comboBox_CategoriesAddModel.Text возвращает предыдущее значение!!!

            try
            {
                brands = sql.getBrandsByCategoryAll(cat.NameCategory);
            }
            catch
            {
                brands = sql.getBrandsByCategoryAll(comboBox_CategoriesEditRepair.Text);
            }

            brands.Sort();

            comboBox_BrandsEditRepair.ItemsSource = brands;
            if (brands.Count < 1) comboBox_ModelsEditRepair.ItemsSource = brands;
            comboBox_BrandsEditRepair.DisplayMemberPath = "NameBrand";
            comboBox_BrandsEditRepair.SelectedIndex = 0;
        }

        private void comboBox_BrandsEditRepair_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<Model> models;
            //   LoadModelByCategoryAndBrand();  //Инженеры улетают

            Brand brand = (Brand)comboBox_BrandsEditRepair.SelectedItem;

            Category cat = (Category)comboBox_CategoriesEditRepair.SelectedItem;

            try
            {
                models = sql.getModelByCategoryAndBrandAll(cat.NameCategory, brand.NameBrand);
            }
            catch
            {
                models = sql.getModelByCategoryAndBrandAll(comboBox_CategoriesEditRepair.Text, comboBox_BrandsEditRepair.Text);
            }

            models.Sort();

            comboBox_ModelsEditRepair.ItemsSource = models;
            comboBox_ModelsEditRepair.DisplayMemberPath = "NameModel";
            comboBox_ModelsEditRepair.SelectedIndex = 0;
        }

        private void bt_SaveRepairEditRepair_Click(object sender, RoutedEventArgs e)
        {
            int price = 0;
            try
            {
                price = Convert.ToInt32(textBox_PriceEditRepair.Text);
            }
            catch
            {
                price = 0;
                //MessageBox.Show("Цена установлена 0", "Неккоректно введена цена!");
            }

            try
            {
                sql.EditRepair(repair.IdRepair, comboBox_nameClientEditRepair.Text, comboBox_CategoriesEditRepair.Text, comboBox_BrandsEditRepair.Text, comboBox_ModelsEditRepair.Text
                    , textBox_SNEditRepair.Text, comboBox_TypeRepairEditRepair.Text, textBox_DefectEditRepair.Text, textBox_kitViewEditRepair.Text, comboBox_EngineerEditRepair.Text
                    , textBox_ResultEditRepair.Text, price, comboBox_StatusRepairEditRepair.Text);
                // MessageBox.Show("Ремонт изменен успешно!", "Успешное изменение нового ремонта");
            }
            catch
            {
                MessageBox.Show("Not connected to DB", "Error");
            }
            Close();
        }

        private void bt_NewCategoryEditRepair_Click(object sender, RoutedEventArgs e)
        {
            if (device == null) device = new Device();
            device = getDevice();
            (new AddCategoryWindow(device)).ShowDialog();

            LoadCategories();
        }

        private void bt_NewBrandEditRepair_Click(object sender, RoutedEventArgs e)
        {
            if (device == null) device = new Device();
            device = getDevice();
            (new AddBrandWindow(device)).ShowDialog();

            LoadBrandsByCategory();
        }

        private void bt_NewModelEditRepair_Click(object sender, RoutedEventArgs e)
        {
            if (device == null) device = new Device();
            device = getDevice();
            (new AddModelWindow(device)).ShowDialog();

            LoadModelByCategoryAndBrand();
        }

        /*      public void LoadBrandsByCategory()
              {
                  List<Brand> brands = sql.getBrandsByCategoryAll(comboBox_CategoriesEditRepair.Text);

                  brands.Sort();

                  comboBox_BrandsAddRepair.ItemsSource = brands;
                  comboBox_BrandsAddRepair.DisplayMemberPath = "NameBrand";
                  comboBox_BrandsAddRepair.SelectedIndex = 0;
                  if (device != null) comboBox_BrandsAddRepair.Text = device.Brand;
                  brands = null;
              }
              public void LoadModelByCategoryAndBrand()
              {

                  Brand brand = (Brand)comboBox_BrandsEditRepair.SelectedItem;

                  List<Model> models = sql.getModelByCategoryAndBrandAll(comboBox_CategoriesEditRepair.Text, brand.NameBrand);

                  models.Sort();

                  comboBox_ModelsEditRepair.ItemsSource = models;
                  comboBox_ModelsEditRepair.DisplayMemberPath = "NameModel";
                  comboBox_ModelsEditRepair.SelectedIndex = 0;
                  if (device != null) comboBox_ModelsEditRepair.Text = device.Model;
                  models = null;
              }*/


    }
}
