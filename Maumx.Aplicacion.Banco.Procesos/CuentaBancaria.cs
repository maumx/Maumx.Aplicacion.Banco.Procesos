using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maumx.Aplicacion.Banco.Entidades
{
   abstract public class CuentaBancaria
    {
        public CuentaBancaria(String numeroDeCuenta)
        {
            Transacciones = new List<ATMTransaccion>();
            EstaActiva = true;
            Numero = numeroDeCuenta;
        }

        public String Numero { get; set; }
        public Decimal Saldo { get; set; }
        public bool EstaActiva { get; set; }
        private List<ATMTransaccion> Transacciones { get; set; }


        #region "Metodos Públicos"
        /// <summary>
        /// Permite realizar deposito de dinero en una cuenta bancaria
        /// </summary>
        /// <param name="monto"></param>
        public void RealizarDeposito(Decimal monto)
        {

            //Primero realizamos todas la validaciones correspondientes
            if (!EstaActiva)
            {
                throw new InvalidOperationException("Imposible realizar un depósito: La cuenta bancaria no está activa");
            }
            if (monto<=0M)
            {
                throw new InvalidOperationException("Imposible realizar un depósito: El montoRetiro no es válido");
            }
   

            try
            {            
            OnRealizarDeposito(monto);
                Saldo += monto;
                //Se crea la transaccion con los monto finales
                CrearTransaccion(eTipoTransaccion.Deposito, Saldo, monto);



            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public void RealizarRetiro(Decimal montoRetiro)
        {

            //Primero realizamos todas la validaciones correspondientes
            if (!EstaActiva)
            {
                throw new InvalidOperationException("Imposible realizar un retiro: La cuenta bancaria no está activa");
            }
            if (montoRetiro <= 0M)
            {
                throw new InvalidOperationException("Imposible realizar un retiro: El montoRetiro no es válido");
            }
            if (Saldo<montoRetiro)
            {
                throw new InvalidOperationException("Imposible realizar un retiro: La cuenta bancaria no cuenta con el saldo suficiente");
            }


            try
            {
                OnRealizarRetiro(montoRetiro);
                Saldo -= montoRetiro;
                //Se crea la transaccion con los monto finales
                CrearTransaccion(eTipoTransaccion.Retiro, Saldo, montoRetiro);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion



        #region "Metodos virtuales"
        protected virtual void OnRealizarDeposito(Decimal monto)
        {
            throw new NotImplementedException("Imposible utilizar método OnRealizarDeposito: El método no ha sido definido");
        }

        protected virtual void OnRealizarRetiro(Decimal montoRetiro)
        {
            throw new NotImplementedException("Imposible utilizar método OnRealizarRetiro: El método no ha sido definido");
        }


        private void CrearTransaccion(eTipoTransaccion tipoTransaccion,decimal postBalance, Decimal montoTransaccion)
        {
            ATMTransaccion transaccion = new ATMTransaccion(tipoTransaccion, postBalance, montoTransaccion);
            Transacciones.Add(transaccion);
        }
        #endregion
    }
}
