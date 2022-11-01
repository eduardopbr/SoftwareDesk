using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto.Modelo;
using Projeto.DAL;
using Projeto.BLL;

namespace Projeto.Views
{
    public partial class FrmCadastroFornecedor : Form
    {
        public FrmCadastroFornecedor()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloFornecedor modelo = new ModeloFornecedor();
                modelo.FNome = txtNome.Text;
                modelo.FRazao = txtRsocial.Text;
                modelo.FValor = Convert.ToInt32(txtValor);
                modelo.FCod = Convert.ToInt32(txtCodigo);
                modelo.FCnpj = Convert.ToInt32(txtCNPJ);



            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
