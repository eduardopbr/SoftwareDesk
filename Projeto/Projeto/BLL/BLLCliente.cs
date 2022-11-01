using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Projeto.Modelo;
using Projeto.DAL;



namespace Projeto.BLL
{
    public class BLLCliente
    {
        private DALConexao conexao;
        public BLLCliente(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Cadastrar(ModeloCliente modelo)
        {
            if (modelo.CliNome.Trim().Length == 0)
            {
                throw new Exception("O nome do usuário(a) é obrigatório");
            }

            //*****VALIDACAO PARA EMAIL*****
            string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}"
            + "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\"
            + ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$";
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(modelo.CliEmail))
            {
                throw new Exception("Digite um email válido.");
            }

            if (Validacao.IsCpf(modelo.CliCpf) == false)
            {
                throw new Exception("O CPF informado é inválido");
            }

            if (modelo.CliTelefone.Trim().Length == 0)
            {
                throw new Exception("O número de telefone é obrigatório");
            }

            if (modelo.CliTelefone.Trim().Length >= 1 && modelo.CliTelefone.Trim().Length < 15 || modelo.CliTelefone.Trim().Length > 15)
            {
                throw new Exception("O número de telefone é inválido");
            }

            if (modelo.CliEstado.Trim().Length == 0)
            {
                throw new Exception("O estado é obrigatório");
            }

            if (modelo.CliCidade.Trim().Length == 0)
            {
                throw new Exception("A cidade é obrigatório");
            }

            DALCliente u = new DALCliente(conexao);
            u.Cadastrar(modelo);
        }
    }
}
