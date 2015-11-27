using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmirTrabalho.Camadas.MODEL
{
    public class Jogadores
    {
        //encapsulado mesmo estando com public 
        public int id { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public string nickname { get; set; }
        public int time { get; set; }
        public int idTime { get; set; }
    }
}
