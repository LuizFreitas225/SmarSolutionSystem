using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartSolutionSystem.model;

namespace SmartSolutionSystem.dao
{
    class LoginDao
    {

        Usuario usuario = null;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public Usuario verificarLogin(String login, String senha)
        {
            //comandos sql para verificar se tem no banco
            cmd.CommandText = "select * from USUARIO where login = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    usuario = new Usuario();


                    usuario.id = dr.GetInt32(dr.GetOrdinal("ID"));


                }


            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados! ";
            }
            
            UsuarioDao usuarioDao = new UsuarioDao();
            return usuarioDao.findById(usuario.id);
        }
       
    }
}
