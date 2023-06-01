using Google.Protobuf.WellKnownTypes;
using Sistema_compras.controller;
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
        private void GridProdutos2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if para evitar o bug do botao novo
            if (status == "inserindo")
            {
                desabilitarCampos();
                status = "";
            }

            //Pegar os dados da grid para os campos
            txtId2.Text = GridProdutos2.CurrentRow.Cells[0].Value.ToString();
            txtDataCompra.Text = GridProdutos2.CurrentRow.Cells[1].Value.ToString();
            txtIdFornecedor.Text = GridProdutos2.CurrentRow.Cells[2].Value.ToString();
            label10.Text = GridProdutos2.CurrentRow.Cells[3].Value.ToString();
            txtValorTotal2.Text = GridProdutos2.CurrentRow.Cells[4].Value.ToString();

            total = decimal.Parse(txtValorTotal.Text);

            //buscar itens da venda
            compraController controller = new compraController();

            carrinho = controller.listarItensCompra(int.Parse(txtId2.Text));
            GridProdutos2.DataSource = carrinho;

            //habilita os botões
            botaoEditar.Enabled = true;
            botaoExcluir.Enabled = true;

            //Vai para a aba de dados
            tabControl1.SelectedTab = tabDados;
        }
        private void botaoPesquisar_Click(object sender, EventArgs e)
        {
            string nome = "%" + textBox1.Text + "%";

            compraController controller = new compraController();
            GridProdutos2.DataSource = controller.buscaPorNome(nome);

            if (GridProdutos2.Rows.Count == 0)
            {
                MessageBox.Show("Nenhuma compra encontrada para este fornecedor");
                GridProdutos2.DataSource = controller.listarCompras();
            }
        }
        private void botaoPesquisaFornecedor_Click(object sender, EventArgs e)
        {
            //cria a janela de pesquisa cliente
            FPesquisaFornecedor pesquisa = new FPesquisaFornecedor();
            //chama a tela de pesquisa
            pesquisa.ShowDialog();

            //O Id do Fornecedor selecionado é enviado para o campo txtIdFornecedor/nomeCliente
            txtIdFornecedor.Text = pesquisa.selecionado.idfornecedor.ToString();
            labelFornecedor.Text = pesquisa.selecionado.nome;
            //Destroi o objeto (janela) da memória
            pesquisa.Dispose();
            //Coloca o foco no campo de data
            txtDataCompra.Focus();
        }
        private void botaoPesquisarProduto2_Click(object sender, EventArgs e)
        {
            FPesquisaProduto pesquisa = new FPesquisaProduto();
            pesquisa.ShowDialog();
            txtIdProduto2.Text = pesquisa.selecionado.idproduto.ToString();
            label10.Text = pesquisa.selecionado.nome;
            txtQuantidade2.Text = "1,00";
            txtValorUnitario2.Text = pesquisa.selecionado.valor_unitario.ToString();
            pesquisa.Dispose();
            txtQuantidade2.Focus();
        }
        private void txtQuantidade2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtValorUnitario2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtIdFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void txtIdProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
        private void txtQuantidade2_Leave(object sender, EventArgs e)
        {
            if (txtQuantidade2.Text == "")
            {
                txtQuantidade2.Text = "0,00";
            }
            else
            {
                double a = double.Parse(txtQuantidade2.Text);
                txtQuantidade2.Text = String.Format("{0:N2}", a);
            }
        }
        private void txtValorUnitario2_Leave(object sender, EventArgs e)
        {
            if (txtValorUnitario2.Text == "")
            {
                txtValorUnitario2.Text = "0,00";
            }
            else
            {
                double a = double.Parse(txtValorUnitario2.Text);
                txtValorUnitario2.Text = String.Format("{0:N2}", a);
            }
        }
        private void txtIdFornecedor_Leave(object sender, EventArgs e)
        {
            //Verifica se o campo não está vazio
            if (txtIdFornecedor.Text != "")
            {
                fornecedorController controller
                    = new fornecedorController();
                int id = int.Parse(txtIdFornecedor.Text);
                //Faz uma busca do cliente pelo código
                Fornecedor F = controller.buscaPorID(id);
                if (F != null) //Se achou
                {
                    //Coloca o nome do cliente no label
                    labelFornecedor.Text = F.nome;
                }
                else //se não achou
                {
                    //Limpa os campos
                    txtIdFornecedor.Text = String.Empty;
                    label10.Text = String.Empty;
                }
                txtDataCompra.Focus();
            }
        }

        private void txtIdProduto2_Leave(object sender, EventArgs e)
        {
            if (txtIdProduto2.Text != "")
            {
                produtoController controller
                    = new produtoController();
                int id = int.Parse(txtIdProduto2.Text);
                Produto f = controller.buscaPorID(id);
                if (f != null)
                {
                    label10.Text = f.nome;
                    txtQuantidade2.Text = "1,00";
                    txtValorUnitario2.Text = f.valor_unitario.ToString();
                }
                else
                {
                    txtIdProduto2.Text = String.Empty;
                    label10.Text = String.Empty;
                    txtQuantidade2.Text = String.Empty;
                    txtValorUnitario2.Text = String.Empty;
                }
                txtQuantidade2.Focus();
            }
        }

        private void botaoAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                //Botão adicionar item

                decimal subtotal2 = decimal.Parse(txtQuantidade2.Text) * decimal.Parse(txtValorUnitario2.Text);

                total += subtotal2;

                carrinho.Rows.Add(int.Parse(txtIdProduto2.Text), labelNomeProduto.Text, decimal.Parse(txtQuantidade2.Text), decimal.Parse(txtValorUnitario2.Text), subtotal2);


                txtValorTotal.Text = total.ToString("N2");

                //Limpar os campos
                txtIdProduto2.Text = String.Empty;
                label10.Text = String.Empty;
                txtQuantidade2.Text = String.Empty; ;
                txtValorUnitario2.Text = String.Empty;

                txtIdProduto2.Focus();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao adicionar o Produto: " + erro);
            }
        }
        private void botaoRemover_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult =
            MessageBox.Show
             ("Tem certeza que deseja excluir o produto " + GridProdutos2.CurrentRow.Cells[1].Value.ToString() + "?",
             "Pergunta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                decimal subtotal2 = decimal.Parse(GridProdutos2.CurrentRow.Cells[4].Value.ToString());

                int indice = GridProdutos2.CurrentRow.Index;
                DataRow linha = carrinho.Rows[indice];

                carrinho.Rows.Remove(linha);
                carrinho.AcceptChanges();

                total -= subtotal2;

                txtValorTotal2.Text = total.ToString("N2"); ;

                MessageBox.Show("Item Removido com sucesso!");
            }
        }
    }
}