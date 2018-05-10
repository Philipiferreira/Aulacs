using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1005_POO
{
    class cliente
    {
        private string nome;  //string privada com get/set para visualizar na classe program
    

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Cpf { get; set} // criar como propridade nao precisa dar get set pois ele faz a variavel sozinho
    }
}
