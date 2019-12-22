using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_de_ecuaciones
{
    class Calculo
    {
        double a;
        double b;
        double c;

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }

        public double discriminante()
        {
            double disc = 0;
            double ca = a;
            double cb = Math.Pow(b,2);
            double cc = c;
            disc = cb - (4 * ca * cc);
            return disc;
        }

        public double solucion0()
        {
            double x = 0;
            double ca = a;
            double cb = b;
            double cc = c;
            x = (-(cb)) / (2 * ca);
            return x;
        }

        public double solucionmayor0sum()
        {
            double x = 0;
            double ca = a;
            double cb = b;
            double cc = c;
            double disc =  Math.Pow(cb, 2) - 4 * ca * cc;
            x = (-(-cb) + Math.Pow(disc, (1 / 2)))/2*ca;
            return x;
        }

        public double solucionmayor0res()
        {
            double x = 0;
            double ca = a;
            double cb = b;
            double cc = c;
            double disc = Math.Pow(cb, 2) - 4 * ca * cc;
            x = (-(-cb) - Math.Pow(disc, (1 / 2))) / 2 * ca;
            return x;
        }

        public double solucionmenor0sum()
        {
            double x = 0;
            double ca = a;
            double cb = b;
            double cc = c;
            double disc = Math.Pow(cb, 2) - 4 * ca * cc;
            x = (-(-cb) + Math.Pow(disc, (1 / 2))) / 2 * ca;
            return x;
        }

        public double solucionmenor0res()
        {
            double x = 0;
            double ca = a;
            double cb = b;
            double cc = c;
            double disc = Math.Pow(cb, 2) - 4 * ca * cc;
            x = (-(-cb) - Math.Pow(disc, (1 / 2))) / 2 * ca;
            return x;
        }

    }
}
