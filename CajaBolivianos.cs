using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    public class CajaBolivianos
    {
        public double bolivianos { get; set; }
        public CajaBolivianos()
        {
            bolivianos = 0;
        }
        
        public void IngresarBolivianos(double monto)
        {
            bolivianos = bolivianos + monto;
        }
        public void RetirarBolivianos(double monto)
        {
            bolivianos = bolivianos - monto;
        }
    }
}
