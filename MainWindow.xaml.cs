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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ServiceCentreWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SQLActions sql;
        private int idFindRepair;
        private string SN;
        private string find;
        private string order;
        public MainWindow()
        {
            InitializeComponent();
            // Icon icon = new Icon("SC.ico");
            //   this.Icon = icon;
            sql = new SQLActions();
            idFindRepair = 0;
            SN = "";
            order = "";
            find = "";
        }

        public int IdFindRepair { get { return idFindRepair; } set { idFindRepair = value; } }
        public string sN { get { return SN; } set { SN = value; } }
        public string Find { get { return find; } set { find = value; } }

        public void loadWindowMain(int id = 0)//либо по номеру, либо все незавершенные, выводит не в том порядке столбцы
        {
            List<RepairView> repairsView;

            if (id == 0) repairsView = sql.ShowRepairsNotFinishForDS("ShowRepairsNotFinish");
            else repairsView = sql.ShowRepairByNumber(id);

            dataGridView1.ItemsSource = repairsView;

            dataGridView1.IsReadOnly = true;
        }

        private void getRepairByOther(string find)
        {
            List<RepairView> repairsView = sql.getRepairByOther(find);

            dataGridView1.ItemsSource = repairsView;

            dataGridView1.IsReadOnly = true;
        }

        public void getRepairBySN(string SN)
        {
            List<RepairView> repairsView = sql.getRepairBySN(SN);

            dataGridView1.ItemsSource = repairsView;

            dataGridView1.IsReadOnly = true;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            loadWindowMain();
        }
/*
            public void getRepairByOther(string find)
            {
                List<String[]> rows;

                dataGridView1.Columns.Clear();

                rows = sql.getRepairByOther(find);

                for (int i = 0; i < rows[0].Length; i++)
                    dataGridView1.Columns.Add((rows[0])[i], (rows[0])[i]);

                for (int i = 1; i < rows.Count; i++)
                    dataGridView1.Rows.Add(rows[i]);

                dataGridView1.IsReadOnly = true;
            }
*/

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            (new AddBrandWindow()).ShowDialog();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            (new AddCategoryWindow()).ShowDialog();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Client newClient = new Client();
            (new AddClientWindow(newClient)).ShowDialog();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            (new AddModelWindow()).ShowDialog();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            (new AddRepairWindow()).ShowDialog();
            loadWindowMain();
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            (new EditBrandWindow()).ShowDialog();
            loadWindowMain();
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            (new EditCategoryWindow()).ShowDialog();
            loadWindowMain();
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            (new EditClientWindow()).ShowDialog();
            loadWindowMain();
        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {
            (new EditModelWindow()).ShowDialog();
            loadWindowMain();
        }

        private void MenuItem_Click_9(object sender, RoutedEventArgs e)
        {
            try
            {
                RepairView rep = (RepairView)dataGridView1.SelectedItem;
                (new EditRepairWindow(rep.IdRepair)).ShowDialog();
            }
            catch
            {
                MessageBox.Show("Выберите ремонт");
            }
            loadWindowMain();
        }

        private void MenuItem_Click_10(object sender, RoutedEventArgs e)
        {
            FindByOtherWindow f = new FindByOtherWindow();
            f.Owner = this;
            f.ShowDialog();
            getRepairByOther(Find);
        }

        private void dataGridView1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                RepairView rep = (RepairView)dataGridView1.SelectedItem;
                (new EditRepairWindow(rep.IdRepair)).ShowDialog();
            }
            catch
            {
                MessageBox.Show("Выберите ремонт");
            }
            loadWindowMain();
        }

        private void MenuItem_Click_11(object sender, RoutedEventArgs e)
        {
            List<RepairView> repairsView;

            repairsView = sql.ShowRepairsNotFinishForDS("ShowAllRepairs");

            dataGridView1.ItemsSource = repairsView;

            dataGridView1.IsReadOnly = true;
        }

        private void MenuItem_Click_12(object sender, RoutedEventArgs e)
        {
            loadWindowMain();
        }

        private void MenuItem_Click_13(object sender, RoutedEventArgs e)
        {
            FindRepairByNumberWindow f = new FindRepairByNumberWindow();
            f.Owner = this;
            f.ShowDialog();
            loadWindowMain(idFindRepair);
        }

        private void MenuItem_Click_14(object sender, RoutedEventArgs e)
        {
            FindRepairBySNWindow f = new FindRepairBySNWindow();
            f.Owner = this;
            f.ShowDialog();
            getRepairBySN(sN);
        }

        private void MenuItem_Click_16(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
