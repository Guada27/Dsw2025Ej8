using Dsw2025Ej8.Domain;
using Dsw2025Ej8.Domain.Exceptions;

namespace Dsw2025Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var titulares1 = new string[] { "Titular1" };
            var titulares2 = new string[] { "Titular2" };
            var titulares3 = new string[] { "Titular3" };
            var titulares4 = new string[] { "Titular4" };

            var cuentaAhorro1 = new CajaDeAhorro("123456", 1000m, titulares1) { TasaDeInteres = 0.05m };
            var cuentaAhorro2 = new CajaDeAhorro("789012", 2000m, titulares2) { TasaDeInteres = 0.03m };
            var cuentaCorriente1 = new CuentaCorriente("345678", 1500m, titulares3, 0.02m) { LimiteDeDescubierto = 500m };
            var cuentaCorriente2 = new CuentaCorriente("901234", 2500m, titulares4, 0.01m) { LimiteDeDescubierto = 1000m };


            try
            {
                cuentaAhorro1.Depositar(500m);
                cuentaAhorro1.Retirar(200m);
                cuentaAhorro1.AplicarInteres();

                cuentaAhorro2.Depositar(1000m);
                cuentaAhorro2.Retirar(3000m); //Excepcion

                cuentaCorriente1.Depositar(1000m);
                cuentaCorriente1.Retirar(2000m);
                cuentaCorriente1.Retirar(1000m); //Excepcion

                cuentaCorriente2.Depositar(500m);
                cuentaCorriente2.Retirar(3000m);
            }
            catch (MontoNoValidoException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (CuentaNoActivaException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
            }

            var cuentas = new CuentaBancaria[] { cuentaAhorro1, cuentaAhorro2, cuentaCorriente1, cuentaCorriente2 };

            foreach (var cuenta in cuentas)
            {
                var resumen = new
                {
                    Numero = cuenta.Numero,
                    Tipo = cuenta.GetType().Name,
                    Saldo = cuenta.Saldo
                };
                Console.WriteLine($"Número: {resumen.Numero}, Tipo: {resumen.Tipo}, Saldo: {resumen.Saldo}");
            }

        }
    }
}
