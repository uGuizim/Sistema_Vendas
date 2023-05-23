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
    public partial class FCliente : Form
    {
        private string status = "";

        public FCliente()
        {
            InitializeComponent();
        }

        public void desabilitarCampos()
        {
            txtId.Enabled= false;
            txtNome.Enabled= false;
            txtCpf.Enabled= false;
            txtBairro.Enabled= false;
            txtLogradouro.Enabled= false;
            txtCidade.Enabled= false;
            textEmail.Enabled= false;
            txtTelefone.Enabled= false; 
            txtUF.Enabled= false;
            //desabilita os botoes
            botaoSalvar.Enabled= false;
            botaoEditar.Enabled= false;
            botaoExcluir.Enabled= false;
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

        private void FCliente_Load(object sender, EventArgs e)
        {
            desabilitarCampos();
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();
            obj.nome = txtNome.Text;
            obj.cpf_cnpj = txtCpf.Text.Replace(",", ".");
            obj.telefone = txtTelefone.Text;
            obj.email = textEmail.Text;
            obj.logradouro = txtLogradouro.Text;
            obj.bairro = txtBairro.Text;
            obj.cidade = txtCidade.Text;
            obj.uf = txtUF.Text;

            clienteController controller = new clienteController(); 
            if (status == "inserindo")
            {
                controller.cadastrarCliente(obj);
                status = "";
            }
            else if (status == "alterando")
            {
                obj.idcliente = int.Parse(txtId.Text);
                controller.alterarCliente(obj);
                status = "";

            }

            limparCampos();
            desabilitarCampos();
            dataGridView1.DataSource = controller.listarClientes();
            
            tabControl1.SelectedTab = tabPesquisa;

        }

        private void botaoPesquisar_Click(object sender, EventArgs e)
        {
            string nome = "%"+textBox1.Text+"%";

            clienteController controller = new clienteController();
            dataGridView1.DataSource= controller.buscaPorNome(nome);

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum cliente encontrado com este nome");
                dataGridView1.DataSource = controller.listarClientes();
            }
            
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

        private void botaoEditar_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            status = "alterando";
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
                Cliente obj = new Cliente();
                obj.idcliente = int.Parse(txtId.Text);

                clienteController controller = new clienteController();
                controller.excluirCliente(obj);
                dataGridView1.DataSource = controller.listarClientes();
                limparCampos();
                botaoEditar.Enabled = false;
                botaoExcluir.Enabled=false;
                tabControl1.SelectedTab = tabPesquisa;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                botaoPesquisar_Click(sender, e);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
