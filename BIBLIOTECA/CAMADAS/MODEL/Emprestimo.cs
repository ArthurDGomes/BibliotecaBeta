using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA.CAMADAS.MODEL
{
    public class Emprestimo
    {
        public int ID { get; set; }
        public int CLIENTE_ID { get; set; }
        public string NOME_CLI { get; set; }
        public DateTime DATA { get; set; }

    }
}
