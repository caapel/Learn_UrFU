using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Chemical
{
    public class Substance
    {
        readonly double T;  // температура, К
        readonly double G;  // массовый расход, кг/с

        public Substance(double t, double g)
        { 
            T = t + 273;
            G = g;
        }

        public double t { get { return T - 273; } }
        public double g { get { return g; } }

        public static Substance operator +(Substance s1, Substance s2)
        {
            return new Substance((s1.T * s1.G + s2.T * s2.G) / (s1.G + s2.G), s1.G + s2.G);
        }
    }

    public class Water : Substance
    {
        readonly double P; // давление, атм

        public Water(double t, double g, double p) :base(g,t)
        { 
            P = p;
        }

        public double p { get { return P; } }
    }
}