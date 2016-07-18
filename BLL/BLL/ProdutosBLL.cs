using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
using Loja.Modelos;
using Loja.DAL;


namespace Loja.BLL
{
   public class ProdutosBLL
    {
        public ArrayList ProdutosEmFalta()
        {
            ProdutosDAL obj = new ProdutosDAL();
            return obj.ProdutosEmfalta();
        }
        public void Incluir (ProdutoInformation produto)
        {
            //nome do produto é obrigatorio
            if (produto.Nome.Trim().Length == 0)
            {
                throw new Exception("nome do produto é obrigatorio!");
            }

            //O preco n pode ser negativo
            if (produto.Preco < 0)
            {
                throw new Exception("O preco nao pode ser negativo!");
            }

            //o estoque nao pode ser negativo
            if (produto.Estoque < 0)
            {
                throw new Exception("estoque do produto nao pode ser negativo!");
            }

            //se tudo ok , chamar rotina de gravacao

            ProdutosDAL obj = new ProdutosDAL();
            obj.Incluir(produto);
        }

        public void Alterar (ProdutoInformation produto)
        {
            //nome do produto é obrigatorio
            if (produto.Nome.Trim().Length == 0)
            {
                throw new Exception("nome do produto é obrigatorio!");
            }

            //O preco n pode ser negativo
            if (produto.Preco < 0)
            {
                throw new Exception("O preco nao pode ser negativo!");
            }

            //o estoque nao pode ser negativo
            if (produto.Estoque < 0)
            {
                throw new Exception("estoque do produto nao pode ser negativo!");
            }

            //se tudo ok , chamar rotina de alterar
            ProdutosDAL obj = new ProdutosDAL();
            obj.Alterar(produto);

        }
        public void Excluir (int codigo)
        {
            ProdutosDAL obj = new ProdutosDAL();
            obj.Excluir(codigo);
        } 

        public DataTable Listagem(string filtro)
         {
            ProdutosDAL obj = new ProdutosDAL();
            return obj.Listagem(filtro);
        }
    }
}
