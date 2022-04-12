using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSolutionSystem.model
{
    public class InformacaoPessoal
    {
        public string nome { get; set; }
        public string cnpj { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }

        public bool setNomeIfNotEmpty(string value)
        {
            if (!String.IsNullOrEmpty(value))
            {
                nome = value;
                return true;

            }
            return false;
            

        }

        public bool setCnpjIfNotEmpty(string value)
        {
            if (! String.IsNullOrEmpty(value))
            {
                cnpj = value;
                return true;

            }
            return false;
            

        }

        public bool setCpfIfNotEmpty(string value)
        {
            if (!String.IsNullOrEmpty(value))
            {
                cpf = value;
                return true;

            }
            return false;
           

        }

        public bool setTelefoneIfNotEmpty(string value)
        {
            if (!String.IsNullOrEmpty(value))
            {
                telefone = value;
                return true;

            }
            return false;


        }
    }
}
