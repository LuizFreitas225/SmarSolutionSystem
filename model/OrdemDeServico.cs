using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSolutionSystem.model
{
    public class OrdemDeServico
    {
        public int id { get; set; }
        public bool concluido { get; set; }
        public Usuario usuario { get; set; }
        public float valor { get; set; }
        public DateTime dataCriacao { get; set; }
        public string descricao { get; set; }
        public string eletronico { get; set; }

        public bool setVDataCriacaoIfNotEmpty(DateTime value)
        {
            if (value != null)
            {
                dataCriacao = value;
                return true;

            }
            return false;

        }
        public bool setEletronicoIfNotEmpty(string value)
        {
            if (!String.IsNullOrEmpty(value))
            {
                eletronico = value;
                return true;

            }
            return false;

        }
        public bool setVDescricaoIfNotEmpty(string value)
        {
            if (!String.IsNullOrEmpty(value))
            {
                descricao = value;
                return true;

            }
            return false;

        }
      
        
      
    }
}
