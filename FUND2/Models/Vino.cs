using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUND2.Models
{
    internal class Vino : Bebida, IBebidaAlcoholica
    {
        //SOlucion poner el mismo atributo de la interfaz en la Clase;
        public int Alcohol { get; set; }
        public void MaximoRecomendado()
        {
            Console.WriteLine("El maximo permitido son 3 copas");
        }
        public Vino(int cantidad, string nombre = "Vino")
            : base(nombre, cantidad)
        {

        }




    }
}
