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

        public void Insert(MODEL.campeonato Campeonato)
        {
            DAL.campeonato dalProd = new DAL.campeonato();
            //regras de negocio
            dalProd.Insert(Campeonato);
        }

        public void Update(MODEL.campeonato Campeonato)
        {
            DAL.campeonato dalProd = new DAL.campeonato();
            //regras de negócio
            dalProd.Update(Campeonato);
        }

        public void Delete(MODEL.campeonato Campeonato)
        {
            DAL.campeonato dalProd = new DAL.campeonato();
            // regras de negócio
            dalProd.Delete(Campeonato);
        }
    }
}
