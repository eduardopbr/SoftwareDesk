using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Projeto.Modelo;


namespace Projeto.DAL
{
    public class DALUsuario
    {
        private DALConexao conexao;
        public DALUsuario(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Cadastrar(ModeloUsuario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into CadastroUsu(nomeUsu, senhaUsu, cpfUsu, emailUsu)" +
                "values (@nomeUsu, @senhaUsu, @cpfUsu, @emailUsu); select @@IDENTITY;";

            cmd.Parameters.AddWithValue("@nomeUsu", modelo.UsuNome);
            cmd.Parameters.AddWithValue("@senhaUsu", modelo.UsuSenha);
            cmd.Parameters.AddWithValue("@cpfUsu", modelo.UsuCpf);
            cmd.Parameters.AddWithValue("@emailUsu", modelo.UsuEmail);

            conexao.Conectar();
            modelo.UsuCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Login(ModeloUsuario modelo)
        {
            SqlDataReader Dr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from CadastroUsu where emailUsu=@emailUsu " +
                "AND senhaUsu=@senhaUsu";

            conexao.Conectar();
            cmd.Parameters.AddWithValue("@emailUsu", modelo.UsuEmail);
            cmd.Parameters.AddWithValue("@senhaUsu", modelo.UsuSenha);

            Dr = cmd.ExecuteReader();

            if(Dr.Read())
            {

            }
            else
            {
                throw new Exception("Usuário não encontrado");
            }

            
            conexao.Desconectar();
        }
    }
}
