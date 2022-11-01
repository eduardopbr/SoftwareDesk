using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Projeto.Modelo;
using Projeto.DAL;
using Projeto.BLL;

namespace Projeto.Views
{
    public partial class FrmCadastroUsuario : Form
    {
        public FrmCadastroUsuario()
        {
            InitializeComponent();
            
        }

        public void Formatar(TextBox txtTexto)
        {
            txtTexto.MaxLength = 14;
            if (txtTexto.Text.Length == 3)
            {
                txtTexto.Text = txtTexto.Text + ".";
                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
            }
            else if (txtTexto.Text.Length == 7)
            {
                txtTexto.Text = txtTexto.Text + ".";
                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
            }
            else if (txtTexto.Text.Length == 11)
            {
                txtTexto.Text = txtTexto.Text + "-";
                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
            }
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            try
            {
                ModeloUsuario modelo = new ModeloUsuario();
                modelo.UsuNome = txtNome.Text;
                modelo.UsuEmail = txtEmail.Text;
                modelo.UsuSenha = txtSenha.Text;
                modelo.UsuCpf = txtCpf.Text;
                modelo.UsuConfirm = txtConfirmarSenha.Text;

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);

                bll.Cadastrar(modelo);
                MessageBox.Show("O usuário foi cadastrado com sucesso");

                txtNome.Text = "";
                txtEmail.Text = "";
                txtSenha.Text = "";
                txtConfirmarSenha.Text = "";
                txtCpf.Text = "";
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }


        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8)
            {
                Formatar(txtCpf);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
