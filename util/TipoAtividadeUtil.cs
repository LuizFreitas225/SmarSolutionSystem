using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartSolutionSystem.model;

namespace SmartSolutionSystem.util
{
    public  class TipoAtividadeUtil
    {
        public static TipoAtividade valueOf(int value)
        {
            switch (value) {
                case 0:
                    return TipoAtividade.Login;
                    break;
                    
                case 1:
                    return TipoAtividade.Logoff;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
                    break;

            }

        }
        public static int valueOf(TipoAtividade value)
        {
            switch (value)
            {
                case TipoAtividade.Login:
                    return 0;
                    break;
                case TipoAtividade.Logoff:
                    return 1;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
                    break;

            }

        }
    }
}
