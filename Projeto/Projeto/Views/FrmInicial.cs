using Projeto.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class FrmInicial : Form
    {
        public FrmInicial()
        {
            InitializeComponent();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroUsuario f = new FrmCadastroUsuario();
            f.ShowDialog();
            f.Dispose();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente f = new FrmCadastroCliente();
            f.ShowDialog();
            f.Dispose();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRelatorioClientes f = new FrmRelatorioClientes();
            f.ShowDialog();
            f.Dispose();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroFornecedor f = new FrmCadastroFornecedor();
            f.ShowDialog();
            f.Dispose();
        }
    }
}
