using PatronBuilder.Interfaces;
using PatronBuilder.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilder.Constructores
{
    public class CasaBuilder : ICasaBuilder
    {
        private Casa _casa = new Casa();
        public Casa Build()
        {
            return _casa;
        }

        public void SetNumeroParedes(int numero)
        {
            throw new NotImplementedException();
        }

        public void SetNumeroPuertas(int numero)
        {
            _casa.NumeroParedes = numero;
        }
        public void SetNumeroVentanas(int numero)
        {
            _casa.NumeroVentanas = numero;
        }

        public void SetTieneJardin(bool tieneJardin)
        {
            _casa.TieneJardin = tieneJardin;
        }

        public void SetTienePiscina(bool tienePiscina)
        {
            _casa.TienePiscina = tienePiscina;
        }
    }
}
