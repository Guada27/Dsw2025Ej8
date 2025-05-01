using System;
using Dsw2025Ej8.Domain;
using Dsw2025Ej8.Domain.Exceptions;

public class CajaDeAhorro : CuentaBancaria
{
    public decimal TasaDeInteres { get; set; }

    public CajaDeAhorro(string numero, decimal saldo, string[] titulares)
    : base(numero, saldo, titulares)
    {
    }

    public override void Depositar(decimal monto)
    {
        ValidarMonto(monto);
        ValidarEstado();
        Saldo += monto;
    }

    public override void Retirar(decimal monto)
    {
        ValidarMonto(monto);
        ValidarEstado();
        if (Saldo < monto)
        {
            CambiarEstado(Estado.Suspendida);
            throw new SaldoInsuficienteException();
        }
        Saldo -= monto;
    }

    public override void AplicarInteres()
    {
        ValidarEstado();
        Saldo += Saldo * TasaDeInteres;
    }
}



