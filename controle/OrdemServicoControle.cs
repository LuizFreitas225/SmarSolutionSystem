using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartSolutionSystem.dao;
using SmartSolutionSystem.model;

namespace SmartSolutionSystem.controle
{
    public class OrdemDeServicoControle
    {

        public OrdemDeServico ordemServico;
        public string mensagem = "";

        public void  cadastrar(OrdemDeServico novaOrdem)
        {
            RegistroAtividadeDAO ordemServicoDao = new RegistroAtividadeDAO();

            ordemServicoDao.cadastrar(novaOrdem);
            if (!ordemServicoDao.mensagem.Equals(""))
            {
                this.mensagem = ordemServicoDao.mensagem;
            }
            else
            {
                ordemServico = novaOrdem;
            }

            
        }

        public List<OrdemDeServico> find()
        {
            RegistroAtividadeDAO ordemServicoDao = new RegistroAtividadeDAO();

            List<OrdemDeServico> listaOS = ordemServicoDao.find();
            if (!ordemServicoDao.mensagem.Equals(""))
            {
                this.mensagem = ordemServicoDao.mensagem;
            }
            return listaOS;


        }


    }
}
