using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA.CAMADAS.MODEL
{
    public class Revista
    {
        public int ID { get; set; }

        public string TITULO { get; set; }

        public string EDITORA { get; set; }

        public float VALOR { get; set; }

        public int SITUACAO { get; set; }
    }
}
