using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSolutionSystem.model
{
    public class RegistroAtividade
    {
        public int id { get; set; }
        public Usuario usuario { get; set; }
        public DateTime horario { get; set; }
        public TipoAtividade tipoAtivide { get; set; }



    }
}
