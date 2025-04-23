using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OrtoPulito.Ortaggio;

namespace OrtoPulito
{
    internal class Terreno
    {
        int numeroOrtaggi;
        List<Ortaggio> campo;
        TipoOrtaggio tipoOrtaggio;

        public Terreno(int numeroOrtaggi, TipoOrtaggio tipoOrtaggio)
        {
            this.numeroOrtaggi = numeroOrtaggi; //set
            this.tipoOrtaggio = tipoOrtaggio;
            campo = new List<Ortaggio>();
        }
    }
}
