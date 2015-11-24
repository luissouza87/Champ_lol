using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmirTrabalho.Camadas.DAL // chamando os metodos para deletar , inserir , atualizar e mostrar
{                                   // as tabelas
    public class campeonato
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.campeonato> Select()
        {
            List<MODEL.campeonato> listaCamp = new List<MODEL.campeonato>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from CAMPEONATO;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.campeonato campeonato = new MODEL.campeonato();
                    campeonato.id = Convert.ToInt32(reader[0].ToString());
                    campeonato.nome = (reader["nome"].ToString());
                    campeonato.capacidade = Convert.ToInt32(reader["capacidade"].ToString());
                    campeonato.local = (reader["local"].ToString());
                    campeonato.premiacao = (reader["premiacao"].ToString());
                    listaCamp.Add(campeonato);
                }
            }
            catch
            {
                Console.WriteLine("Erro na Seleção");
            }
            finally
            {
                conexao.Close();
            }
            return listaCamp;
        }
        public void Insert(MODEL.campeonato Campeonato) {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into CAMPEONATO values (@nome, @cap , @loc , @premium)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("nome", Campeonato.nome);
            cmd.Parameters.AddWithValue("cap", Campeonato.capacidade);
            cmd.Parameters.AddWithValue("loc", Campeonato.local);
            cmd.Parameters.AddWithValue("premium", Campeonato.premiacao);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na Inserção");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
