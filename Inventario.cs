using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrtoPulito
{
    internal class Inventario
    {
        List<Utensile> utensili;
        int acqua;
        int semi;

        public Inventario(int acqua, int semi)
        {
            utensili = new List<Utensile>();
            this.acqua = acqua;
            this.semi = semi;
        }
    }
}
