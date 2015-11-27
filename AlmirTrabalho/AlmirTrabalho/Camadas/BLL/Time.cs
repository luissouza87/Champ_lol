using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmirTrabalho.Camadas.BLL
{
    public class Time
    {
        public List<MODEL.time> Select()
        {
            DAL.Time dalTime = new DAL.Time();
            // escrever regras de negócios
            return dalTime.Select();
        }

        public List<MODEL.time> Selectbynome (string nome)
        {
            DAL.Time dalTime = new DAL.Time();
            // escrever regras de negócios
            return dalTime.Selectbynome(nome);
        }

        public List<MODEL.time> SelectById(int id)
        {
            DAL.Time dalTime = new DAL.Time();
            // escrever regras de negócios
            return dalTime.SelectById(id);
        }

        public void Insert(MODEL.time Time)
        {
            DAL.Time dalTime = new DAL.Time();
            //regras de negocio
            dalTime.Insert(Time);
        }

        public void Update(MODEL.time Time)
        {
            DAL.Time dalTime = new DAL.Time();
            //regras de negócio
            dalTime.Update(Time);
        }

        public void Delete(MODEL.time Time)
        {
            DAL.Time dalTime = new DAL.Time();
            // regras de negócio
            dalTime.Delete(Time);
        }
    }
}
