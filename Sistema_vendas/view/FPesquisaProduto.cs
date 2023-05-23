using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_vendas.controller;
using Sistema_vendas.model;

namespace Sistema_vendas.view
{
    public partial class FPesquisaProduto : Form
    {
        public Produto selecionado;

        public FPesquisaProduto()
        {
            InitializeComponent();
            selecionado = new Produto();
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botaoPesquisar_Click(object sender, EventArgs e)
        {
            string nome = "%" + txtPesquisar.Text + "%";

            produtoController controller = new produtoController();
            GridProduto.DataSource = controller.buscaPorNome(nome);

            if (GridProduto.Rows.Count == 0 ) {
                MessageBox.Show("Nenhum produto encontrado com este nome");
                GridProduto.DataSource = controller.listarProdutos();
            }
            
        }

        private void botaoConfirmar_Click(object sender, EventArgs e)
        {
            if (GridProduto.Rows.Count > 0)
            {
                selecionado.idproduto =
                    int.Parse(GridProduto.
                    CurrentRow.Cells[0].Value.ToString());  
                selecionado.nome = GridProduto.
                    CurrentRow.Cells[1].Value.ToString();
                selecionado.valor_unitario = float.Parse(GridProduto.
                    CurrentRow.Cells[6].Value.ToString()); //Pega o valor unitário

            }
            Close();
        }

        private void GridProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            botaoConfirmar_Click(sender,e);
        }
    }
}
