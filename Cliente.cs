using System;

namespace Banco
{
    class Cliente
    {
        static void Main(string[] args)
        {
            Adaptador adaptador= new Adaptador();
            adaptador.IngresarBolivianos(100);
            Console.WriteLine($"el saldo de su cuenta es: {adaptador.bolivianos}Bs");
            adaptador.IngresarDolares(100);
            Console.WriteLine($"el saldo de su cuenta es: {adaptador.bolivianos}Bs");
            adaptador.SacarDolares(90);
            Console.WriteLine($"el saldo de su cuenta es: {adaptador.bolivianos}Bs");
            adaptador.RetirarBolivianos(100);
            Console.WriteLine($"el saldo de su cuenta es: {adaptador.bolivianos}Bs");
            adaptador.IngresarEuros(50);
            Console.WriteLine($"el saldo de su cuenta es: {adaptador.bolivianos}Bs");
            adaptador.SacarEuros(48);
            Console.WriteLine($"el saldo de su cuenta es: {adaptador.bolivianos}Bs");
       
        }
    }
}
