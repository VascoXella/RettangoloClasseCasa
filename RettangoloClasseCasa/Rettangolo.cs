using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RettangoloClasseCasa
{
    internal class Rettangolo
    {
        public float l1 { get; set; }
        public float l2 { get; set; }

        public Rettangolo()
        {
        }

        public float Area()
        {
            return l1 * l2;
        }

        public float Perimetro()
        {
            return l1 * 2 + l2 * 2;
        }

    }
}
