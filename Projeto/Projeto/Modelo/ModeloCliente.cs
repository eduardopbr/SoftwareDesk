using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Modelo
{
    public class ModeloCliente
    {
        public ModeloCliente()
        {
            this.CliCod = 0;
            this.CliNome = "";
            this.CliCpf = "";
            this.CliTelefone = "";
            this.CliEstado = "";
            this.CliCidade = "";
            this.CliSexo = "feminino";
            this.CliEmail = "";
        }

        public ModeloCliente(int cod, string nome, string cpf, 
            string telefone, string estado, string cidade, string sexo, string email)
        {
            this.CliCod = cod;
            this.CliNome = nome;
            this.CliCpf = cpf;
            this.CliEstado = estado;
            this.CliCidade = cidade;
            this.CliSexo = sexo;
            this.CliEmail = email;
        }

        private int cliCod;
        public int CliCod
        {
            get { return this.cliCod; }
            set { this.cliCod = value; }
        }

        private string cliNome;
        public string CliNome
        {
            get { return this.cliNome; }
            set { this.cliNome = value; }
        }

        private string cliCpf;
        public string CliCpf
        {
            get { return this.cliCpf; }
            set { this.cliCpf = value; }
        }

        private string cliTelefone;
        public string CliTelefone
        {
            get { return this.cliTelefone; }
            set { this.cliTelefone = value; }
        }

        private string cliEstado;
        public string CliEstado
        {
            get { return this.cliEstado; }
            set { this.cliEstado = value; }
        }

        private string cliCidade;
        public string CliCidade
        {
            get { return this.cliCidade; }
            set { this.cliCidade = value; }
        }

        private string cliSexo;
        public string CliSexo
        {
            get { return this.cliSexo; }
            set { this.cliSexo = value; }
        }

        private string cliEmail;
        public string CliEmail
        {
            get { return this.cliEmail; }
            set { this.cliEmail = value; }
        }
    }
}
