using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA.CAMADAS.BLL
{
    public class Livros
    {
        public List<MODEL.Livros> Select()
        {
            DAL.Livros DalLivros = new DAL.Livros();
           return DalLivros.Select();
        }
        public List<MODEL.Livros> SelectID(int ID)
        {
            DAL.Livros DalLivros = new DAL.Livros();
            return DalLivros.SelectID(ID);
        }
        public List<MODEL.Livros> SelectTitulo(string TITULO)
        {
            DAL.Livros DalLivros = new DAL.Livros();
            return DalLivros.SelectTitulo(TITULO);
        }
        public void Inserir(MODEL.Livros livros)
        {
            DAL.Livros DalLivros = new DAL.Livros();
            DalLivros.Select();
        }
        public void UPDATE(MODEL.Livros livros)
        {
            DAL.Livros DalLivros = new DAL.Livros();
            DalLivros.Select();
        }
        public void Delete(int IDLivros)
        {
            DAL.Livros DalLivros = new DAL.Livros();
            DalLivros.Select();
        }
    }
}
