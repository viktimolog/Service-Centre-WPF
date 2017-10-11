using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCentreWPF
{
    public class Brand : IComparable
    {
        private int idCategory;
        private int idBrand;
        private string nameBrand;

        public Brand()
        {
          nameBrand = "";
        }

        public int IdCategory
        {
            get { return idCategory; }
            set { idCategory = value; }
        }

        public int IdBrand
        {
            get { return idBrand; }
            set { idBrand = value; }
        }

        public string NameBrand
        {
            get { return nameBrand; }
            set { nameBrand = value; }
        }

        public int CompareTo(object o)
        {
            Brand p = o as Brand;
            if (p != null)
                return nameBrand.CompareTo(p.nameBrand);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
    }
}
