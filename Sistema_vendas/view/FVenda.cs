using MySqlX.XDevAPI.Relational;
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

namespace Sistema_vendas.view
{
    public partial class FVenda : Form
    {
        private string status = "";
        //Variável para armazenar o total da venda
        private decimal total = 0;

        //Datatable que contém os produtos da venda
        DataTable carrinho = new DataTable();

        public FVenda()
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
            txtId.Enabled = false;
            txtIdCliente.Enabled = false;
            txtDataVenda.Enabled = false;
            txtValorTotal.Enabled = false;
            txtIdProduto.Enabled = false;

            //desabilita os botoes
            botaoSalvar.Enabled = false;
            botaoEditar.Enabled = false;
            botaoExcluir.Enabled = false;

            botaoAdicionar.Enabled = false;
            botaoRemover.Enabled = false;
            txtQuantidade.Enabled = false;
            txtValorUnitario.Enabled = false;
        }

        public void habilitarCampos()
        {
            //txtId.Enabled = false;
            txtIdCliente.Enabled = true;
            txtDataVenda.Enabled = true;
            //txtValorTotal.Enabled = true;
            txtIdProduto.Enabled = true;

            botaoSalvar.Enabled = true;

            botaoAdicionar.Enabled = true;
            botaoRemover.Enabled = true;
            txtQuantidade.Enabled = true;
            txtValorUnitario.Enabled = true;
        }

        public void limparCampos()
        {
            txtId.Text = String.Empty;
            txtIdCliente.Text = String.Empty;
            labelNomeCliente.Text = String.Empty;
            labelNomeProduto.Text = String.Empty;
            txtIdProduto.Text = String.Empty;
            txtDataVenda.Text = String.Empty;
            txtValorTotal.Text = String.Empty;

            txtQuantidade.Text = String.Empty;
            txtValorUnitario.Text = String.Empty;
            total = 0;

            carrinho.Clear();

            txtIdCliente.Focus();
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

        private void FVenda_Load(object sender, EventArgs e)
        {
            desabilitarCampos();
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            Venda obj = new Venda();
            

            obj.idcliente = int.Parse(txtIdCliente.Text);
            obj.data_venda = DateTime.Parse(txtDataVenda.Text);
            obj.idusuario = 1; //Será feito no módulo de segurança
            obj.valor_total = decimal.Parse(txtValorTotal.Text);


            //Percorrendo os itens do carrinho
            foreach (DataGridViewRow produto in GridProdutos.Rows)//DataGridViewRow row in yourDataGridView.SelectedRows
            {
                VendaProduto item = new VendaProduto();
                
                item.idproduto = int.Parse(produto.Cells[0].Value.ToString());
                item.quantidade = decimal.Parse(produto.Cells[2].Value.ToString());
                item.valor_unitario = decimal.Parse(produto.Cells[3].Value.ToString());
                
                //Adiciona na lista de produtos
                obj.produtos.Add(item);
            }


            vendaController controller = new vendaController();
            if (status == "inserindo")
            {
                controller.cadastrarVenda(obj);
                status = "";
            }
            else if (status == "alterando")
            {
                obj.idvenda = int.Parse(txtId.Text);
                controller.alterarVenda(obj);
                status = "";

            }

            limparCampos();
            desabilitarCampos();
            dataGridView1.DataSource = controller.listarVendas();

            tabControl1.SelectedTab = tabPesquisa;
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
                Venda obj = new Venda();
                obj.idvenda = int.Parse(txtId.Text);

                vendaController controller = new vendaController();
                controller.excluirVenda(obj);
                dataGridView1.DataSource = controller.listarVendas();
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if para evitar o bug do botao novo
            if (status == "inserindo")
            {
                desabilitarCampos();
                status = "";
            }

            //Pegar os dados da grid para os campos
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtDataVenda.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtIdCliente.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            labelNomeCliente.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtValorTotal.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            total = decimal.Parse(txtValorTotal.Text);

            //buscar itens da venda
            vendaController controller = new vendaController();

            carrinho = controller.listarItensVenda(int.Parse(txtId.Text));
            GridProdutos.DataSource = carrinho;
            
            //habilita os botões
            botaoEditar.Enabled = true;
            botaoExcluir.Enabled = true;

            //Vai para a aba de dados
            tabControl1.SelectedTab = tabDados;
        }

        private void botaoPesquisar_Click(object sender, EventArgs e)
        {
            string nome = "%" + textBox1.Text + "%";

            vendaController controller = new vendaController();
            dataGridView1.DataSource = controller.buscaPorNome(nome);

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Nenhuma venda encontrada para este cliente");
                dataGridView1.DataSource = controller.listarVendas();
            }
        }

