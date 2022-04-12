using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSolutionSystem.model
{
    public class Endereco
    {

        public string cep { get; set; }
        public string cidade { get; set; }
        public string bairro { get; set; }
        public string uf { get; set; }
        public string complemento { get; set; }
        public string endereco { get; set; }
   

        public bool setCepIfNotEmpty(string value)
        {
            if (!String.IsNullOrEmpty(value))
            {
                cep = value;
                return true;

            }
            return false;


        }

        public bool setCidadeIfNotEmpty(string value)
        {
            if (!String.IsNullOrEmpty(value))
            {
                cidade = value;
                return true;

            }
            return false;


        }

        public bool setBairroIfNotEmpty(string value)
        {
            if (!String.IsNullOrEmpty(value))
            {
                bairro = value;
                return true;

            }
            return false;


        }

        public bool setUfIfNotEmpty(string value)
        {
            if (!String.IsNullOrEmpty(value))
            {
                uf = value;
                return true;

            }
            return false;


        }

        public bool setComplementoifNotEmpty(string value)
        {
            if (!String.IsNullOrEmpty(value))
            {
                complemento = value;
                return true;

            }
            return false;


        }
        public bool setEnderecoifNotEmpty(string value)
        {
            if (!String.IsNullOrEmpty(value))
            {
                endereco = value;
                return true;

            }
            return false;


        }

    }
}
