using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrtoPulito
{
    internal class Ortaggio
    {
        public enum TipoOrtaggio
        {
            lattuga,
            pomodori,
            melanzane,
            carote,
            peperoni,
            spinaci,
            zucca,
            zucchina,
            cavolfiore,
            fagioli
        }

        TipoOrtaggio tipo;
        int costo;
        int livello;

        public Ortaggio(TipoOrtaggio tipo)
        {
            this.tipo = tipo;
            SetCostoLivello(tipo);
        }

        private void SetCostoLivello(TipoOrtaggio tipo)
        {
            switch (tipo)
            {
                case TipoOrtaggio.lattuga:
                    costo = 5;
                    livello = 1;
                    break;

                case TipoOrtaggio.pomodori:
                    costo = 7;
                    livello = 2;
                    break;

                case TipoOrtaggio.melanzane:
                    costo = 10;
                    livello = 2;
                    break;

                case TipoOrtaggio.carote:
                    costo = 15;
                    livello = 3;
                    break;

                case TipoOrtaggio.peperoni:
                    costo = 17;
                    livello = 3;
                    break;

                case TipoOrtaggio.spinaci:
                    costo = 20;
                    livello = 3;
                    break;

                case TipoOrtaggio.zucca:
                    costo = 25;
                    livello = 4;
                    break;

                case TipoOrtaggio.zucchina:
                    costo = 30;
                    livello = 4;
                    break;

                case TipoOrtaggio.cavolfiore:
                    costo = 35;
                    livello = 4;
                    break;

                case TipoOrtaggio.fagioli:
                    costo = 40;
                    livello = 1;
                    break;

            }
        }
    }
}

