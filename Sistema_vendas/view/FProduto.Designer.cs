namespace Sistema_vendas.view
{
    partial class FProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FProduto));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPesquisa = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.botaoPesquisar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabDados = new System.Windows.Forms.TabPage();
            this.botaoPesquisaFornecedor = new System.Windows.Forms.Button();
            this.labelNomeFornecedor = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnidadeMedida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdFornecedor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.botaoNovo = new System.Windows.Forms.ToolStripButton();
            this.botaoSalvar = new System.Windows.Forms.ToolStripButton();
            this.botaoExcluir = new System.Windows.Forms.ToolStripButton();
            this.botaoEditar = new System.Windows.Forms.ToolStripButton();
            this.botaoImprimir = new System.Windows.Forms.ToolStripButton();
            this.botaoFechar = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabDados.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPesquisa);
            this.tabControl1.Controls.Add(this.tabDados);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 85);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1028, 607);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.Controls.Add(this.dataGridView1);
            this.tabPesquisa.Controls.Add(this.panel2);
            this.tabPesquisa.Location = new System.Drawing.Point(4, 29);
            this.tabPesquisa.Name = "tabPesquisa";
            this.tabPesquisa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPesquisa.Size = new System.Drawing.Size(1020, 574);
            this.tabPesquisa.TabIndex = 0;
            this.tabPesquisa.Text = "Pesquisar";
            this.tabPesquisa.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1014, 502);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.botaoPesquisar);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 66);
            this.panel2.TabIndex = 0;
            // 
            // botaoPesquisar
            // 
            this.botaoPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("botaoPesquisar.Image")));
            this.botaoPesquisar.Location = new System.Drawing.Point(884, 12);
            this.botaoPesquisar.Name = "botaoPesquisar";
            this.botaoPesquisar.Size = new System.Drawing.Size(113, 41);
            this.botaoPesquisar.TabIndex = 1;
            this.botaoPesquisar.Text = "Pesquisar";
            this.botaoPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botaoPesquisar.UseVisualStyleBackColor = true;
            this.botaoPesquisar.Click += new System.EventHandler(this.botaoPesquisar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(15, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(863, 26);
            this.textBox1.TabIndex = 0;
            // 
            // tabDados
            // 
            this.tabDados.Controls.Add(this.botaoPesquisaFornecedor);
            this.tabDados.Controls.Add(this.labelNomeFornecedor);
            this.tabDados.Controls.Add(this.txtQuantidade);
            this.tabDados.Controls.Add(this.label11);
            this.tabDados.Controls.Add(this.txtMarca);
            this.tabDados.Controls.Add(this.label5);
            this.tabDados.Controls.Add(this.txtUnidadeMedida);
            this.tabDados.Controls.Add(this.label4);
            this.tabDados.Controls.Add(this.txtIdFornecedor);
            this.tabDados.Controls.Add(this.label9);
            this.tabDados.Controls.Add(this.txtValorUnitario);
            this.tabDados.Controls.Add(this.label8);
            this.tabDados.Controls.Add(this.label7);
            this.tabDados.Controls.Add(this.txtCor);
            this.tabDados.Controls.Add(this.label6);
            this.tabDados.Controls.Add(this.txtNome);
            this.tabDados.Controls.Add(this.label3);
            this.tabDados.Controls.Add(this.txtId);
            this.tabDados.Controls.Add(this.label2);
            this.tabDados.Location = new System.Drawing.Point(4, 29);
            this.tabDados.Name = "tabDados";
            this.tabDados.Padding = new System.Windows.Forms.Padding(3);
            this.tabDados.Size = new System.Drawing.Size(1020, 574);
            this.tabDados.TabIndex = 1;
            this.tabDados.Text = "Dados Gerais";
            this.tabDados.UseVisualStyleBackColor = true;
            // 
            // botaoPesquisaFornecedor
            // 
            this.botaoPesquisaFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("botaoPesquisaFornecedor.Image")));
            this.botaoPesquisaFornecedor.Location = new System.Drawing.Point(298, 349);
            this.botaoPesquisaFornecedor.Name = "botaoPesquisaFornecedor";
            this.botaoPesquisaFornecedor.Size = new System.Drawing.Size(36, 29);
            this.botaoPesquisaFornecedor.TabIndex = 42;
            this.botaoPesquisaFornecedor.UseVisualStyleBackColor = true;
            this.botaoPesquisaFornecedor.Click += new System.EventHandler(this.botaoPesquisaFornecedor_Click);
            // 
            // labelNomeFornecedor
            // 
            this.labelNomeFornecedor.AutoSize = true;
            this.labelNomeFornecedor.Location = new System.Drawing.Point(340, 356);
            this.labelNomeFornecedor.Name = "labelNomeFornecedor";
            this.labelNomeFornecedor.Size = new System.Drawing.Size(91, 20);
            this.labelNomeFornecedor.TabIndex = 41;
            this.labelNomeFornecedor.Text = "Fornecedor";
            this.labelNomeFornecedor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(173, 264);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(123, 26);
            this.txtQuantidade.TabIndex = 24;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            this.txtQuantidade.Leave += new System.EventHandler(this.txtQuantidade_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(116, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 20);
            this.label11.TabIndex = 38;
            this.label11.Text = "Marca:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(173, 180);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(355, 26);
            this.txtMarca.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Nome:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtUnidadeMedida
            // 
            this.txtUnidadeMedida.Location = new System.Drawing.Point(173, 142);
            this.txtUnidadeMedida.Name = "txtUnidadeMedida";
            this.txtUnidadeMedida.Size = new System.Drawing.Size(76, 26);
            this.txtUnidadeMedida.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Unidade Medida:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtIdFornecedor
            // 
            this.txtIdFornecedor.Location = new System.Drawing.Point(173, 350);
            this.txtIdFornecedor.Name = "txtIdFornecedor";
            this.txtIdFornecedor.Size = new System.Drawing.Size(123, 26);
            this.txtIdFornecedor.TabIndex = 26;
            this.txtIdFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIdFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdFornecedor_KeyPress);
            this.txtIdFornecedor.Leave += new System.EventHandler(this.txtIdFornecedor_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "Fornecedor:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Location = new System.Drawing.Point(173, 306);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(123, 26);
            this.txtValorUnitario.TabIndex = 25;
            this.txtValorUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorUnitario_KeyPress);
            this.txtValorUnitario.Leave += new System.EventHandler(this.txtValorUnitario_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Vlr. Unitário:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Quantidade:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(173, 222);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(355, 26);
            this.txtCor.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Cor:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(173, 98);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(355, 26);
            this.txtNome.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nome:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(173, 56);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 26);
            this.txtId.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Gray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botaoNovo,
            this.botaoSalvar,
            this.botaoExcluir,
            this.botaoEditar,
            this.botaoImprimir,
            this.botaoFechar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 45);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1028, 40);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // botaoNovo
            // 
            this.botaoNovo.Image = ((System.Drawing.Image)(resources.GetObject("botaoNovo.Image")));
            this.botaoNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.botaoNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botaoNovo.Name = "botaoNovo";
            this.botaoNovo.Size = new System.Drawing.Size(64, 37);
            this.botaoNovo.Text = "Novo";
            this.botaoNovo.Click += new System.EventHandler(this.botaoNovo_Click);
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.Image = ((System.Drawing.Image)(resources.GetObject("botaoSalvar.Image")));
            this.botaoSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.botaoSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(66, 37);
            this.botaoSalvar.Text = "Salvar";
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // botaoExcluir
            // 
            this.botaoExcluir.Image = ((System.Drawing.Image)(resources.GetObject("botaoExcluir.Image")));
            this.botaoExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.botaoExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botaoExcluir.Name = "botaoExcluir";
            this.botaoExcluir.Size = new System.Drawing.Size(70, 37);
            this.botaoExcluir.Text = "Excluir";
            this.botaoExcluir.Click += new System.EventHandler(this.botaoExcluir_Click);
            // 
            // botaoEditar
            // 
            this.botaoEditar.Image = ((System.Drawing.Image)(resources.GetObject("botaoEditar.Image")));
            this.botaoEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.botaoEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botaoEditar.Name = "botaoEditar";
            this.botaoEditar.Size = new System.Drawing.Size(65, 37);
            this.botaoEditar.Text = "Editar";
            this.botaoEditar.Click += new System.EventHandler(this.botaoEditar_Click);
            // 
            // botaoImprimir
            // 
            this.botaoImprimir.Image = ((System.Drawing.Image)(resources.GetObject("botaoImprimir.Image")));
            this.botaoImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.botaoImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botaoImprimir.Name = "botaoImprimir";
            this.botaoImprimir.Size = new System.Drawing.Size(81, 37);
            this.botaoImprimir.Text = "Imprimir";
            // 
            // botaoFechar
            // 
            this.botaoFechar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.botaoFechar.Image = ((System.Drawing.Image)(resources.GetObject("botaoFechar.Image")));
            this.botaoFechar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.botaoFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botaoFechar.Name = "botaoFechar";
            this.botaoFechar.Size = new System.Drawing.Size(70, 37);
            this.botaoFechar.Text = "Fechar";
            this.botaoFechar.Click += new System.EventHandler(this.botaoFechar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 45);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Produtos";
            // 
            // FProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 692);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FProduto";
            this.Text = "FProduto";
            this.Load += new System.EventHandler(this.FProduto_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPesquisa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabDados.ResumeLayout(false);
            this.tabDados.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPesquisa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button botaoPesquisar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabDados;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton botaoNovo;
        private System.Windows.Forms.ToolStripButton botaoSalvar;
        private System.Windows.Forms.ToolStripButton botaoExcluir;
        private System.Windows.Forms.ToolStripButton botaoEditar;
        private System.Windows.Forms.ToolStripButton botaoImprimir;
        private System.Windows.Forms.ToolStripButton botaoFechar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUnidadeMedida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdFornecedor;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Button botaoPesquisaFornecedor;
        private System.Windows.Forms.Label labelNomeFornecedor;
    }
}