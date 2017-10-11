using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
//using System.Windows.Forms;

namespace ServiceCentreWPF
{
    public class Controller
    {
        private Client client;
        private SQLActions sql;
        private List<string> tmp;

     //   private Form form;

        public Controller()
        {
            sql = new SQLActions();
            client = new Client();
        }

    /*    public void LoadClientsToForm(AddRepairForm formAddRepair = null, EditRepairForm formEditRepair = null, AddClientForm formAddClient = null)
        {


            Convert.ChangeType(form, typeof(AddRepairForm));

 
            formAddRepair.comboBox_nameClient.DataSource = sql.getClients();

            formAddRepair.comboBox_nameClient.DisplayMember = "nameClient";
            formAddRepair.comboBox_nameClient.ValueMember = "nameClient";
            if (client != null)
            {
                formAddRepair.comboBox_nameClient.Text = client.NameClient;
                formAddRepair.textBox_Contact.Text = client.Contact;
                formAddRepair.textBox_Phone.Text = client.Phone;
                formAddRepair.textBox_Address.Text = client.Address;
                formAddRepair.textBox_Email.Text = client.Email;
            }
        }*/


        public void loadComboBoxWithoutParam(ComboBox combo, string nameStoredProcedure, bool sort=true)//универсальный для любого списка без доп параметров: все категории, все инженеры, все типы ремонтов, все состояния...
        {
            if (!sort)
            {
                combo.ItemsSource = sql.getListString(nameStoredProcedure);
            }
            else
            {
                tmp = sql.getListString(nameStoredProcedure);

                tmp.Sort();

                combo.ItemsSource = tmp;
            }
        }

        public void loadComboBoxBrandsByCategory(ComboBox combo, string Category, bool sort = true)
        {
            if (!sort)
            {
                combo.ItemsSource = sql.getBrandsByCategory(Category);
            }
            else
            {
                tmp = sql.getBrandsByCategory(Category);

                tmp.Sort();

                combo.ItemsSource = tmp;
            }
        }

        public void loadComboBoxModelsByBrandsAndCategory(ComboBox combo, string Category, string Brand, bool sort = true)
        {
            if (!sort)
            {
                combo.ItemsSource = sql.getModelByCategoryAndBrand(Category, Brand);
            }
            else
            {
                tmp = sql.getModelByCategoryAndBrand(Category, Brand);

                tmp.Sort();

                combo.ItemsSource = tmp;
            }
        }
    }
}
