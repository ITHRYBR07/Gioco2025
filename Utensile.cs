using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrtoPulito
{
    internal class Utensile
    {
        public enum TipoUtensile
        {
            Pala,
            Aratro,
            Pinza
        }

        TipoUtensile tipo;
        int costo;

        public Utensile(TipoUtensile tipo)
        {
            this.tipo = tipo;
            SetCosto(tipo);
        }

        private void SetCosto(TipoUtensile tipo)
        {
            switch (tipo)
            {
                case TipoUtensile.Pala:
                    costo = 20;
                    break;

                case TipoUtensile.Aratro:
                    costo = 100;
                    break;

                case TipoUtensile.Pinza:
                    costo = 50;
                    break;
            }
        }
    }
}

