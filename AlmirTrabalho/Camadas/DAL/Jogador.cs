using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmirTrabalho.Camadas.DAL
{
    public class Jogador
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Jogadores> Select()//criação da funcao select no banco
        {
            List<MODEL.Jogadores> listaJogadores = new List<MODEL.Jogadores>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from JOGADOR;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Jogadores Jogador = new MODEL.Jogadores();
                    Jogador.id = Convert.ToInt32(reader[0].ToString());
                    Jogador.nome = (reader["nome"].ToString());
                    Jogador.idade = Convert.ToInt32(reader["idade"].ToString());
                    Jogador.nickname = (reader["nickname"].ToString());
                    Jogador.idTime = Convert.ToInt32(reader["idTime"].ToString());
                    listaJogadores.Add(Jogador);
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
            return listaJogadores;
        }

        public List<MODEL.Jogadores> SelectPorNome(string nome)
        {
            List<MODEL.Jogadores> listaJogadores = new List<MODEL.Jogadores>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from JOGADOR where (nome like @nome);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", nome.Trim() + "%");
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Jogadores Jogador = new MODEL.Jogadores();
                    Jogador.id = Convert.ToInt32(reader[0].ToString());
                    Jogador.nome = (reader["nome"].ToString());
                    Jogador.idade = Convert.ToInt32(reader["idade"].ToString());
                    Jogador.nickname = (reader["nickname"].ToString());
                    Jogador.idTime = Convert.ToInt32(reader["idTime"].ToString());
                    listaJogadores.Add(Jogador);
                }
            }
            catch
            {
                Console.WriteLine("Erro na Seleção do Nome");
            }
            finally
            {
                conexao.Close();
            }
            return listaJogadores;
        }

        public void Insert(MODEL.Jogadores Jogador)
        {//criação do insert no banco
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into JOGADOR values (@nome, @idade , @nickname , @idTime)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("nome", Jogador.nome);
            cmd.Parameters.AddWithValue("idade", Jogador.idade);
            cmd.Parameters.AddWithValue("nickname", Jogador.nickname);
            cmd.Parameters.AddWithValue("idTime", Jogador.idTime);
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
        public void Update(MODEL.Jogadores Jogador)//função update
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update JOGADOR set nome=@nome,idade=@idade , nickname=@nickname ";
            sql += " where cod=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", Jogador.id);
            cmd.Parameters.AddWithValue("@nome", Jogador.nome);
            cmd.Parameters.AddWithValue("@idade", Jogador.idade);
            cmd.Parameters.AddWithValue("@nickname", Jogador.nickname);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro no Update");
            }
            finally
            {
                conexao.Close();
            }
        }
        public void Delete(MODEL.Jogadores Jogador)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "delete from JOGADOR where cod=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("id", Jogador.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na Remoção");
            }
            finally
            {
                conexao.Close();
            }
        }

        public List<MODEL.Jogadores> SelectPorNick (string nickname)
        {
            List<MODEL.Jogadores> listaJogadores = new List<MODEL.Jogadores>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from JOGADOR where (nickname like @nickname);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nickname", nickname.Trim() + "%");
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Jogadores Jogador = new MODEL.Jogadores();
                    Jogador.id = Convert.ToInt32(reader[0].ToString());
                    Jogador.nome = (reader["nome"].ToString());
                    Jogador.idade = Convert.ToInt32(reader["idade"].ToString());
                    Jogador.nickname = (reader["nickname"].ToString());
                    Jogador.idTime = Convert.ToInt32(reader["idTime"].ToString());
                    listaJogadores.Add(Jogador);
                }
            }
            catch
            {
                Console.WriteLine("Erro na Seleção do Nome");
            }
            finally
            {
                conexao.Close();
            }
            return listaJogadores;
        }
    }
}
