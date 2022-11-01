using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Projeto.DAL;
using Projeto.Modelo;

namespace Projeto.BLL
{
    public class BLLUsuario
    {
        private DALConexao conexao;
        public BLLUsuario(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Cadastrar(ModeloUsuario modelo)
        {
            if (modelo.UsuNome.Trim().Length == 0)
            {
                throw new Exception("O nome do usuário(a) é obrigatório");
            }

            //*****VALIDACAO PARA EMAIL*****
            string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}"
            + "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\"
            + ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$";
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(modelo.UsuEmail))
            {
                throw new Exception("Digite um email válido.");
            }

            if (modelo.UsuSenha.Trim().Length == 0)
            {
                throw new Exception("A senha do usuário(a) é obrigatório");
            }

            if (modelo.UsuSenha != modelo.UsuConfirm)
            {
                throw new Exception("As senhas devem ser iguais");
            }

            if (Validacao.IsCpf(modelo.UsuCpf) == false)
            {
                throw new Exception("O CPF informado é inválido");
            }

            DALUsuario u = new DALUsuario(conexao);
            u.Cadastrar(modelo);
        }

        public void Login(ModeloUsuario modelo)
        {
            string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}"
            + "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\"
            + ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$";
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(modelo.UsuEmail))
            {
                throw new Exception("Digite um email válido.");
            }
            if (modelo.UsuSenha.Trim().Length == 0)
            {
                throw new Exception("A senha do usuário(a) é obrigatório");
            }

            DALUsuario u = new DALUsuario(conexao);
            u.Login(modelo);
        }
    }
}
