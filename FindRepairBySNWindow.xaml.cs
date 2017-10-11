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
    /// Логика взаимодействия для FindRepairBySNWindow.xaml
    /// </summary>
    public partial class FindRepairBySNWindow : Window
    {
        public FindRepairBySNWindow()
        {
            InitializeComponent();
        }

        private void bt_OKFindRepairBySN_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = this.Owner as MainWindow;
            try { main.sN = textBox_SNFindRepairBySN.Text; }

            catch { main.sN = ""; }
            Close();
        }
    }
}
