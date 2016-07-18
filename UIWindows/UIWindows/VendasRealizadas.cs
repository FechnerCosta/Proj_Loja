using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loja.DAL;
using Loja.BLL;
using Loja.Modelos;

namespace Loja.UIWindows
{
    public partial class VendasRealizadas : Form
    {
        public VendasRealizadas()
        {
            InitializeComponent();
        }

        private void VendasRealizadasForm_load(object sender, EventArgs e)
        {
            AtualizarGrid();
            clienteTextBox.Focus();
        }

        public void AtualizarGrid()
        {
            VendasBLL obj = new VendasBLL();
            vendasDataGridView.DataSource = obj.Listagem(txtFiltro.Text);
            try
            {
                codigoTextBox.Text = vendasDataGridView[0, vendasDataGridView.CurrentRow.Index].Value.ToString();
                clienteTextBox.Text = vendasDataGridView[1, vendasDataGridView.CurrentRow.Index].Value.ToString();
                produtoTextBox.Text = vendasDataGridView[2, vendasDataGridView.CurrentRow.Index].Value.ToString();
                precoTextBox.Text = vendasDataGridView[3, vendasDataGridView.CurrentRow.Index].Value.ToString();
                quantidadeTextBox.Text = vendasDataGridView[4, vendasDataGridView.CurrentRow.Index].Value.ToString();
                dataTextBox.Text = vendasDataGridView[5, vendasDataGridView.CurrentRow.Index].Value.ToString();
                valorTotalTextBox.Text = Convert.ToString(Convert.ToDecimal(precoTextBox.Text) * Convert.ToInt32(quantidadeTextBox.Text));

            }
            catch
            {
                codigoTextBox.Text = " ";
                clienteTextBox.Text = " ";
                produtoTextBox.Text = " ";
                precoTextBox.Text = " ";
                quantidadeTextBox.Text = " ";
                dataTextBox.Text = " ";
                valorTotalTextBox.Text = " ";
                valorTotalTextBox.Text = Convert.ToString(Convert.ToDecimal(precoTextBox.Text) * Convert.ToInt32(quantidadeTextBox.Text));
            }
        }

        private void btFiltro_Click(object sender, EventArgs e)
        {
            VendasBLL obj = new VendasBLL();
            vendasDataGridView.DataSource = obj.Listagem(txtFiltro.Text);

            try
            {
                codigoTextBox.Text = vendasDataGridView[0, vendasDataGridView.CurrentRow.Index].Value.ToString();
                clienteTextBox.Text = vendasDataGridView[1, vendasDataGridView.CurrentRow.Index].Value.ToString();
                produtoTextBox.Text = vendasDataGridView[2, vendasDataGridView.CurrentRow.Index].Value.ToString();
                precoTextBox.Text = vendasDataGridView[3, vendasDataGridView.CurrentRow.Index].Value.ToString();
                quantidadeTextBox.Text = vendasDataGridView[4, vendasDataGridView.CurrentRow.Index].Value.ToString();
                dataTextBox.Text = vendasDataGridView[5, vendasDataGridView.CurrentRow.Index].Value.ToString();
                valorTotalTextBox.Text = Convert.ToString(Convert.ToDecimal(precoTextBox.Text) * Convert.ToInt32(quantidadeTextBox.Text));
            }
            catch
            {
                codigoTextBox.Text = " ";
                clienteTextBox.Text = " ";
                produtoTextBox.Text = " ";
                precoTextBox.Text = " ";
                quantidadeTextBox.Text = " ";
                dataTextBox.Text = " ";
                valorTotalTextBox.Text = " ";
               
            }
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            if (codigoTextBox.Text.Length == 0)
            {
                MessageBox.Show("Uma venda deve ser selecioado antes da exclusão");
            }
            else
                try
                {
                    var confirmResult = MessageBox.Show("Você realmente deseja excluir uma venda ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        int codigo = Convert.ToInt32(codigoTextBox.Text);
                        VendasBLL obj = new VendasBLL();
                        obj.Excluir(codigo);
                        MessageBox.Show("A venda foi excluido com sucesso");
                        AtualizarGrid();
                    }
                    else
                    {
                        AtualizarGrid();
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void vendasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            codigoTextBox.Text = vendasDataGridView[0, vendasDataGridView.CurrentRow.Index].Value.ToString();
            clienteTextBox.Text = vendasDataGridView[1, vendasDataGridView.CurrentRow.Index].Value.ToString();
            produtoTextBox.Text = vendasDataGridView[2, vendasDataGridView.CurrentRow.Index].Value.ToString();
            precoTextBox.Text = vendasDataGridView[3, vendasDataGridView.CurrentRow.Index].Value.ToString();
            quantidadeTextBox.Text = vendasDataGridView[4, vendasDataGridView.CurrentRow.Index].Value.ToString();
            dataTextBox.Text = vendasDataGridView[5, vendasDataGridView.CurrentRow.Index].Value.ToString();
            valorTotalTextBox.Text = Convert.ToString(Convert.ToDecimal(precoTextBox.Text) * Convert.ToInt32(quantidadeTextBox.Text));

            
        }
    }
}
