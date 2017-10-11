using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCentreWPF
{
    public class Category : INotifyPropertyChanged, IComparable
    {
        private int idCategory;
        private string nameCategory;

        public Category()
        {
            nameCategory = "";
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public int CompareTo(object o)
        {
            Category p = o as Category;
            if (p != null)
                return nameCategory.CompareTo(p.nameCategory);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }

        public int IdCategory
        {
            get { return idCategory; }
            set { idCategory = value; }
        }

        public string NameCategory
        {
            get { return nameCategory; }
            set { nameCategory = value; OnPropertyChanged("NameCategory"); }
        }        
    }
}
