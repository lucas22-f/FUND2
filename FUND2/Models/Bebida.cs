using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUND2.Models
{
    public class Bebida
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public Bebida(string nombre, int cantidad)
        {
            Nombre = nombre;
            Cantidad = cantidad;
        }

        public void Beberse(int CuantoBebio)
        {
            Cantidad -= CuantoBebio;
        }


    }
}
