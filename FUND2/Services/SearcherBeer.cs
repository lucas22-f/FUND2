using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

using FUND2.Models;


namespace FUND2.Services
{
    public class SearcherBeer
    {
        List<Cerveza> cervezas = new List<Cerveza>()
        {

            new Cerveza(20, "Carlos") { Alcohol = 2, Marca = "alejandro" },
            new Cerveza(2, "Raul") { Alcohol = 5, Marca = "zac" },
            new Cerveza(34, "Erne") { Alcohol = 16, Marca = "bravo" },
            new Cerveza(13, "Ariel") { Alcohol = 34, Marca = "delta" },


        };

        public int GetCantidad(string Nombre)
        {
            var cerveza = (from d in cervezas
                           where d.Nombre == Nombre
                           select d).FirstOrDefault();
            if(cerveza == null)
            {
                throw new Errors.NotFoundBeerException("La cerveza se termino");
            }
            return cerveza.Cantidad;
        }

       


    }
}
