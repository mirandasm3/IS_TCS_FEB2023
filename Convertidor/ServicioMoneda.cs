using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Convertidor
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class ServicioMoneda : IServicioMoneda
    {
        public double convertirPesos(double peso)
        {
            double dolar = peso / 18.16;
            return dolar;
        }

        public double convertirDolares(double dolar)
        {
            double peso = dolar * 18.16;
            return peso;
        }
    }
}
