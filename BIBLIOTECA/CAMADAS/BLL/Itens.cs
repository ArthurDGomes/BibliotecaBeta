using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA.CAMADAS.BLL
{
    public class Itens
    {
        public List<MODEL.Itens> Select()
        {
            DAL.Itens dalItens = new DAL.Itens();
            return dalItens.Select();
        }

        public List<MODEL.Itens> SelectByEmp(int ID)
        {

            DAL.Itens dalItens = new DAL.Itens();
            return dalItens.SelectByEmp(ID);
        }

        public void Insert(MODEL.Itens item)
        {

            //regra de negócio para atualizar o livro
            BLL.Livros bllLivro = new Livros();
            List<MODEL.Livros> lstLivro = bllLivro.SelectID(item.LIVRO_ID);
            MODEL.Livros livro = lstLivro[0];
            livro.SITUACAO = 2;
            bllLivro.UPDATE(livro);

            //inserir item emprestado. 
            DAL.Itens dalItens = new DAL.Itens();
            dalItens.Inserir(item);
        }

        public void Update(MODEL.Itens item)
        {
            DAL.Itens dalItens = new DAL.Itens();
            dalItens.UPDATE(item);
        }

        public void Delete(int id)
        {
            DAL.Itens dalItens = new DAL.Itens();
            dalItens.Delete(id);
        }
    }
}
