using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.Agencia = 863;
            contaDaGabriela.numero = 863452;
            contaDaGabriela.saldo = 100;


            Console.WriteLine("Titular: " + contaDaGabriela.titular);
            Console.WriteLine( "Agência: "+contaDaGabriela.Agencia);
            Console.WriteLine("Número: " +contaDaGabriela.numero);
            Console.WriteLine("Sáldo: " + contaDaGabriela.saldo);



            Console.ReadLine();

        }
    }
}
