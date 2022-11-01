using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Modelo
{
    public class ModeloUsuario
    {
        public ModeloUsuario()
        {
            this.UsuCod = 0;
            this.UsuNome = "";
            this.UsuEmail = "";
            this.UsuSenha = "";
            this.UsuCpf = "";
            this.UsuConfirm = "";
        }

        public ModeloUsuario(int cod, string nome, string email, string senha, string Cpf, string confirm)
        {
            this.UsuCod = cod;
            this.UsuNome = nome; 
            this.UsuEmail = email; 
            this.UsuSenha = senha;
            this.UsuCpf = Cpf;
            this.UsuConfirm = confirm;
        }

        private string usuNome;
        public string UsuNome 
        { 
            get { return this.usuNome; }
            set { this.usuNome = value; }
        }

        private string usuEmail;
        public string UsuEmail
        {
            get { return this.usuEmail; }
            set { this.usuEmail = value; }
        }

        private string usuSenha;
        public string UsuSenha
        {
            get { return this.usuSenha; }
            set { this.usuSenha = value; }
        }

        private string usuCpf;
        public string UsuCpf
        {
            get { return this.usuCpf; }
            set { this.usuCpf = value; }
        }

        private int usuCod;
        public int UsuCod
        {
            get { return this.usuCod; }
            set { this.usuCod = value; }
        }

        private string usuConfirm;
        public string UsuConfirm
        {
            get { return this.usuConfirm; }
            set { this.usuConfirm = value; }
        }
    }
}
