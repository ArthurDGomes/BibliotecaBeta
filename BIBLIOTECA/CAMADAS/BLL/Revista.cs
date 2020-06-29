using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA.CAMADAS.BLL
{
    public class Revista
    {
        public List<MODEL.Revista> Select()
        {
            DAL.Revista DalRevista = new DAL.Revista();
            //Verificar fazer regras de negócio.
            return DalRevista.Select();
        }
        public List<MODEL.Revista> SelectID(int ID)
        {
            DAL.Revista DalRevista = new DAL.Revista();
            //Verificar fazer regras de negócio.
            return DalRevista.SelectID(ID);
        }
        public List<MODEL.Revista> SelectTitulo(string TITULO)
        {
            DAL.Revista DalRevista = new DAL.Revista();
            //Verificar fazer regras de negócio.
            return DalRevista.SelectTitulo(TITULO);
        }
        public void Inserir(MODEL.Revista revista)
        {
            DAL.Revista DalRevista = new DAL.Revista();
            //Verificar fazer regras de negócio.
            DalRevista.Select();
        }
        public void UPDATE(MODEL.Revista revista)
        {
            DAL.Revista DalRevista = new DAL.Revista();
            //Verificar fazer regras de negócio.
            DalRevista.Select();
        }
        public void Delete(int IDRevista)
        {
            DAL.Revista DalRevista = new DAL.Revista();
            //Verificar fazer regras de negócio.
            DalRevista.Select();
        }
    }
}
