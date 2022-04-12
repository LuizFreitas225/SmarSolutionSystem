using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSolutionSystem.model
{
    public class Usuario
    {
        public int id { get; set; }
        public bool isPessoaJuridica { get; set; }

        public bool isAdmin { get; set; }

        public InformacaoLogin informacaoLogin { get; set; }

        public InformacaoPessoal informacaoPessoal { get; set; }
        public Endereco endereco { get; set; }

        public bool setInformacaoLoginIfNotEmpty(InformacaoLogin value)
        {
            if (value != null)
            {
                informacaoLogin = value;
                return true;

            }
            return false;

        } 
        public bool setEnderecoIfNotEmpty(Endereco value)
        {
            if (value != null)
            {
                endereco = value;
                return true;

            }
            return false;

        }
        public bool setIformacaoPessoalIfNotEmpty(InformacaoPessoal value)
        {
            if (value != null)
            {
                informacaoPessoal = value;
                return true;

            }
            return false;

        }

    }
}

