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
    /// Логика взаимодействия для FindRepairByNumberWindow.xaml
    /// </summary>
    public partial class FindRepairByNumberWindow : Window
    {
        public FindRepairByNumberWindow()
        {
            InitializeComponent();
        }

        private void bt_OKFindRepairByNumber_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = this.Owner as MainWindow;
            try { main.IdFindRepair = Convert.ToInt32(textBox_NumberRepairFindRepairByNumber.Text); }

            catch { main.IdFindRepair = 0; }
            Close();
        }
    }
}
