using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maumx.Aplicacion.Banco.Entidades
{
   public  class Cliente
    {

        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public long NumeroTarjeta { get; set; }
        public int PIN { get; set; }
        public List<CuentaBancaria> CuentasBancarias { get; set; }

        //public bool VerificarPassword(long numeroTarjeta, int pin)
        //{
            
        //}

    }
}
