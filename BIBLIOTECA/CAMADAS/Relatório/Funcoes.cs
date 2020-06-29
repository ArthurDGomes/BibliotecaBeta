using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BIBLIOTECA.CAMADAS.Relatório
{
    class Funcoes
    {
        public static string DiretorioPasta()
        {
            string pasta = @"c:\RELADS";
            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            return pasta;
        }
    }
}
