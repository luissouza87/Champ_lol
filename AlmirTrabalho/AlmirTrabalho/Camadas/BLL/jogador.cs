using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmirTrabalho.Camadas.BLL
{
    public class jogador
    {
        public List<MODEL.Jogadores> Select()
        {
            DAL.Jogador dalJogador = new DAL.Jogador();
            // escrever regras de negócios
            return dalJogador.Select();
        }

        public List<MODEL.Jogadores> SelectPorNome(string nome)
        {
            DAL.Jogador dalJogador = new DAL.Jogador();
            // escrever regras de negócios
            return dalJogador.SelectPorNome(nome);
        }

        public List<MODEL.Jogadores> SelectPorNickname(string nickname)
        {
            DAL.Jogador dalJogador = new DAL.Jogador();
            // escrever regras de negócios
            return dalJogador.SelectPorNick(nickname);
        }

        public void Insert(MODEL.Jogadores Jogador)
        {
            DAL.Jogador dalJogador = new DAL.Jogador();
            dalJogador.Insert(Jogador);
        }

        public void Update(MODEL.Jogadores Jogador)
        {
            DAL.Jogador dalJogador = new DAL.Jogador();
            //regras de negócio
            dalJogador.Update(Jogador);
        }

        public void Delete(MODEL.Jogadores Jogador)
        {
            DAL.Jogador dalJogador = new DAL.Jogador();
            // regras de negócio
            dalJogador.Delete(Jogador);
        }
    }
}
