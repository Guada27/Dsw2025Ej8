using Dsw2025Ej8.Domain;
using Dsw2025Ej8.Domain.Exceptions;

namespace Dsw2025Ej8.Domain
{
    public abstract class CuentaBancaria
    {
        public string Numero { get; private set; }
        public decimal Saldo { get; protected set; }
        public Estado Estado { get; private set; }
        public string[] Titulares { get; private set; }

        public CuentaBancaria(string numero, decimal saldo, string[] titulares)
        {
            Numero = numero;
            Saldo = saldo;
            Estado = Estado.Activa;
            Titulares = titulares;
        }
        protected void CambiarEstado(Estado estado)
        {
            Estado = estado;
        }

        protected void ValidarMonto(decimal monto)
        {
            if (monto <= 0)
            {
                throw new MontoNoValidoException();
            }
        }

        protected void ValidarEstado()
        {
            if (Estado != Estado.Activa)
            {
                throw new CuentaNoActivaException(Estado);
            }
        }

        public abstract void Depositar(decimal monto);
        public abstract void Retirar(decimal monto);
        public abstract void AplicarInteres();
    }
}

