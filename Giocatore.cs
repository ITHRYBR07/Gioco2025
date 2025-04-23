using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrtoPulito
{
    internal class Giocatore
    {
        int monete;
        int esperienza;
        Inventario inventario;

        public Giocatore()
        {
            monete = 0;
            esperienza = 0;
            inventario = new Inventario(5, 3);
        }
    }
}
