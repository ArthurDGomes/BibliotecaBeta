using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA.CAMADAS.MODEL
{
    public class Clientes
    {
        public int ID { get; set; }
        public string NOME { get; set; }
        public string CURSO { get; set; }
        public int DIAS { get; set; }
        public float MULTA { get; set; }
    }
}
