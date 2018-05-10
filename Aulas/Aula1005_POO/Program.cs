using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1005_POO
{
    class Program
    {
        
        static void Main(string[] args)
        {

            cliente cli = new cliente();
            cli.Nome = "godofredo"; //set
            string nomeCliente = cli.Nome;

            cli.Cpf = "123456789"; // set 
            string cfpCliente = cli.Cpf;//get 

            Console.WriteLine(cli.Nome);
            Console.WriteLine(cli.Cpf);


            //utilizando os contrutores parametrizados.
           cliente  cli2 = new cliente("Jucicreia"); // nome

            Console.WriteLine("cli2.nome:" + cli.Nome);

            cliente cli3 = new cliente("Juciliuda" , "123"); // nome, cpf
            cli.DataNasc = new DateTime(1950, 05, 05);


            Console.WriteLine(
                cli3.Nome + "Nasceu em" + cli.DataNasc);

            Console.WriteLine(
                cli3.Nome + "Tem  "+cli.Idade);
          


            //Pessoa P = new Pessoa(); Erro Classe
            //Classes asbtradas n podem ser istanciadas 



            Console.ReadKey();
           

        }
    }
}