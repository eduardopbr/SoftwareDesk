using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.DAL
{
    public class DadosDaConexao
    {
        public static String servidor = @"DESKTOP-7SK45J5\SQLEXPRESS";
        public static String banco = "Projeto";

        public static String StringDeConexao
        {
            get
            {
                return @"Data Source=DESKTOP-7SK45J5;Initial Catalog=Projeto;Integrated Security=True";
            }
        }
    }
}
