using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHesapMakinesi
{
    class Carpma : Islemler
    {
        public override double Hesapla(double a, double b, double c)
        {
            c = a * b;
            return c;
        }
    }
}
