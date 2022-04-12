using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartSolutionSystem.dao;
using SmartSolutionSystem.model;

namespace SmartSolutionSystem.controle
{
    public class LoginControle
    {
        public Usuario usuario;
        public  string mensagem = "";
        public Usuario acessar(String login, String senha)
        {
            LoginDao loginDao = new LoginDao();

            usuario = loginDao.verificarLogin(login, senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }

            return usuario;
        }
    }
}
