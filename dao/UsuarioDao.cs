using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartSolutionSystem.model;

namespace SmartSolutionSystem.dao
{
    public class UsuarioDao
    {

        Usuario usuario;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public String cadastrar(Usuario usuario )
        {
            //comandos para inserir no BD
            //comandos sql para verificar se tem no banco
            
           cmd.CommandText = "INSERT INTO dbo.USUARIO " +
           "(IS_PESSOA_JURIDICA,IS_ADMIN ,NOME ,CNPJ,CPF,TELEFONE ,LOGIN,SENHA ,CEP,CIDADE ,BAIRRO ,ENDERECO,UF, COMPLEMENTO) " +
           "  VALUES ( @isPessoaJuridica, @isAdmin , @nome , @cnpj , @cpf, @telefone , @login , @senha , @cep , @cidade , @bairro , @endereco  , " +
           "@uf , @complemento)";

            cmd.Parameters.AddWithValue("@isPessoaJuridica", usuario.isPessoaJuridica);
            cmd.Parameters.AddWithValue("@isAdmin", usuario.isAdmin);

            cmd.Parameters.AddWithValue("@nome", usuario.informacaoPessoal.nome);
            cmd.Parameters.AddWithValue("@cnpj", usuario.informacaoPessoal.cnpj !=null ? usuario.informacaoPessoal.cnpj : "" );
            cmd.Parameters.AddWithValue("@cpf", usuario.informacaoPessoal.cpf != null ? usuario.informacaoPessoal.cpf : "");
            cmd.Parameters.AddWithValue("@telefone", usuario.informacaoPessoal.telefone);

            cmd.Parameters.AddWithValue("@login", usuario.informacaoLogin.login);
            cmd.Parameters.AddWithValue("@senha", usuario.informacaoLogin.senha);

            cmd.Parameters.AddWithValue("@cep", usuario.endereco.cep);
            cmd.Parameters.AddWithValue("@cidade", usuario.endereco.cidade);
            cmd.Parameters.AddWithValue("@bairro", usuario.endereco.bairro);
            cmd.Parameters.AddWithValue("@uf", usuario.endereco.uf);
            cmd.Parameters.AddWithValue("@complemento", usuario.endereco.complemento != null ? usuario.endereco.complemento : "");
            cmd.Parameters.AddWithValue("@endereco", usuario.endereco.endereco);


            try
                {
                    cmd.Connection = con.conectar();
                     cmd.ExecuteNonQuery();

                }
                catch (SqlException)
                {
                    this.mensagem = "Erro com Banco de Dados! ";
                }
            

            return mensagem;
        }
    }
}
