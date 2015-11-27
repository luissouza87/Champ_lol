using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmirTrabalho.Camadas.BLL
{
    public class campeonato
    {
        public List<MODEL.campeonato> Select()
        {
            DAL.campeonato dalcamp = new DAL.campeonato();
            // escrever regras de negócios
            return dalcamp.Select();
        }

        public List<MODEL.campeonato> SelectPorPais(string local)
        {
            DAL.campeonato dalcampeonato = new DAL.campeonato();
            // escrever regras de negócios
            return dalcampeonato.SelectPorPais(local);
        }

        public void Insert(MODEL.campeonato Campeonato)
        {
            DAL.campeonato dalcamp = new DAL.campeonato();
            //regras de negocio
            dalcamp.Insert(Campeonato);
        }

        public void Update(MODEL.campeonato Campeonato)
        {
            DAL.campeonato dalcamp = new DAL.campeonato();
            //regras de negócio
            dalcamp.Update(Campeonato);
        }

        public void Delete(MODEL.campeonato Campeonato)
        {
            DAL.campeonato dalcamp = new DAL.campeonato();
            // regras de negócio
            dalcamp.Delete(Campeonato);
        }
    }
}
