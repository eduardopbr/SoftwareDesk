using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Modelo
{
    public class ModeloFornecedor
    {
        public ModeloFornecedor()
        {
            this.FCod = 0;
            this.FNome = "";
            this.FRazao = "";
            this.FValor = 0.00;
            this.FCnpj = 0;
        }

        public ModeloFornecedor(int cod, string nome, string razao, double valor, int cnpj) 
        {
            FCod = cod;
            FNome = nome;
            FRazao = razao;
            FValor = valor;
            FCnpj = cnpj;
        }

        private int fCod;
        public int FCod
        {
            get { return this.fCod; }
            set { fCod = value; }
        }

        private string fNome;
        public string FNome
        {
            get { return this.fNome; }
            set { fNome = value; }
        }

        private string fRazao;
        public string FRazao
        {
            get { return this.fRazao; }
            set { fRazao = value; }
        }

        private double fValor;
        public double FValor
        {
            get { return this.fValor;}
            set { fValor = value; }
        }

        private int fCnpj;
        public int FCnpj
        {
            get { return this.fCnpj; }
            set { fCnpj = value; }
        }
    }
}
