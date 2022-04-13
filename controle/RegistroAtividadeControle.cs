using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartSolutionSystem.dao;
using SmartSolutionSystem.model;

namespace SmartSolutionSystem.controle
{
    public class RegistroAtividadeControle
    {
        public RegistroAtividade registro;
        public string mensagem = "";

        public void cadastrar(RegistroAtividade novaAtividade)
        {
            RegistroAtividadeDao registroAtividadeDao = new RegistroAtividadeDao();

            registroAtividadeDao.cadastrar(novaAtividade);
            if (!registroAtividadeDao.mensagem.Equals(""))
            {
                this.mensagem = registroAtividadeDao.mensagem;
            }
           

        }

    }
}
