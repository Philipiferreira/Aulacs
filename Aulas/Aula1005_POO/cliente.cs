using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1005_POO
{
    class cliente : Pessoa

    {

        public DateTime DataNasc { get; set;}

        public cliente()
        {

        }

 
        public cliente(string nome) : base(nome)
        {
                
        }

        public cliente(string nome,  string cpf) :base (nome, cpf)
        {

        }
        

        }

    }




;
