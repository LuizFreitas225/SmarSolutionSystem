using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSolutionSystem.dao
{
    public class Conexao
    {
        SqlConnection con;

        public Conexao()
        {
            con = new SqlConnection("Data Source=DESKTOP-RBOB4GJ\\SQLEXPRESS;Initial Catalog=SMART_SOLUTION;Integrated Security=True");
        }
        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
