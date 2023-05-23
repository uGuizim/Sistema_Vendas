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
    public partial class FPesquisaCliente : Form
    {
        public Cliente selecionado;

        public FPesquisaCliente()
        {
            InitializeComponent();
            selecionado = new Cliente();
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botaoPesquisar_Click(object sender, EventArgs e)
        {
            string nome = "%" + txtPesquisar.Text + "%";

            clienteController controller = new clienteController();
            GridCliente.DataSource = controller.buscaPorNome(nome);

            if (GridCliente.Rows.Count == 0 ) {
                MessageBox.Show("Nenhum cliente encontrado com este nome");
                GridCliente.DataSource = controller.listarClientes();
            }
            
        }

        private void botaoConfirmar_Click(object sender, EventArgs e)
        {
            if (GridCliente.Rows.Count > 0)
            {
                selecionado.idcliente =
                    int.Parse(GridCliente.
                    CurrentRow.Cells[0].Value.ToString());  
                selecionado.nome = GridCliente.
                    CurrentRow.Cells[1].Value.ToString();

            }
            Close();
        }

        private void GridCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            botaoConfirmar_Click(sender,e);
        }
    }
}
