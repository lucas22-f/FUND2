using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUND2.Models
{
    internal class Cerveza : Bebida , IBebidaAlcoholica
    {
        //SOlucion poner el mismo atributo de la interfaz en la Clase;
        public int Alcohol { get; set; }
        public string Marca { get; set; }

        public void MaximoRecomendado()
        {
            Console.WriteLine("El maximo permitido son 10");
        }
        public Cerveza(int cantidad, string nombre = "Cerveza")
            : base(nombre, cantidad)
        {

        }

        


    }
}
