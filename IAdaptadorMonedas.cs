using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    public interface IAdaptadorMonedas
    {
        void IngresarDolares (double monto);
        void SacarDolares(double monto);
        void IngresarEuros(double monto);
        void SacarEuros(double monto);
    }
}
