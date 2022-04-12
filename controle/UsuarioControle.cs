using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartSolutionSystem.dao;
using SmartSolutionSystem.model;

namespace SmartSolutionSystem.controle
{
    public class UsuarioControle
    {

        public Usuario usuario ;
        public string mensagem = "";
        public void  cadastrar(Usuario usuarioNovo)
        {
            UsuarioDao usuarioDao = new UsuarioDao();

            usuarioDao.cadastrar(usuarioNovo);
            if (!usuarioDao.mensagem.Equals(""))
            {
                this.mensagem = usuarioDao.mensagem;
            }
            else
            {
                usuario = usuarioNovo;
            }

            
        }
    }
}
