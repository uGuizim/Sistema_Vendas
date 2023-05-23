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
    public partial class FPesquisaFornecedor : Form
    {
        public Fornecedor selecionado;

        public FPesquisaFornecedor()
        {
            InitializeComponent();
            selecionado = new Fornecedor();
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botaoPesquisar_Click(object sender, EventArgs e)
        {
            string nome = "%" + txtPesquisar.Text + "%";

            fornecedorController controller = new fornecedorController();
            GridFornecedor.DataSource = controller.buscaPorNome(nome);

            if (GridFornecedor.Rows.Count == 0 ) {
                MessageBox.Show("Nenhum fornecedor encontrado com este nome");
                GridFornecedor.DataSource = controller.listarFornecedores();
            }
            
        }

        private void botaoConfirmar_Click(object sender, EventArgs e)
        {
            if (GridFornecedor.Rows.Count > 0)
            {
                selecionado.idfornecedor =
                    int.Parse(GridFornecedor.
                    CurrentRow.Cells[0].Value.ToString());  
                selecionado.nome = GridFornecedor.
                    CurrentRow.Cells[1].Value.ToString();

            }
            Close();
        }

        private void GridFornecedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            botaoConfirmar_Click(sender,e);
        }
    }
}
