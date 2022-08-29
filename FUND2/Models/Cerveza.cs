using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUND2.Models
{
    public class Cerveza : Bebida , IBebidaAlcoholica,Irrequestable
    {
        //SOlucion poner el mismo atributo de la interfaz en la Clase;
        public int Alcohol { get; set; }
        public string Marca { get; set; }
        public int id { get; set; }
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
