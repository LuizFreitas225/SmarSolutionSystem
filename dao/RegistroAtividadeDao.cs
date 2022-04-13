using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartSolutionSystem.model;
using SmartSolutionSystem.util;

namespace SmartSolutionSystem.dao
{
    public class RegistroAtividadeDao { 

        public RegistroAtividadeDao() { }

        RegistroAtividade registroAtividade;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public String cadastrar(RegistroAtividade registroAtividade)
    {
        //comandos para inserir no BD
        //comandos sql para verificar se tem no banco

        cmd.CommandText = "INSERT INTO dbo.RESGISTRO_ATIVIDADE " +
        "(TIPO,HORARIO,USUARIO_ID) " +
        "  VALUES ( @tipo,@horario, @usuarioId )";

        cmd.Parameters.AddWithValue("@tipo", TipoAtividadeUtil.valueOf(registroAtividade.tipoAtivide));
        cmd.Parameters.AddWithValue("@horario", registroAtividade.horario);
        cmd.Parameters.AddWithValue("@usuarioId", registroAtividade.usuario.id);





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
