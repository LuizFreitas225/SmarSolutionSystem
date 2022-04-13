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

        public List<InformacaoPessoal> getInformacaoPessoalUsuario()
        {
            UsuarioDao usuarioDao = new UsuarioDao();

            List<Usuario> usuarioLista = usuarioDao.find();
            List<InformacaoPessoal> infoPessoaLista = new List<InformacaoPessoal>();


            foreach (Usuario usuAux in usuarioLista)
            {
                infoPessoaLista.Add(usuAux.informacaoPessoal);
            }

            return infoPessoaLista;
        }
        public List<UsuarioDTO> getUsuariosDTO()
        {
            UsuarioDao usuarioDao = new UsuarioDao();

            List<Usuario> usuarioLista = usuarioDao.find();
            List<UsuarioDTO> usuarioDTOList = new List<UsuarioDTO>();
            foreach(Usuario usuario in usuarioLista)
            {
                usuarioDTOList.Add(UsuarioDTO.getUsuarioDTO(usuario));
            }
            
           

            return usuarioDTOList;
        }

    }
}
