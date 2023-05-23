namespace Sistema_vendas
{
    partial class FMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.botaoclientes = new System.Windows.Forms.ToolStripButton();
            this.botaoProdutos = new System.Windows.Forms.ToolStripButton();
            this.botaoFornecedores = new System.Windows.Forms.ToolStripButton();
            this.botaoUsuarios = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.botaoVendas = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.botaoSair = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(891, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.usuáriosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botaoclientes,
            this.botaoProdutos,
            this.botaoFornecedores,
            this.botaoUsuarios,
            this.toolStripSeparator1,
            this.botaoVendas,
            this.toolStripSeparator2,
            this.toolStripButton1,
            this.botaoSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(891, 58);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // botaoclientes
            // 
            this.botaoclientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botaoclientes.Image = ((System.Drawing.Image)(resources.GetObject("botaoclientes.Image")));
            this.botaoclientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botaoclientes.Name = "botaoclientes";
            this.botaoclientes.Size = new System.Drawing.Size(52, 55);
            this.botaoclientes.Text = "toolStripButton1";
            this.botaoclientes.ToolTipText = "Cadastro de Clientes";
            this.botaoclientes.Click += new System.EventHandler(this.botaoclientes_Click);
            // 
            // botaoProdutos
            // 
            this.botaoProdutos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botaoProdutos.Image = ((System.Drawing.Image)(resources.GetObject("botaoProdutos.Image")));
            this.botaoProdutos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botaoProdutos.Name = "botaoProdutos";
            this.botaoProdutos.Size = new System.Drawing.Size(52, 55);
            this.botaoProdutos.Text = "toolStripButton2";
            this.botaoProdutos.ToolTipText = "Cadastro de Produtos";
            this.botaoProdutos.Click += new System.EventHandler(this.botaoProdutos_Click);
            // 
            // botaoFornecedores
            // 
            this.botaoFornecedores.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botaoFornecedores.Image = ((System.Drawing.Image)(resources.GetObject("botaoFornecedores.Image")));
            this.botaoFornecedores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botaoFornecedores.Name = "botaoFornecedores";
            this.botaoFornecedores.Size = new System.Drawing.Size(52, 55);
            this.botaoFornecedores.Text = "toolStripButton3";
            this.botaoFornecedores.ToolTipText = "Cadastro de Fornecedores";
            this.botaoFornecedores.Click += new System.EventHandler(this.botaoFornecedores_Click);
            // 
            // botaoUsuarios
            // 
            this.botaoUsuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botaoUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("botaoUsuarios.Image")));
            this.botaoUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.botaoUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botaoUsuarios.Name = "botaoUsuarios";
            this.botaoUsuarios.Size = new System.Drawing.Size(52, 55);
            this.botaoUsuarios.Text = "toolStripButton4";
            this.botaoUsuarios.ToolTipText = "Cadastro de Usuários";
            this.botaoUsuarios.Click += new System.EventHandler(this.botaoUsuarios_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 58);
            // 
            // botaoVendas
            // 
            this.botaoVendas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botaoVendas.Image = ((System.Drawing.Image)(resources.GetObject("botaoVendas.Image")));
            this.botaoVendas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botaoVendas.Name = "botaoVendas";
            this.botaoVendas.Size = new System.Drawing.Size(52, 55);
            this.botaoVendas.Text = "toolStripButton5";
            this.botaoVendas.ToolTipText = "Registro de Vendas";
            this.botaoVendas.Click += new System.EventHandler(this.botaoVendas_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 58);
            // 
            // botaoSair
            // 
            this.botaoSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botaoSair.Image = ((System.Drawing.Image)(resources.GetObject("botaoSair.Image")));
            this.botaoSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.botaoSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botaoSair.Name = "botaoSair";
            this.botaoSair.Size = new System.Drawing.Size(52, 55);
            this.botaoSair.Text = "toolStripButton6";
            this.botaoSair.ToolTipText = "Sair do Sistema";
            this.botaoSair.Click += new System.EventHandler(this.botaoSair_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(891, 610);
            this.tabControl1.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cliente.png");
            this.imageList1.Images.SetKeyName(1, "produto.png");
            this.imageList1.Images.SetKeyName(2, "fornecedor.png");
            this.imageList1.Images.SetKeyName(3, "usuario.png");
            this.imageList1.Images.SetKeyName(4, "vendas.png");
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 55);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 692);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FMenu";
            this.Text = "Sistema de Vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton botaoclientes;
        private System.Windows.Forms.ToolStripButton botaoProdutos;
        private System.Windows.Forms.ToolStripButton botaoFornecedores;
        private System.Windows.Forms.ToolStripButton botaoUsuarios;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton botaoVendas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton botaoSair;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

