using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCentreWPF
{
    public class Engineer : IComparable
    {
        private int idEngineer;
        private string nameEngineer;        
        public int IdEngineer { get { return idEngineer; } set { idEngineer = value; } }
        public string NameEngineer { get { return nameEngineer; } set { nameEngineer = value; } }

        public int CompareTo(object o)
        {
            Engineer p = o as Engineer;
            if (p != null)
                return nameEngineer.CompareTo(p.nameEngineer);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
    }
}
