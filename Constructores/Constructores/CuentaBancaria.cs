using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    internal class CuentaBancaria
    {
        // Auto properties (propiedades automaticas)
        public string NoCuenta { get; set; }
        public string Usuario { get; set; }

        // backing field
        private decimal _saldo;

        // Full property (propiedad completa
        public decimal Saldo
        {
            get { return _saldo; }
            set
            {
                //Evitar que el saldo sea negativo
                //if (value < 0)
                //{
                //    _saldo = 0;
                //}
                //else
                //{
                //    _saldo = value;
                //}

                // Manera de hacerlo resumido con el operador ternario
                _saldo = value < 0 ? 0 : value;
            }
        }

        #region constructores
        public CuentaBancaria(string noCuenta)
        {
            NoCuenta = noCuenta;
        }

        public CuentaBancaria(string noCuenta, string usuario) : this(noCuenta)
        {
            Usuario = usuario;
        }

        public CuentaBancaria(string noCuenta, string usuario, decimal saldo) : this(noCuenta, usuario)
        {
            Saldo = saldo;
        }

        //constructor vacio:
        public CuentaBancaria() { }
        #endregion

        // Metodos de instancia
        public void Retirar(decimal cantidad)
        {
            if(cantidad > Saldo)
            {
                Console.WriteLine("Saldo insuficiente");
                return;
            }
            Saldo -= cantidad;
        }


        public void Depositar(decimal cantidad)
        {
            Saldo += cantidad;
        }

        public override string ToString()
        {
            return String.Format("NoCuente: {0}, Usuario: {1}, Saldo: {2}", NoCuenta, Usuario, Saldo);
        }
    }
}
