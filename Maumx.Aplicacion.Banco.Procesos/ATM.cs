using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maumx.Aplicacion.Banco.Entidades
{
    public  class ATM
    {

        public String Direccion { get; set; }
        public String AdministradorPor { get; set; }



        public bool Identificar(long numeroTarjeta, int pin)
        {
            return true;

        }

    }
}
