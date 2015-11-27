using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmirTrabalho.Camadas.DAL
{
    public class Conexao
    {
        public static string getConexao()//criando conexao com o banco de dados
        {
            return @"Data Source=DESKTOP-RC91DCS;Initial Catalog=CAMPEONATO;Integrated Security=True";
        }
    }
}