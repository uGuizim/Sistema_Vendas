using Google.Protobuf.WellKnownTypes;
using Sistema_vendas.controller;
using Sistema_vendas.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_vendas.view
{
    public partial class FCompra : Form
    {
        private string status = "";
        //Variável para armazenar o total da venda
        private decimal total = 0;
        DataTable carrinho = new DataTable();

        public FCompra()
        {
            InitializeComponent();

            carrinho.Columns.Add("idproduto", typeof(int));
            carrinho.Columns.Add("nome", typeof(string));
            carrinho.Columns.Add("quantidade", typeof(decimal));
            carrinho.Columns.Add("valor_unitario", typeof(decimal));
            carrinho.Columns.Add("subtotal", typeof(decimal));

            GridProdutos.DataSource = carrinho;
        }
        public void desabilitarCampos()
        {
            txtId2.Enabled = false;
            txtIdFornecedor.Enabled = false;
            txtDataCompra.Enabled = false;
            txtValorTotal2.Enabled = false;
            txtIdProduto2.Enabled = false;

            //desabilita os botoes
            botaoSalvar.Enabled = false;
            botaoEditar.Enabled = false;
            botaoExcluir.Enabled = false;

            botaoAdicionar2.Enabled = false;
            botaoRemover2.Enabled = false;
            txtQuantidade2.Enabled = false;
            txtValorUnitario2.Enabled = false;
        }
        public void habilitarCampos()
        {
            //txtId2.Enabled = false;
            txtIdFornecedor.Enabled = true;
            txtDataCompra.Enabled = true;
            //txtValorTotal2.Enabled = false;
            txtIdProduto2.Enabled = true;

            botaoSalvar.Enabled = true;


            botaoAdicionar2.Enabled = true;
            botaoRemover2.Enabled = true;
            txtQuantidade2.Enabled = true;
            txtValorUnitario2.Enabled = true;
        }
        public void limparCampos()
        {
            txtId2.Text = String.Empty;
            txtIdFornecedor.Text = String.Empty;
            label10.Text = String.Empty;
            labelFornecedor.Text = String.Empty;
            txtIdProduto2.Text = String.Empty;
            txtDataCompra.Text = String.Empty;
            txtValorTotal2.Text = String.Empty;

            txtQuantidade2.Text = String.Empty;
            txtValorUnitario2.Text = String.Empty;
            total = 0;

            carrinho.Clear();

            txtIdFornecedor.Focus();
        }

        private void botaoFechar_Click(object sender, EventArgs e)
        {
            TabPage tabpage = (TabPage)this.Parent;
            this.Close();
            TabControl tabControl = (TabControl)tabpage.Parent;
            tabControl.TabPages.Remove(tabpage);
        }

        private void botaoNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            limparCampos();
            status = "inserindo";
            //Coloca o foco na aba de dados da venda
            tabControl1.SelectedTab = tabDados;
            txtIdCliente.Focus();
            txtDataVenda.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            Compra obj = new Compra();


            obj.idfornecedor = int.Parse(txtIdFornecedor.Text);
            obj.data_compra = DateTime.Parse(txtDataCompra.Text);
            obj.idusuario = 1; //Será feito no módulo de segurança
            obj.valor_total = decimal.Parse(txtValorTotal2.Text);


            foreach (DataGridViewRow produto in GridProdutos2.Rows)//DataGridViewRow row in yourDataGridView.SelectedRows
            {
                CompraProduto item = new CompraProduto();

                item.idproduto = int.Parse(produto.Cells[0].Value.ToString());
                item.quantidade = decimal.Parse(produto.Cells[2].Value.ToString());
                item.valor_unitario = decimal.Parse(produto.Cells[3].Value.ToString());

                //Adiciona na lista de produtos
                obj.produtos.Add(item);

            }

            compraController controller = new compraController();
            if (status == "inserindo")
            {
                controller.cadastrarCompra(obj);
                status = "";
            }
            else if (status == "alterando")
            {
                obj.idcompra = int.Parse(txtId2.Text);
                controller.alterarCompra(obj);
                status = "";

            }


            limparCampos();
            desabilitarCampos();
            GridProdutos2.DataSource = controller.listarCompras();

            tabControl2.SelectedTab = tabPesquisa;
        }

        private void botaoExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult =
            MessageBox.Show
             ("Tem certeza que deseja excluir?",
             "Pergunta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Faz a exclusão
                Compra obj = new Compra();
                obj.idcompra = int.Parse(txtId.Text);

                compraController controller = new compraController();
                controller.excluirCompra(obj);
                GridProdutos2.DataSource = controller.listarCompras();
                limparCampos();
                botaoEditar.Enabled = false;
                botaoExcluir.Enabled = false;
                tabControl1.SelectedTab = tabPesquisa;
            }
        }

        private void botaoEditar_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            status = "alterando";
        }
    }
}
