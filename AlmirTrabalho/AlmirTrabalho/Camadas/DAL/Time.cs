using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmirTrabalho.Camadas.DAL
{
    public class Time
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.time> Select()//criação da funcao select no banco
        {
            List<MODEL.time> listaTime = new List<MODEL.time>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from TIME;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.time Time = new MODEL.time();
                    Time.id = Convert.ToInt32(reader[0].ToString());
                    Time.nome = (reader["nome"].ToString());
                    Time.criador = (reader["criador"].ToString());
                    Time.pais = (reader["pais"].ToString());
                    //Time.qt_jogadores = Convert.ToInt32(reader["qt_jogadores"].ToString());
                    listaTime.Add(Time);
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
            return listaTime;
        }

        public List<MODEL.time> SelectById(int id)
        {
            List<MODEL.time> listaTime = new List<MODEL.time>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from TIME where cod=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.time Time = new MODEL.time();
                    Time.id = Convert.ToInt32(reader[0].ToString());
                    Time.nome = (reader["nome"].ToString());
                    Time.criador = (reader["criador"].ToString());
                    Time.pais = (reader["pais"].ToString());
                    //Time.qt_jogadores = Convert.ToInt32(reader["qt_jogadores"].ToString());
                    listaTime.Add(Time);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na execução da seleção de Produtos...");
            }
            finally
            {
                conexao.Close();
            }
            return listaTime;
        }

        public List<MODEL.time> Selectbynome(string nome)
        {
            List<MODEL.time> listaTime = new List<MODEL.time>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from time where (nome like @nome);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", nome.Trim() + "%");
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.time Time = new MODEL.time();
                    Time.id = Convert.ToInt32(reader[0].ToString());
                    Time.nome = (reader["nome"].ToString());
                    Time.criador = (reader["criador"].ToString());
                    Time.pais = (reader["pais"].ToString());
                    Time.qt_jogadores = Convert.ToInt32(reader["qt_jogadores"].ToString());
                    listaTime.Add(Time);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na execução da seleção de Produtos...");
            }
            finally
            {
                conexao.Close();
            }
            return listaTime;
        }

        public void Insert(MODEL.time Time){//criação do insert no banco
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into time values (@name , @fundador , @country, @qtjogadores)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("name", Time.nome);
            cmd.Parameters.AddWithValue("fundador", Time.criador);
            cmd.Parameters.AddWithValue("country", Time.pais);
            cmd.Parameters.AddWithValue("qtjogadores", Time.qt_jogadores);
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
        public void Update(MODEL.time Time)//função update
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update TIMES set nome=@nome,criador=@criador , pais=@pais , qt_jogadores=@qtjogadores";
            sql += " where cod=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", Time.id);
            cmd.Parameters.AddWithValue("@nome", Time.nome);
            cmd.Parameters.AddWithValue("@criador", Time.criador);
            cmd.Parameters.AddWithValue("@pais", Time.pais);
            cmd.Parameters.AddWithValue("@qtjogadores", Time.qt_jogadores);
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
        public void Delete(MODEL.time Time)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "delete from TIMES where cod=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("id", Time.id);
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
    }
}

