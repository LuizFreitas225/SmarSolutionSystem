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

        public List<Usuario> find()
        {
            //comandos sql para verificar se tem no banco
            cmd.CommandText = "select * FROM [dbo].[USUARIO] ";
            List<Usuario> listaDeUSuarios = new List<Usuario>();

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                


                while (dr.Read())
                {
                    usuario = new Usuario();


                    usuario.id = dr.GetInt32(dr.GetOrdinal("ID"));

                    usuario.isPessoaJuridica = dr.GetBoolean(dr.GetOrdinal("IS_PESSOA_JURIDICA"));
                    usuario.isAdmin= dr.GetBoolean(dr.GetOrdinal("IS_ADMIN"));

                    usuario.informacaoPessoal = new InformacaoPessoal();
                    usuario.informacaoPessoal.nome = dr.GetString(dr.GetOrdinal("NOME"));
                    usuario.informacaoPessoal.cnpj = dr.GetString(dr.GetOrdinal("CNPJ"));
                    usuario.informacaoPessoal.cpf = dr.GetString(dr.GetOrdinal("CPF"));
                    usuario.informacaoPessoal.telefone = dr.GetString(dr.GetOrdinal("TELEFONE"));

                    usuario.informacaoLogin = new InformacaoLogin();

                    usuario.informacaoLogin.senha = dr.GetString(dr.GetOrdinal("SENHA"));
                    usuario.informacaoLogin.login = dr.GetString(dr.GetOrdinal("LOGIN"));

                    usuario.endereco = new Endereco();
                    usuario.endereco.cep = dr.GetString(dr.GetOrdinal("CEP"));
                    usuario.endereco.cidade = dr.GetString(dr.GetOrdinal("CIDADE"));
                    usuario.endereco.bairro = dr.GetString(dr.GetOrdinal("BAIRRO"));
                    usuario.endereco.endereco = dr.GetString(dr.GetOrdinal("ENDERECO"));
                    usuario.endereco.uf = dr.GetString(dr.GetOrdinal("UF"));
                    usuario.endereco.complemento = dr.GetString(dr.GetOrdinal("COMPLEMENTO"));

                    listaDeUSuarios.
                        Add(usuario);
                }


            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados! ";
            }


            return listaDeUSuarios;
        }

        public Usuario findById(int id)
        {
            //comandos sql para verificar se tem no banco
            cmd.CommandText = "select * FROM [dbo].[USUARIO] where ID = @id ";
            cmd.Parameters.AddWithValue("@id",id);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();



                if (dr.Read())
                {
                    usuario = new Usuario();


                    usuario.id = dr.GetInt32(dr.GetOrdinal("ID"));

                    usuario.isPessoaJuridica = dr.GetBoolean(dr.GetOrdinal("IS_PESSOA_JURIDICA"));
                    usuario.isAdmin = dr.GetBoolean(dr.GetOrdinal("IS_ADMIN"));

                    usuario.informacaoPessoal = new InformacaoPessoal();
                    usuario.informacaoPessoal.nome = dr.GetString(dr.GetOrdinal("NOME"));
                    usuario.informacaoPessoal.cnpj = dr.GetString(dr.GetOrdinal("CNPJ"));
                    usuario.informacaoPessoal.cpf = dr.GetString(dr.GetOrdinal("CPF"));
                    usuario.informacaoPessoal.telefone = dr.GetString(dr.GetOrdinal("TELEFONE"));

                    usuario.informacaoLogin = new InformacaoLogin();

                    usuario.informacaoLogin.senha = dr.GetString(dr.GetOrdinal("SENHA"));
                    usuario.informacaoLogin.login = dr.GetString(dr.GetOrdinal("LOGIN"));

                    usuario.endereco = new Endereco();
                    usuario.endereco.cep = dr.GetString(dr.GetOrdinal("CEP"));
                    usuario.endereco.cidade = dr.GetString(dr.GetOrdinal("CIDADE"));
                    usuario.endereco.bairro = dr.GetString(dr.GetOrdinal("BAIRRO"));
                    usuario.endereco.endereco = dr.GetString(dr.GetOrdinal("ENDERECO"));
                    usuario.endereco.uf = dr.GetString(dr.GetOrdinal("UF"));
                    usuario.endereco.complemento = dr.GetString(dr.GetOrdinal("COMPLEMENTO"));

                    
                }


            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados! ";
            }


            return usuario;
        }
    }
}
