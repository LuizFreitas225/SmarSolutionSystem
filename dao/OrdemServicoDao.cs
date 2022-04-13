using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartSolutionSystem.model;

namespace SmartSolutionSystem.dao
{
    public class RegistroAtividadeDAO
    {

        
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public String cadastrar(OrdemDeServico ordemServico )
        {
            //comandos para inserir no BD
            //comandos sql para verificar se tem no banco
            
           cmd.CommandText = "INSERT INTO dbo.ORDEM_SERVICO " +
           "(IS_CONCLUIDO,USUARIO_ID ,VALOR ,DATA,ELETRONICO ,DESCRICAO) " +
           "  VALUES ( @concluido,@usuarioId, @valor , @dataCriacao , @eletronico , @descricao)";

            cmd.Parameters.AddWithValue("@concluido", ordemServico.concluido);
            cmd.Parameters.AddWithValue("@usuarioId", ordemServico.usuario.id);
            cmd.Parameters.AddWithValue("@valor", ordemServico.valor);
            cmd.Parameters.AddWithValue("@dataCriacao", ordemServico.dataCriacao);
            cmd.Parameters.AddWithValue("@eletronico", ordemServico.eletronico);
            cmd.Parameters.AddWithValue("@descricao", ordemServico.descricao);





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
        public List<OrdemDeServico> find()
        {
            //comandos sql para verificar se tem no banco
            cmd.CommandText = "select * FROM [dbo].[ORDEM_SERVICO] ";
            List<OrdemDeServico> listaOS
                = new List<OrdemDeServico>();
            OrdemDeServico ordemDeServico = new OrdemDeServico();

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();



                while (dr.Read())
                {
                    ordemDeServico = new OrdemDeServico();


                    ordemDeServico.id = dr.GetInt32(dr.GetOrdinal("ID"));

                    ordemDeServico.concluido = dr.GetBoolean(dr.GetOrdinal("IS_CONCLUIDO"));
                    ordemDeServico.valor = dr.GetInt32(dr.GetOrdinal("VALOR"));
                    ordemDeServico.dataCriacao = dr.GetDateTime(dr.GetOrdinal("DATA"));
                    ordemDeServico.eletronico = dr.GetString(dr.GetOrdinal("ELETRONICO"));
                    ordemDeServico.descricao = dr.GetString(dr.GetOrdinal("DESCRICAO"));

                    ordemDeServico.usuario = new UsuarioDao().findById(dr.GetInt32(dr.GetOrdinal("USUARIO_ID")));





                    listaOS.
                        Add(ordemDeServico);
                }


            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados! ";
            }


            return listaOS;
        }

    }
}
