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
    public partial class FFornecedor : Form
    {
        private string status = "";

        public FFornecedor()
        {
            InitializeComponent();
        }

        public void desabilitarCampos()
        {
            txtId.Enabled = false;
            txtNome.Enabled = false;
            txtCpf.Enabled = false;
            txtBairro.Enabled = false;
            txtLogradouro.Enabled = false;
            txtCidade.Enabled = false;
            textEmail.Enabled = false;
            txtTelefone.Enabled = false;
            txtUF.Enabled = false;
            //desabilita os botoes
            botaoSalvar.Enabled = false;
            botaoEditar.Enabled = false;
            botaoExcluir.Enabled = false;
        }

        public void habilitarCampos()
        {
            //txtId.Enabled = false;
            txtNome.Enabled = true;
            txtCpf.Enabled = true;
            txtBairro.Enabled = true;
            txtLogradouro.Enabled = true;
            txtCidade.Enabled = true;
            textEmail.Enabled = true;
            txtTelefone.Enabled = true;
            txtUF.Enabled = true;

            botaoSalvar.Enabled = true;
        }

        public void limparCampos()
        {
            txtId.Text = String.Empty;
            txtNome.Text = String.Empty;
            txtCpf.Text = String.Empty;
            txtBairro.Text = String.Empty;
            txtLogradouro.Text = String.Empty;
            txtCidade.Text = String.Empty;
            textEmail.Text = String.Empty;
            txtTelefone.Text = String.Empty;
            txtUF.Text = String.Empty;
            txtNome.Focus();
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
            tabControl1.SelectedTab = tabDados;
        }

        private void FFornecedor_Load(object sender, EventArgs e)
        {
            desabilitarCampos();
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor();
            obj.nome = txtNome.Text;
            obj.cpf_cnpj = txtCpf.Text.Replace(",", ".");
            obj.telefone = txtTelefone.Text;
            obj.email = textEmail.Text;
            obj.logradouro = txtLogradouro.Text;
            obj.bairro = txtBairro.Text;
            obj.cidade = txtCidade.Text;
            obj.uf = txtUF.Text;

            fornecedorController controller = new fornecedorController();
            if (status == "inserindo")
            {
                controller.cadastrarFornecedor(obj);
                status = "";
            }
            else if (status == "alterando")
            {
                obj.idfornecedor = int.Parse(txtId.Text);
                controller.alterarFornecedor(obj);
                status = "";

            }

            limparCampos();
            desabilitarCampos();
            dataGridView1.DataSource = controller.listarFornecedores();

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
                Fornecedor obj = new Fornecedor();
                obj.idfornecedor = int.Parse(txtId.Text);

                fornecedorController controller = new fornecedorController();
                controller.excluirFornecedor(obj);
                dataGridView1.DataSource = controller.listarFornecedores();
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
            txtCpf.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTelefone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textEmail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtLogradouro.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtBairro.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtCidade.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtUF.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            //habilita os botões
            botaoEditar.Enabled = true;
            botaoExcluir.Enabled = true;
            //Vai para a aba de dados
            tabControl1.SelectedTab = tabDados;
        }

        private void botaoPesquisar_Click(object sender, EventArgs e)
        {
            string nome = "%" + textBox1.Text + "%";

            fornecedorController controller = new fornecedorController();
            dataGridView1.DataSource = controller.buscaPorNome(nome);

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum fornecedor encontrado com este nome");
                dataGridView1.DataSource = controller.listarFornecedores();
            }
        }
    }
}
