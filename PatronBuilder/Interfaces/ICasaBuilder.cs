using PatronBuilder.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilder.Interfaces
{
    public interface ICasaBuilder
    {
        public void SetNumeroPuertas(int numero);
        public void SetNumeroVentanas(int numero);
        public void SetNumeroParedes(int numero);
        public void SetTieneJardin(bool tieneJardin);
        public void SetTienePiscina(bool tienePiscina);
        public Casa Build();

    }
}
