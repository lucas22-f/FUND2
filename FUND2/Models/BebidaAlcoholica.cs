using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUND2.Models
{// las interfaces sirven para darle cierta especificidad a un tipo de clase
    //cumple con un contrato.
//ej vida real cuando hacemos solicitudes a un servicio web.
    internal interface IBebidaAlcoholica
    {
        public int Alcohol { get; set; }

        //hay que implementar el atributo de la interfaz 
        public void MaximoRecomendado();

    }
}