        private void botaoPesquisaCliente_Click(object sender, EventArgs e)
        {
            //cria a janela de pesquisa cliente
            FPesquisaCliente pesquisa = new FPesquisaCliente();
            //chama a tela de pesquisa
            pesquisa.ShowDialog();

            //O Id do cliente selecionado é enviado para o campo txtIdCliente/nomeCliente
            txtIdCliente.Text = pesquisa.selecionado.idcliente.ToString();
            labelNomeCliente.Text = pesquisa.selecionado.nome;
            //Destroi o objeto (janela) da memória
            pesquisa.Dispose();
            //Coloca o foco no campo de data
            txtDataVenda.Focus();
        }

        private void botaoPesquisarProduto_Click(object sender, EventArgs e)
        {
            FPesquisaProduto pesquisa = new FPesquisaProduto();
            pesquisa.ShowDialog();
            txtIdProduto.Text = pesquisa.selecionado.idproduto.ToString();
            labelNomeProduto.Text = pesquisa.selecionado.nome;
            txtQuantidade.Text = "1,00";
            txtValorUnitario.Text = pesquisa.selecionado.valor_unitario.ToString();
            pesquisa.Dispose();
            txtQuantidade.Focus();
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtValorUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtIdCliente_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            if (txtQuantidade.Text == "")
            {
                txtQuantidade.Text = "0,00";
            }
            else
            {
                double a = double.Parse(txtQuantidade.Text);
                txtQuantidade.Text = String.Format("{0:N2}", a);
            }
        }

        private void txtValorUnitario_Leave(object sender, EventArgs e)
        {
            if (txtValorUnitario.Text == "")
            {
                txtValorUnitario.Text = "0,00";
            }
            else
            {
                double a = double.Parse(txtValorUnitario.Text);
                txtValorUnitario.Text = String.Format("{0:N2}", a);
            }
        }

        private void txtIdCliente_Leave(object sender, EventArgs e)
        {
            //Verifica se o campo não está vazio
            if (txtIdCliente.Text != "")
            {
                clienteController controller
                    = new clienteController();
                int id = int.Parse(txtIdCliente.Text);
                //Faz uma busca do cliente pelo código
                Cliente f = controller.buscaPorID(id);
                if (f != null) //Se achou
                {
                    //Coloca o nome do cliente no label
                    labelNomeCliente.Text = f.nome;
                }
                else //se não achou
                {
                    //Limpa os campos
                    txtIdCliente.Text = String.Empty;
                    labelNomeCliente.Text = String.Empty;
                }
                txtDataVenda.Focus();
            }
        }

        private void txtIdProduto_Leave(object sender, EventArgs e)
        {
            if (txtIdProduto.Text != "")
            {
                produtoController controller
                    = new produtoController();
                int id = int.Parse(txtIdProduto.Text);
                Produto f = controller.buscaPorID(id);
                if (f != null)
                {
                    labelNomeProduto.Text = f.nome;
                    txtQuantidade.Text = "1,00";
                    txtValorUnitario.Text = f.valor_unitario.ToString();
                }
                else
                {
                    txtIdProduto.Text = String.Empty;
                    labelNomeProduto.Text = String.Empty;
                    txtQuantidade.Text = String.Empty;
                    txtValorUnitario.Text = String.Empty;
                }
                txtQuantidade.Focus();
            }
        }

        private void botaoAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                //Botão adicionar item

                decimal subtotal = decimal.Parse(txtQuantidade.Text)*decimal.Parse(txtValorUnitario.Text) ;

                total += subtotal;

                carrinho.Rows.Add(int.Parse(txtIdProduto.Text), labelNomeProduto.Text, decimal.Parse(txtQuantidade.Text), decimal.Parse(txtValorUnitario.Text), subtotal);


                txtValorTotal.Text = total.ToString("N2");

                //Limpar os campos
                txtIdProduto.Text = String.Empty;
                labelNomeProduto.Text = String.Empty;
                txtQuantidade.Text = String.Empty; ;
                txtValorUnitario.Text = String.Empty;

                txtIdProduto.Focus();
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
             ("Tem certeza que deseja excluir o produto "+ GridProdutos.CurrentRow.Cells[1].Value.ToString() + "?",
             "Pergunta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                decimal subtotal = decimal.Parse(GridProdutos.CurrentRow.Cells[4].Value.ToString());

                int indice = GridProdutos.CurrentRow.Index;
                DataRow linha = carrinho.Rows[indice];

                carrinho.Rows.Remove(linha);
                carrinho.AcceptChanges();

                total -= subtotal;

                txtValorTotal.Text = total.ToString("N2"); ;

                MessageBox.Show("Item Removido com sucesso!");
            }
        }

        private void GridProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
