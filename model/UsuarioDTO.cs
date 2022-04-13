using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSolutionSystem.model
{
    public class UsuarioDTO
    {
        public int id { get; set; }
        public bool isPessoaJuridica { get; set; }
        public bool isAdmin { get; set; }

        public string nome { get; set; }
        public string cnpj { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }

        public string cep { get; set; }
        public string cidade { get; set; }
        public string bairro { get; set; }
        public string uf { get; set; }
        public string complemento { get; set; }
        public string endereco { get; set; }

        public string login { get; set; }
        public string senha { get; set; }

        public static UsuarioDTO getUsuarioDTO(Usuario usuario)
        {
            UsuarioDTO usuarioDTo
                 = new UsuarioDTO();
            usuarioDTo.id = usuario.id;
                usuarioDTo.isPessoaJuridica = usuario.isPessoaJuridica;
            usuarioDTo.isAdmin = usuario.isAdmin;
            usuarioDTo.nome = usuario.informacaoPessoal.nome;
            usuarioDTo.cnpj = usuario.informacaoPessoal.cnpj;
            usuarioDTo.cpf = usuario.informacaoPessoal.cpf;
            usuarioDTo.telefone = usuario.informacaoPessoal.telefone;
            usuarioDTo.cep = usuario.endereco.cep;
            usuarioDTo.cidade = usuario.endereco.cidade; 
            usuarioDTo.bairro = usuario.endereco.bairro;
            usuarioDTo.uf = usuario.endereco.uf;
            usuarioDTo.complemento = usuario.endereco.complemento;
            usuarioDTo.endereco = usuario.endereco.endereco;

            usuarioDTo.login = usuario.informacaoLogin.login;
            usuarioDTo.senha = usuario.informacaoLogin.senha;
            return usuarioDTo;
        }

        public  Usuario AsUsuario()
        {
            Usuario usuario
                 = new Usuario();

             usuario.id = this.id;
             usuario.isPessoaJuridica = this.isPessoaJuridica;
            usuario.isAdmin = this.isAdmin;

            usuario.informacaoPessoal = new InformacaoPessoal();
            usuario.informacaoPessoal.nome = this.nome;
            usuario.informacaoPessoal.cnpj = this.cnpj;
            usuario.informacaoPessoal.cpf = this.cpf;
            usuario.informacaoPessoal.telefone = this.telefone;
            usuario.endereco = new Endereco();
            usuario.endereco.cep = this.cep;
            usuario.endereco.cidade = this.cidade;
            usuario.endereco.bairro = this.bairro;
            usuario.endereco.uf = this.uf;
            usuario.endereco.complemento = this.complemento;
            usuario.endereco.endereco = this.endereco;

            usuario.informacaoLogin = new InformacaoLogin();
            usuario.informacaoLogin.login = this.login;
            usuario.informacaoLogin.senha = this.senha;


            return usuario;
        }
    }
}
