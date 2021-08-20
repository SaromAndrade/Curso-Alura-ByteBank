using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente gariela = new Cliente();
            //gariela.nome = "Gabriela";
            //gariela.profissao = "Desenvolvedora C#";
            //gariela.cpf = "434.562.878-20";

            ContaCorrente conta = new ContaCorrente();
            // conta.titular = gariela;
            //conta.titular = new Cliente();
            //conta.titular.nome = "Gabriela Costa";
            //conta.titular.cpf = "434.562.878-20";
            //conta.titular.profissao= "Desenvolvedora C#";
            conta.saldo = 500;
            conta.Agencia = 563;
            conta.numero = 5634527;
            if(conta.titular == null)
            {
                Console.WriteLine("Ops, a referencia em conta.titular é NULL");
            }   

           // Console.WriteLine(gariela.nome);
            //Console.WriteLine(conta.titular.nome);
            //Console.WriteLine(conta.titular.cpf);
            //Console.WriteLine(conta.titular.profissao);

            Console.ReadLine();
        }
    }
}
