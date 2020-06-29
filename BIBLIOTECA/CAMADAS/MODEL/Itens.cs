using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA.CAMADAS.MODEL
{
    public class Itens
    {
        public int ID { get; set; }
        public int EMPRESTIMO_ID { get; set; }
        public int LIVRO_ID { get; set; }
        public DateTime ENTREGA { get; set; }
    }
}
