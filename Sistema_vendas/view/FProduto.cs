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
    public partial class FProduto : Form
    {
        private string status = "";
        public FProduto()
        {
            InitializeComponent();
        }

        public void desabilitarCampos()
        {
            txtId.Enabled = false;
            txtNome.Enabled = false;
            txtMarca.Enabled = false;
            txtValorUnitario.Enabled = false;
            txtCor.Enabled = false;
            txtIdFornecedor.Enabled = false;
            txtCor.Enabled = false;
            txtQuantidade.Enabled = false;
            txtUnidadeMedida.Enabled = false;
            //desabilita os botoes
            botaoSalvar.Enabled = false;
            botaoEditar.Enabled = false;
            botaoExcluir.Enabled = false;
        }

        public void habilitarCampos()
        {
            //txtId.Enabled = false;
            txtNome.Enabled = true;
            txtMarca.Enabled = true;
            txtValorUnitario.Enabled = true;
            txtCor.Enabled = true;
            txtIdFornecedor.Enabled = true;
            txtQuantidade.Enabled = true;
            txtUnidadeMedida.Enabled = true;

            botaoSalvar.Enabled = true;
        }

        public void limparCampos()
        {
            txtId.Text = String.Empty;
            txtNome.Text = String.Empty;
            txtMarca.Text = String.Empty;
            txtValorUnitario.Text = String.Empty;
            txtCor.Text = String.Empty;
            txtIdFornecedor.Text = String.Empty;
            txtQuantidade.Text = String.Empty;
            txtUnidadeMedida.Text = String.Empty;
            labelNomeFornecedor.Text= String.Empty;

            txtNome.Focus();
        }

        private void botaoNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            limparCampos();
            status = "inserindo";
            tabControl1.SelectedTab = tabDados;
        }

        private void botaoFechar_Click(object sender, EventArgs e)
        {
            TabPage tabpage = (TabPage)this.Parent;
            this.Close();
            TabControl tabControl = (TabControl)tabpage.Parent;
            tabControl.TabPages.Remove(tabpage);
        }

        private void FProduto_Load(object sender, EventArgs e)
        {
            desabilitarCampos();
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();
            obj.nome = txtNome.Text;
            obj.valor_unitario = float.Parse(txtValorUnitario.Text);
            obj.quantidade = float.Parse(txtQuantidade.Text);
            obj.marca = txtMarca.Text;
            obj.unidade_medida = txtUnidadeMedida.Text;
            obj.cor = txtCor.Text;
            obj.idfornecedor = int.Parse(txtIdFornecedor.Text);


            produtoController controller = new produtoController();
            if (status == "inserindo")
            {
                controller.cadastrarProduto(obj);
                status = "";
            }
            else if (status == "alterando")
            {
                obj.idproduto = int.Parse(txtId.Text);
                controller.alterarProduto(obj);
                status = "";

            }

            limparCampos();
            desabilitarCampos();
            dataGridView1.DataSource = controller.listarProdutos();

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
                Produto obj = new Produto();
                obj.idfornecedor = int.Parse(txtId.Text);

                produtoController controller = new produtoController();
                controller.excluirProduto(obj);
                dataGridView1.DataSource = controller.listarProdutos();
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
            txtNome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtUnidadeMedida.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtMarca.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtCor.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtQuantidade.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtValorUnitario.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtIdFornecedor.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            //labelNomeFornecedor.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            //habilita os botões
            botaoEditar.Enabled = true;
            botaoExcluir.Enabled = true;
            //Vai para a aba de dados
            tabControl1.SelectedTab = tabDados;
        }

        private void botaoPesquisar_Click(object sender, EventArgs e)
        {
            string nome = "%" + textBox1.Text + "%";

            produtoController controller = new produtoController();
            dataGridView1.DataSource = controller.buscaPorNome(nome);

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum produto encontrado com este nome");
                dataGridView1.DataSource = controller.listarProdutos();
            }
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

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            if (txtQuantidade.Text == "")
            {
                txtQuantidade.Text = "0,00";
            }
            else
            {
                //double a = double.Parse(txtQuantidade.Text.Replace(",", "."));
                //txtQuantidade.Text = String.Format("{0:N2}",a).Replace(".", ",");

                double a = double.Parse(txtQuantidade.Text);
                txtQuantidade.Text = String.Format("{0:N2}", a);
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

        private void txtValorUnitario_Leave(object sender, EventArgs e)
        {
            if (txtValorUnitario.Text == "")
            {
                txtValorUnitario.Text = "0,00";
            }
            else
            {
                //double a = double.Parse(txtQuantidade.Text.Replace(",", "."));
                //txtQuantidade.Text = String.Format("{0:N2}",a).Replace(".", ",");

                double a = double.Parse(txtValorUnitario.Text);
                txtValorUnitario.Text = String.Format("{0:N2}", a);
            }
        }

        private void txtIdFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void botaoPesquisaFornecedor_Click(object sender, EventArgs e)
        {
            FPesquisaFornecedor pesquisa = new FPesquisaFornecedor();   
            pesquisa.ShowDialog();
            txtIdFornecedor.Text =
                pesquisa.selecionado.idfornecedor.ToString();
            labelNomeFornecedor.Text =
                pesquisa.selecionado.nome;

        
            pesquisa.Dispose();
        }

        private void txtIdFornecedor_Leave(object sender, EventArgs e)
        {
            if (txtIdFornecedor.Text != "")
            {
                fornecedorController controller 
                    = new fornecedorController();
                int id = int.Parse(txtIdFornecedor.Text);
                Fornecedor f = controller.buscaPorID(id);
                if (f != null) 
                { 
                  labelNomeFornecedor.Text = f.nome;
                }
                else
                {
                    txtIdFornecedor.Text = String.Empty;
                    labelNomeFornecedor.Text = String.Empty;    
                }

            }
        }
    }
}
