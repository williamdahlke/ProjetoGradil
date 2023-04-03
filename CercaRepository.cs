using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGradil
{
    public class CercaRepository
    {
        public int Id {get; internal set;}
        public double comprimento {get; internal set;}
        public double altura {get; internal set;}
        public string cor { get; internal set;}

        public string dt_confirmacao {get; internal set;}
    }

}
