using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilder.Productos
{
    public class Casa
    {
        public int NumeroPuertas { get; set; }
        public int NumeroVentanas { get; set; }
        public int NumeroParedes { get; set; }
        public bool TieneJardin { get; set; }
        public bool TienePiscina { get; set; }
        public Casa(int numeroPuertas, int numeroVentanas, int numeroParedes, bool tieneJardin, bool tienePiscina) 
        {
            NumeroPuertas = numeroPuertas;
            NumeroVentanas = numeroVentanas;
            NumeroParedes = numeroParedes;
            TieneJardin = tieneJardin;
            TienePiscina = tienePiscina;
        }
        public Casa()
        {

        }
    }
}
