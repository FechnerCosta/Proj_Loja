using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using Loja.DAL;
using Loja.Modelos;


namespace Loja.BLL
{
    public class VendasBLL
    {
        //este e um campo privado para armazenar uma instancia de classe DAL
        private VendasDAL objDal;

        //esse é um constructor da classe VendasBLL
        public VendasBLL()
        {
            objDal = new VendasDAL();
        }

        public DataTable ListaDeProdutos
        {
            get
            {
                return objDal.ListaDeProdutos;
            }
        }
        public DataTable ListaDeClientes
        {
            get
            {
                return objDal.ListaDeClientes;
            }
        }



        public DataTable Listagem(string filtro)
        {
            VendasDAL obj = new VendasDAL();
            return obj.Listagem(filtro);
        }
   

        public void Incluir (VendaInformation venda)
        {
            objDal.Incluir(venda);
        }

        public void Excluir(int codigo)
        {
            if (codigo < 1)
            {
                throw new Exception("Selecione uma venda antes de excluir");
            }
            VendasDAL obj = new VendasDAL();
            obj.Excluir(codigo);
        }

        public static decimal CalcularValor(int id, int quantidade)
        {
            ProdutoInformation obj = new ProdutoInformation();
            obj = VendasDAL.getWithId(id);
            return obj.Preco * quantidade;
        }
    }
}
