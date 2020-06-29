using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA.CAMADAS.Relatório
{
    class Relatorio_Revista
    {
        public static void RelProdutoRevistas()
        {
            CAMADAS.BLL.Revista revista = new CAMADAS.BLL.Revista();
            List<CAMADAS.MODEL.Revista> LstRevista = new List<MODEL.Revista>();
            LstRevista = revista.Select();

            string pasta = Funcoes.DiretorioPasta();
            string arquivo = pasta + @"\RelRevista_" + DateTime.Now.ToShortDateString().Replace("/", "_") + "_" + DateTime.Now.ToLongTimeString().Replace(":", "_") + ".html";

            StreamWriter sw = new StreamWriter(arquivo);
            using (sw)
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine("<meta http-equiv='Content-Type' " +
                            "content='text/html; charset=utf-8'/>");
                sw.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css' integrity='sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T' crossorigin='anonymous'>");

                sw.WriteLine("</head>");

                sw.WriteLine("<body>");
                sw.WriteLine("<p>");
                sw.WriteLine("<font size '30'  face='Georgia'>");
                sw.WriteLine("<h1>Relatório de Revistas</h1>");
                sw.WriteLine("</font>");
                sw.WriteLine("</p>");
                sw.WriteLine("<hr align='left' border:'5px' />");
                sw.WriteLine("<table class='table table-striped'>");
                //Cabeçalho da tabela
                sw.WriteLine("<tr align='right'>");
                sw.WriteLine("<th align='right' width='30px'>");
                sw.WriteLine("ID");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='250px'>");
                sw.WriteLine("TITULO");
                sw.WriteLine("</th>");
                sw.WriteLine("<th  align='right' width='150px'>");
                sw.WriteLine("AUTOR");
                sw.WriteLine("</th>");
                sw.WriteLine("<th  align='right' width='150px'>");
                sw.WriteLine("Valor");
                sw.WriteLine("</th>");
                sw.WriteLine("<th  align='right' width='150px'>");
                sw.WriteLine("SITUAÇÂO");
                sw.WriteLine("</th>");

                int cont = 0;
                float soma = 0;
                foreach (CAMADAS.MODEL.Revista Revista in LstRevista.OrderBy(o => o.ID).OrderBy(t => t.TITULO))
                {
                    //Completando a tabela com os itens do banco
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td align='right' width='30px'>");
                    sw.WriteLine(Revista.ID);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='right' width='150px'>");
                    sw.WriteLine(Revista.TITULO);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='right' width='150px'>");
                    sw.WriteLine(Revista.EDITORA);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td  align='right' width='150px'>");
                    sw.WriteLine(string.Format("{0:C2}", Revista.VALOR));
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td  align='right' width='150px'>");
                    sw.WriteLine(Revista.SITUACAO);
                    sw.WriteLine("</td>");
                    soma = soma + Revista.VALOR;
                    cont++;

                }
                //Rodapé
                sw.WriteLine("</table>");
                sw.WriteLine("<hr align='left' border:'5px' />");
                sw.WriteLine("<h3>");
                sw.WriteLine("<p>");
                sw.WriteLine("<font size '30'  face='Georgia'>");
                sw.WriteLine("Total de Revistas Cadastrados: " + cont.ToString());
                sw.WriteLine("</br>");
                sw.WriteLine("Valor total das Revistas R$: " + string.Format("{0:#.#,0}", soma));
                sw.WriteLine("</font>");
                sw.WriteLine("</p>");
                sw.WriteLine("</body>");
                sw.WriteLine("</h3>");
                sw.WriteLine("</html>");
            }
            System.Diagnostics.Process.Start(arquivo);
        }
    }
}
