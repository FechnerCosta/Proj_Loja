using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Loja.Modelos;
using Loja.DAL;


namespace Loja.BLL
{
    public class ClientesBLL
    {
        public void Incluir (ClienteInformation cliente)
        {
            //nome obrigatorio
            if (cliente.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatorio!");
            }
            //email em letras minusculas
            cliente.Email = cliente.Email.ToLower();

            //se tudo ok, chama rotina de insercao
            ClientesDAL obj = new ClientesDAL();
            obj.Incluir(cliente);
        }
        public void Alterar (ClienteInformation cliente)
        {
            //o nome do cliente e obrigario
            if(cliente.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatorio!");
            }
            //email em letras minusculas
            cliente.Email = cliente.Email.ToLower();

            //se tudo ok , chama rotina de alteracao

            ClientesDAL obj = new ClientesDAL();
            obj.Alterar(cliente);
        }
        public void Excluir (int codigo)
        {
            if (codigo  < 1)
            {
                throw new Exception("Selecione um cliente antes de excluir");
            }
            ClientesDAL obj = new ClientesDAL();
            obj.Excluir(codigo);
        }

        public DataTable Listagem(string filtro)
        {
            ClientesDAL obj = new ClientesDAL();
            return obj.Listagem(filtro);
        }
    }
}
