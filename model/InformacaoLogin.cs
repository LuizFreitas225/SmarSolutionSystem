using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSolutionSystem.model
{
    public class InformacaoLogin
    {
        public string login { get; set; }
        public  string senha { get; set; }
        

        public InformacaoLogin()
        {

        }

        public bool setLoginIfNotEmpty(string value)
        {
            if (!String.IsNullOrEmpty(value))
            {
                login = value;
                return true;

            }
            return false;


        }

        public bool setSenhaIfNotEmpty(string value)
        {
            if (!String.IsNullOrEmpty(value))
            {
                senha = value;
                return true;

            }
            return false;


        }
    }
}
