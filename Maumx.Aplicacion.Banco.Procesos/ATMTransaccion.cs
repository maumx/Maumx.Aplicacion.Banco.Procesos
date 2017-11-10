using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maumx.Aplicacion.Banco.Entidades
{
    public class ATMTransaccion
    {

        public ATMTransaccion(eTipoTransaccion tipoTransaccion, Decimal postBalance, Decimal montoTransaccion)
        {
            NumeroTransaccion = Guid.NewGuid();
            Fecha = DateTime.Now;
            Tipo = tipoTransaccion;
            PostBalance = postBalance;

        }

        public Guid NumeroTransaccion { get; set; }
        public DateTime Fecha { get; set; }
        public eTipoTransaccion Tipo { get; set; }
        public Decimal Monto { get; set; }
        public Decimal PostBalance { get; set; }







  


    }
}
