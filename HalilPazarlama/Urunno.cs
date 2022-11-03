using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalilPazarlama
{
    public class Urunno
    {
        string Name;


        public Urunno(string name)
        {
            Name = name;
        }
        public string Yazdır()
        {
            return $"{Name}";
        }
    }
}
