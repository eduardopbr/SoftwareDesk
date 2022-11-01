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
    public partial class FrmCadastroCliente : Form
    {
        public FrmCadastroCliente()
        {
            InitializeComponent();
        }

        public void Formatar(TextBox txtTexto)
        {
            txtTexto.MaxLength = 14;//(046)9.9118.3495
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

        public void FormatarTelefone(TextBox txtTexto)
        {
            txtTexto.MaxLength = 15;
            if (txtTexto.Text.Length == 0)
            {
                txtTexto.Text = txtTexto.Text + "(";
                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
            }
            else if (txtTexto.Text.Length == 3)
            {
                txtTexto.Text = txtTexto.Text + ")";
                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
            }
            else if(txtTexto.Text.Length == 5)
            {
                txtTexto.Text = txtTexto.Text + "-";
                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
            }
            else if (txtTexto.Text.Length == 10)
            {
                txtTexto.Text = txtTexto.Text + "-";
                txtTexto.SelectionStart = txtTexto.Text.Length + 1;
            }  
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8)
            {
                Formatar(txtCpf);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)//compara se é numero e habilita o backspace//8 valor da backspace na tabela ask
                e.Handled = true;//volta verdadeiro e não faz nada ou seja não é numero
            if (e.KeyChar != (char)8)
            {
                FormatarTelefone(txtTelefone);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloCliente modelo = new ModeloCliente();
                modelo.CliNome = txtNome.Text;
                modelo.CliCpf = txtCpf.Text;
                modelo.CliTelefone = txtTelefone.Text;
                modelo.CliCidade = txtCidade.Text;
                modelo.CliEstado = txtEstado.Text;
                modelo.CliEmail = txtEmail.Text;

                if(rbFeminino.Checked)
                {
                    modelo.CliSexo = "Feminino";
                }
                else
                {
                    modelo.CliSexo = "Masculino";
                }

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                bll.Cadastrar(modelo);
                MessageBox.Show("O cliente foi cadastrado com sucesso");

                txtNome.Text = "";
                txtEmail.Text = "";
                txtTelefone.Text = "";
                txtCidade.Text = "";
                txtEstado.Text = "";
                txtCpf.Text = "";
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
