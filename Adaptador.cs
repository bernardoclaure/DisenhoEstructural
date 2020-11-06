using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    public class Adaptador : CajaBolivianos,IAdaptadorMonedas
    {
        public void IngresarDolares(double monto)
        {
            double deposito = monto * 6.93;
            IngresarBolivianos(deposito);
        }

        public void SacarDolares(double monto)
        {
            double retiro = monto * 6.97;
            RetirarBolivianos(retiro);
        }
        public void IngresarEuros(double monto)
        {
            double deposito = monto * 8.11;
            IngresarBolivianos(deposito);
        }

        public void SacarEuros(double monto)
        {
            double retiro = monto * 8.20;
            RetirarBolivianos(retiro);
        }
    }
}
