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
    public class DALCliente
    {
        private DALConexao conexao;
        public DALCliente(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Cadastrar(ModeloCliente modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "INSERT INTO CadastroCli(nomeCli, emailCli, estadoCli," +
                " cidadeCli, cpfCli, sexoCli) VALUES (@nomeCli, @emailCli, @estadoCli," +
                " @cidadeCli, @cpfCli, @sexoCli); select @@IDENTITY;";

            cmd.Parameters.AddWithValue("@nomeCli", modelo.CliNome);
            cmd.Parameters.AddWithValue("@emailCli", modelo.CliEmail);
            cmd.Parameters.AddWithValue("@estadoCli", modelo.CliEstado);
            cmd.Parameters.AddWithValue("@cidadeCli", modelo.CliCidade);
            cmd.Parameters.AddWithValue("@cpfCli", modelo.CliCpf);
            cmd.Parameters.AddWithValue("@sexoCli", modelo.CliSexo);

            conexao.Conectar();
            modelo.CliCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
    }
}
