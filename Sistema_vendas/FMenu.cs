using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_vendas.view;

namespace Sistema_vendas
{
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        }

        private void botaoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botaoclientes_Click(object sender, EventArgs e)
        {
            //Cria a instancia do formulario 
            FCliente tela = new FCliente();
            //Ajusta as propriedades de borda da janela
            tela.TopLevel = false;
            tela.FormBorderStyle = FormBorderStyle.None;

            //Adiciona uma nova aba na PageControl
            tabControl1.TabPages.Add("Clientes");
            //Identifica quantas abas existem
            int abas = tabControl1.TabPages.Count;
            //Adiciona o formulário na nova aba criada
            tabControl1.TabPages[abas-1].Controls.Add(tela);
            //Faz com que o formulário preencha todo o espaço da aba
            tela.Dock = DockStyle.Fill;
            //Mostra o formulário dentro da aba
            tela.Show();
            //Atualiza o formulário principal (Menu)
            Refresh();
            //Seleciona a aba recém criada
            tabControl1.SelectedTab = 
                tabControl1.TabPages[abas - 1];
            //Adiciona o ícone na aba
            tabControl1.TabPages[abas-1].ImageIndex= 0;

        }

        private void botaoFornecedores_Click(object sender, EventArgs e)
        {
            //Cria a instancia do formulario 
            FFornecedor tela = new FFornecedor();
            //Ajusta as propriedades de borda da janela
            tela.TopLevel = false;
            tela.FormBorderStyle = FormBorderStyle.None;

            //Adiciona uma nova aba na PageControl
            tabControl1.TabPages.Add("Fornecedores");
            //Identifica quantas abas existem
            int abas = tabControl1.TabPages.Count;
            //Adiciona o formulário na nova aba criada
            tabControl1.TabPages[abas - 1].Controls.Add(tela);
            //Faz com que o formulário preencha todo o espaço da aba
            tela.Dock = DockStyle.Fill;
            //Mostra o formulário dentro da aba
            tela.Show();
            //Atualiza o formulário principal (Menu)
            Refresh();
            //Seleciona a aba recém criada
            tabControl1.SelectedTab =
                tabControl1.TabPages[abas - 1];
            //Adiciona o ícone na aba
            tabControl1.TabPages[abas - 1].ImageIndex = 2;
        }

        private void botaoUsuarios_Click(object sender, EventArgs e)
        {
            //Cria a instancia do formulario 
            FUsuario tela = new FUsuario();
            //Ajusta as propriedades de borda da janela
            tela.TopLevel = false;
            tela.FormBorderStyle = FormBorderStyle.None;

            //Adiciona uma nova aba na PageControl
            tabControl1.TabPages.Add("Usuários");
            //Identifica quantas abas existem
            int abas = tabControl1.TabPages.Count;
            //Adiciona o formulário na nova aba criada
            tabControl1.TabPages[abas - 1].Controls.Add(tela);
            //Faz com que o formulário preencha todo o espaço da aba
            tela.Dock = DockStyle.Fill;
            //Mostra o formulário dentro da aba
            tela.Show();
            //Atualiza o formulário principal (Menu)
            Refresh();
            //Seleciona a aba recém criada
            tabControl1.SelectedTab =
                tabControl1.TabPages[abas - 1];
            //Adiciona o ícone na aba
            tabControl1.TabPages[abas - 1].ImageIndex = 3;
        }

        private void botaoProdutos_Click(object sender, EventArgs e)
        {
            //Cria a instancia do formulario 
            FProduto tela = new FProduto();
            //Ajusta as propriedades de borda da janela
            tela.TopLevel = false;
            tela.FormBorderStyle = FormBorderStyle.None;

            //Adiciona uma nova aba na PageControl
            tabControl1.TabPages.Add("Produtos");
            //Identifica quantas abas existem
            int abas = tabControl1.TabPages.Count;
            //Adiciona o formulário na nova aba criada
            tabControl1.TabPages[abas - 1].Controls.Add(tela);
            //Faz com que o formulário preencha todo o espaço da aba
            tela.Dock = DockStyle.Fill;
            //Mostra o formulário dentro da aba
            tela.Show();
            //Atualiza o formulário principal (Menu)
            Refresh();
            //Seleciona a aba recém criada
            tabControl1.SelectedTab =
                tabControl1.TabPages[abas - 1];
            //Adiciona o ícone na aba
            tabControl1.TabPages[abas - 1].ImageIndex = 1;
        }

        private void botaoVendas_Click(object sender, EventArgs e)
        {
            //Cria a instancia do formulario 
            FVenda tela = new FVenda();
            //Ajusta as propriedades de borda da janela
            tela.TopLevel = false;
            tela.FormBorderStyle = FormBorderStyle.None;

            //Adiciona uma nova aba na PageControl
            tabControl1.TabPages.Add("Vendas");
            //Identifica quantas abas existem
            int abas = tabControl1.TabPages.Count;
            //Adiciona o formulário na nova aba criada
            tabControl1.TabPages[abas - 1].Controls.Add(tela);
            //Faz com que o formulário preencha todo o espaço da aba
            tela.Dock = DockStyle.Fill;
            //Mostra o formulário dentro da aba
            tela.Show();
            //Atualiza o formulário principal (Menu)
            Refresh();
            //Seleciona a aba recém criada
            tabControl1.SelectedTab =
                tabControl1.TabPages[abas - 1];
            //Adiciona o ícone na aba
            tabControl1.TabPages[abas - 1].ImageIndex = 4;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FVenda tela = new FVenda();
            //Ajusta as propriedades de borda da janela
            tela.TopLevel = false;
            tela.FormBorderStyle = FormBorderStyle.None;

            //Adiciona uma nova aba na PageControl
            tabControl1.TabPages.Add("Vendas");
            //Identifica quantas abas existem
            int abas = tabControl1.TabPages.Count;
            //Adiciona o formulário na nova aba criada
            tabControl1.TabPages[abas - 1].Controls.Add(tela);
            //Faz com que o formulário preencha todo o espaço da aba
            tela.Dock = DockStyle.Fill;
            //Mostra o formulário dentro da aba
            tela.Show();
            //Atualiza o formulário principal (Menu)
            Refresh();
            //Seleciona a aba recém criada
            tabControl1.SelectedTab =
                tabControl1.TabPages[abas - 1];
            //Adiciona o ícone na aba
            tabControl1.TabPages[abas - 1].ImageIndex = 4;
        }
    }
}
