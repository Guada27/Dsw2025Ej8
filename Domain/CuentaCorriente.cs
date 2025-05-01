using System;
using Dsw2025Ej8.Domain;
using Dsw2025Ej8.Domain.Exceptions;

public class CuentaCorriente : CuentaBancaria
{
    public decimal LimiteDeDescubierto { get; set; }
    public decimal Comision { get; private set; }

    public CuentaCorriente(string numero, decimal saldo, string[] titulares, decimal comision)
    : base(numero, saldo, titulares)
    {
        Comision = comision;
    }

    public void SetComision(decimal comision)
    {
        Comision = comision;
    }

    public override void Depositar(decimal monto)
    {
        ValidarMonto(monto);
        ValidarEstado();
        monto -= monto * Comision;
        Saldo += monto;
    }

    public override void Retirar(decimal monto)
    {
        ValidarMonto(monto);
        ValidarEstado();
        if (Saldo - monto < -LimiteDeDescubierto)
        {
            CambiarEstado(Estado.Suspendida);
            throw new SaldoInsuficienteException();
        }
        Saldo -= monto;
        if (Saldo < 0)
        {
            CambiarEstado(Estado.Suspendida);
        }
    }
    public override void AplicarInteres()
    {
        // No se aplica interés en Cuenta Corriente
    }
}







