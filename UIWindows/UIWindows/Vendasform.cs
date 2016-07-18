using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loja.BLL;
using Loja.DAL;
using Loja.Modelos;

namespace Loja.UIWindows
{
    public partial class Vendasform : Form
    {
        public Vendasform()
        {
            InitializeComponent();
        }

        private void Vendasform_Load(object sender, EventArgs e)
        {
            VendasBLL obj = new VendasBLL();
            clienteComboBox.DataSource = obj.ListaDeClientes;
            produtoComboBox.DataSource = obj.ListaDeProdutos;
        }

        private void incluirVendaButton_Click(object sender, EventArgs e)
        {
            try
            {
                VendaInformation venda = new VendaInformation();
                venda.Quantidade = int.Parse(quantidadeTextBox.Text);
                venda.CodigoCliente = (int)clienteComboBox.SelectedValue;
                venda.CodigoProduto = (int)produtoComboBox.SelectedValue;
                venda.Data = DateTime.Now;

                VendasBLL obj = new VendasBLL();
                obj.Incluir(venda);
                MessageBox.Show("A venda foi realizada com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void valortotalTextBox_TextChanged(object sender, EventArgs e)
        {
            int quantidade = Convert.ToInt32(quantidadeTextBox.Text);

            valortotalTextBox.Text = Convert.ToString(VendasBLL.CalcularValor(Convert.ToInt32(produtoComboBox.SelectedValue), quantidade));
        
        }
    }
}
