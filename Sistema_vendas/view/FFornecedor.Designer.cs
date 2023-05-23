namespace Sistema_vendas.view
{
    partial class FFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFornecedor));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPesquisa = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.botaoPesquisar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabDados = new System.Windows.Forms.TabPage();
            this.txtUF = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.tabDados.Controls.Add(this.txtUF);
            this.tabDados.Controls.Add(this.label10);
            this.tabDados.Controls.Add(this.txtCidade);
            this.tabDados.Controls.Add(this.label9);
            this.tabDados.Controls.Add(this.txtBairro);
            this.tabDados.Controls.Add(this.label8);
            this.tabDados.Controls.Add(this.txtLogradouro);
            this.tabDados.Controls.Add(this.label7);
            this.tabDados.Controls.Add(this.textEmail);
            this.tabDados.Controls.Add(this.label6);
            this.tabDados.Controls.Add(this.txtTelefone);
            this.tabDados.Controls.Add(this.label5);
            this.tabDados.Controls.Add(this.txtCpf);
            this.tabDados.Controls.Add(this.label4);
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
            // txtUF
            // 
            this.txtUF.FormattingEnabled = true;
            this.txtUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.txtUF.Location = new System.Drawing.Point(171, 363);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(78, 28);
            this.txtUF.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(125, 366);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "UF:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(171, 321);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(355, 26);
            this.txtCidade.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(102, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Cidade:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(171, 277);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(355, 26);
            this.txtBairro.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Bairro:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(171, 235);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(355, 26);
            this.txtLogradouro.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Logradouro:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(171, 193);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(355, 26);
            this.textEmail.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Email:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(171, 149);
            this.txtTelefone.Mask = "(##) #####-####";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(141, 26);
            this.txtTelefone.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefone:";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(171, 105);
            this.txtCpf.Mask = "###,###,###-##";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(141, 26);
            this.txtCpf.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "CPF:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(171, 69);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(355, 26);
            this.txtNome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(171, 27);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 26);
            this.txtId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 0;
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
            this.label1.Size = new System.Drawing.Size(260, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Fornecedores";
            // 
            // FFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 692);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FFornecedor";
            this.Text = "FFornecedor";
            this.Load += new System.EventHandler(this.FFornecedor_Load);
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
        private System.Windows.Forms.ComboBox txtUF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton botaoNovo;
        private System.Windows.Forms.ToolStripButton botaoSalvar;
        private System.Windows.Forms.ToolStripButton botaoExcluir;
        private System.Windows.Forms.ToolStripButton botaoEditar;
        private System.Windows.Forms.ToolStripButton botaoImprimir;
        private System.Windows.Forms.ToolStripButton botaoFechar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}