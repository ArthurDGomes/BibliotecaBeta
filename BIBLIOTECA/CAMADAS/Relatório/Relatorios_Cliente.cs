using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BIBLIOTECA.CAMADAS;

namespace BIBLIOTECA.CAMADAS.Relatório
{
    class Relatorios_Cliente
    {
        public static void RelProduto()
        {
            CAMADAS.BLL.Clientes clientes = new CAMADAS.BLL.Clientes();
            List<CAMADAS.MODEL.Clientes> LstCli = new List<MODEL.Clientes>();
            LstCli = clientes.Select();

            string pasta = Funcoes.DiretorioPasta();
            string arquivo = pasta + @"\RelClientes_" + DateTime.Now.ToShortDateString().Replace("/", "_") + "_" + DateTime.Now.ToLongTimeString().Replace(":", "_") + ".html";

            StreamWriter sw = new StreamWriter(arquivo);
            using (sw)
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine("<meta http-equiv='Content-Type' " +
                            "content='text/html; charset=utf-8'/>");
                sw.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css' integrity='sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T' crossorigin='anonymous'>");

                sw.WriteLine("</head>");
                //Título da tabela
                sw.WriteLine("<body>");
                sw.WriteLine("<p>");
                sw.WriteLine("<font size '30'  face='Georgia'>");
                sw.WriteLine("<h1>Relatório de Clientes</h1>");
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
                sw.WriteLine("NOME");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='150px'>");
                sw.WriteLine("CURSO");
                sw.WriteLine("</th>");
                sw.WriteLine("<th  align='right' width='150px'>");
                sw.WriteLine("DIAS");
                sw.WriteLine("</th>");
                sw.WriteLine("<th  align='right' width='150px'>");
                sw.WriteLine("MULTA");
                sw.WriteLine("</th>");

                int cont = 0;
                float soma = 0;
                foreach (CAMADAS.MODEL.Clientes cliente in LstCli.OrderBy(o => o.NOME))
                {
                    //Completando a tabela com os itens do banco
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td align='right' width='30px'>");
                    sw.WriteLine(cliente.ID);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='right' width='150px'>");
                    sw.WriteLine(cliente.NOME);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='right' width='150px'>");
                    sw.WriteLine(cliente.CURSO);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td  align='right' width='150px'>");
                    sw.WriteLine(cliente.DIAS);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td  align='right' width='150px'>");
                    sw.WriteLine(string.Format("{0:C2}", cliente.MULTA));
                    sw.WriteLine("</td>");
                    soma = soma + cliente.MULTA;
                    cont++;

                }
                //Rodapé
                sw.WriteLine("</table>");
                sw.WriteLine("<hr align='left' border:'5px' />");
                sw.WriteLine("<h3>");
                sw.WriteLine("<p>");
                sw.WriteLine("<font size '30'  face='Georgia'>");
                sw.WriteLine("Total de Clientes Cadastrados: " + cont.ToString());
                sw.WriteLine("</br>");
                sw.WriteLine("Valor total das Multas R$: " + string.Format("{0:#.#,0}", soma));
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
