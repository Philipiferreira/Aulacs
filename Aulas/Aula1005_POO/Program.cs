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
     

        }
    }
}