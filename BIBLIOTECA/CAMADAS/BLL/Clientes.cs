using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA.CAMADAS.BLL
{
    public class Clientes
    {
        public List<MODEL.Clientes> Select()
        {
            DAL.Clientes DalCliente = new DAL.Clientes();
            return DalCliente.Select();
        }
        public List<MODEL.Clientes> SelectbyID(int ID)
        {
            DAL.Clientes DalCliente = new DAL.Clientes();
            return DalCliente.SelectbyID(ID);
        }
        public MODEL.Clientes SelectID(int ID)
        {
            DAL.Clientes DalCliente = new DAL.Clientes();
            return DalCliente.SelectID(ID);
        }
        public List<MODEL.Clientes> SelectNome(string NOME)
        {
            DAL.Clientes DalCliente = new DAL.Clientes();
            return DalCliente.SelectNome(NOME);
        }
        public void Inserir(MODEL.Clientes cliente)
        {
            DAL.Clientes DalCliente = new DAL.Clientes();
            DalCliente.Select();
        }
        public void UPDATE(MODEL.Clientes cliente)
        {
            DAL.Clientes DalCliente = new DAL.Clientes();
            DalCliente.Select();
        }
        public void Delete(int IDCliente)
        {
            DAL.Clientes DalCliente = new DAL.Clientes();
            DalCliente.Select();
        }
    }
}
