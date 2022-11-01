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


namespace Projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloUsuario modelo = new ModeloUsuario();
                modelo.UsuEmail = txtEmail.Text;
                modelo.UsuSenha = txtSenha.Text;

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);

                bll.Login(modelo);
                MessageBox.Show("Logado com sucesso!");

                FrmInicial f = new FrmInicial();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            
        }
    }
}
