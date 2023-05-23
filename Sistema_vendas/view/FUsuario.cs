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
    public partial class FUsuario : Form
    {
        private string status = "";

        public FUsuario()
        {
            InitializeComponent();
        }

        public void desabilitarCampos()
        {
            txtId.Enabled = false;
            txtNome.Enabled = false;
            txtLogin.Enabled = false;
            txtSenha.Enabled = false;
            txtTelefone.Enabled = false;
            //desabilita os botoes
            botaoSalvar.Enabled = false;
            botaoEditar.Enabled = false;
            botaoExcluir.Enabled = false;
        }

        public void habilitarCampos()
        {
            //txtId.Enabled = false;
            txtNome.Enabled = true;
            txtLogin.Enabled = true;
            txtSenha.Enabled = true;
            txtTelefone.Enabled = true;

            botaoSalvar.Enabled = true;
        }

        public void limparCampos()
        {
            txtId.Text = String.Empty;
            txtNome.Text = String.Empty;
            txtLogin.Text = String.Empty;
            txtSenha.Text = String.Empty;
            txtTelefone.Text = String.Empty;
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

        private void FUsuario_Load(object sender, EventArgs e)
        {
            desabilitarCampos();
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            Usuario obj = new Usuario();
            obj.nome = txtNome.Text;
            obj.login = txtLogin.Text;
            obj.telefone = txtTelefone.Text;
            obj.senha = txtSenha.Text;


            usuarioController controller = new usuarioController();
            if (status == "inserindo")
            {
                controller.cadastrarUsuario(obj);
                status = "";
            }
            else if (status == "alterando")
            {
                obj.idusuario = int.Parse(txtId.Text);
                controller.alterarUsuario(obj);
                status = "";

            }

            limparCampos();
            desabilitarCampos();
            dataGridView1.DataSource = controller.listarUsuarios();

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
                Usuario obj = new Usuario();
                obj.idusuario = int.Parse(txtId.Text);

                usuarioController controller = new usuarioController();
                controller.excluirUsuario(obj);
                dataGridView1.DataSource = controller.listarUsuarios();
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

        private void botaoPesquisar_Click(object sender, EventArgs e)
        {
            string nome = "%" + textBox1.Text + "%";

            usuarioController controller = new usuarioController();
            dataGridView1.DataSource = controller.buscaPorNome(nome);

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum usuário encontrado com este nome");
                dataGridView1.DataSource = controller.listarUsuarios();
            }
        }
    }
}
