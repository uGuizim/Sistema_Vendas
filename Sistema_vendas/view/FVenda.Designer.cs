namespace Sistema_vendas.view
{
    partial class FVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FVenda));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPesquisa = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idvenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabDados = new System.Windows.Forms.TabPage();
            this.GridProdutos = new System.Windows.Forms.DataGridView();
            this.idproduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelNomeProduto = new System.Windows.Forms.Label();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDataVenda = new System.Windows.Forms.MaskedTextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.botaoPesquisar = new System.Windows.Forms.Button();
            this.botaoRemover = new System.Windows.Forms.Button();
            this.botaoAdicionar = new System.Windows.Forms.Button();
            this.botaoPesquisarProduto = new System.Windows.Forms.Button();
            this.botaoPesquisaCliente = new System.Windows.Forms.Button();
            this.botaoNovo = new System.Windows.Forms.ToolStripButton();
            this.botaoSalvar = new System.Windows.Forms.ToolStripButton();
            this.botaoExcluir = new System.Windows.Forms.ToolStripButton();
            this.botaoEditar = new System.Windows.Forms.ToolStripButton();
            this.botaoImprimir = new System.Windows.Forms.ToolStripButton();
            this.botaoFechar = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idvenda,
            this.data_venda,
            this.idcliente,
            this.nome_cliente,
            this.valor_total,
            this.idusuario});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1014, 502);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idvenda
            // 
            this.idvenda.DataPropertyName = "idvenda";
            this.idvenda.HeaderText = "Número";
            this.idvenda.Name = "idvenda";
            this.idvenda.ReadOnly = true;
            // 
            // data_venda
            // 
            this.data_venda.DataPropertyName = "data_venda";
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.data_venda.DefaultCellStyle = dataGridViewCellStyle31;
            this.data_venda.HeaderText = "Data";
            this.data_venda.Name = "data_venda";
            this.data_venda.ReadOnly = true;
            this.data_venda.Width = 150;
            // 
            // idcliente
            // 
            this.idcliente.DataPropertyName = "idcliente";
            this.idcliente.HeaderText = "Cliente";
            this.idcliente.Name = "idcliente";
            this.idcliente.ReadOnly = true;
            this.idcliente.Width = 150;
            // 
            // nome_cliente
            // 
            this.nome_cliente.DataPropertyName = "nome";
            this.nome_cliente.HeaderText = "Nome";
            this.nome_cliente.Name = "nome_cliente";
            this.nome_cliente.ReadOnly = true;
            this.nome_cliente.Width = 400;
            // 
            // valor_total
            // 
            this.valor_total.DataPropertyName = "valor_total";
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle32.Format = "N2";
            dataGridViewCellStyle32.NullValue = null;
            this.valor_total.DefaultCellStyle = dataGridViewCellStyle32;
            this.valor_total.HeaderText = "Valor Total";
            this.valor_total.Name = "valor_total";
            this.valor_total.ReadOnly = true;
            this.valor_total.Width = 200;
            // 
            // idusuario
            // 
            this.idusuario.DataPropertyName = "idusuario";
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idusuario.DefaultCellStyle = dataGridViewCellStyle33;
            this.idusuario.HeaderText = "Usuário";
            this.idusuario.Name = "idusuario";
            this.idusuario.ReadOnly = true;
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
            this.tabDados.Controls.Add(this.GridProdutos);
            this.tabDados.Controls.Add(this.panel3);
            this.tabDados.Location = new System.Drawing.Point(4, 29);
            this.tabDados.Name = "tabDados";
            this.tabDados.Padding = new System.Windows.Forms.Padding(3);
            this.tabDados.Size = new System.Drawing.Size(1020, 574);
            this.tabDados.TabIndex = 1;
            this.tabDados.Text = "Dados Gerais";
            this.tabDados.UseVisualStyleBackColor = true;
            // 
            // GridProdutos
            // 
            this.GridProdutos.AllowUserToAddRows = false;
            this.GridProdutos.AllowUserToDeleteRows = false;
            this.GridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproduto,
            this.nome,
            this.quantidade,
            this.valor_unitario,
            this.subtotal});
            this.GridProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridProdutos.Location = new System.Drawing.Point(3, 151);
            this.GridProdutos.Name = "GridProdutos";
            this.GridProdutos.ReadOnly = true;
            this.GridProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridProdutos.Size = new System.Drawing.Size(1014, 420);
            this.GridProdutos.TabIndex = 58;
            this.GridProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProdutos_CellContentClick);
            // 
            // idproduto
            // 
            this.idproduto.DataPropertyName = "idproduto";
            this.idproduto.HeaderText = "Id Prod.";
            this.idproduto.Name = "idproduto";
            this.idproduto.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome Produto";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 400;
            // 
            // quantidade
            // 
            this.quantidade.DataPropertyName = "quantidade";
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle34.Format = "N2";
            dataGridViewCellStyle34.NullValue = null;
            this.quantidade.DefaultCellStyle = dataGridViewCellStyle34;
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            this.quantidade.Width = 150;
            // 
            // valor_unitario
            // 
            this.valor_unitario.DataPropertyName = "valor_unitario";
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle35.Format = "N2";
            dataGridViewCellStyle35.NullValue = null;
            this.valor_unitario.DefaultCellStyle = dataGridViewCellStyle35;
            this.valor_unitario.HeaderText = "Valor Unitário";
            this.valor_unitario.Name = "valor_unitario";
            this.valor_unitario.ReadOnly = true;
            this.valor_unitario.Width = 200;
            // 
            // subtotal
            // 
            this.subtotal.DataPropertyName = "subtotal";
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle36.Format = "N2";
            dataGridViewCellStyle36.NullValue = null;
            this.subtotal.DefaultCellStyle = dataGridViewCellStyle36;
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            this.subtotal.Width = 200;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.txtValorTotal);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.botaoPesquisaCliente);
            this.panel3.Controls.Add(this.labelNomeCliente);
            this.panel3.Controls.Add(this.txtIdCliente);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtDataVenda);
            this.panel3.Controls.Add(this.txtId);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1014, 148);
            this.panel3.TabIndex = 47;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtValorUnitario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtQuantidade);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.botaoRemover);
            this.groupBox1.Controls.Add(this.botaoAdicionar);
            this.groupBox1.Controls.Add(this.botaoPesquisarProduto);
            this.groupBox1.Controls.Add(this.labelNomeProduto);
            this.groupBox1.Controls.Add(this.txtIdProduto);
            this.groupBox1.Location = new System.Drawing.Point(3, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1081, 69);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos";
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorUnitario.Location = new System.Drawing.Point(705, 25);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(101, 26);
            this.txtValorUnitario.TabIndex = 55;
            this.txtValorUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorUnitario_KeyPress);
            this.txtValorUnitario.Leave += new System.EventHandler(this.txtValorUnitario_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(614, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 63;
            this.label3.Text = "Vlr. Unitário:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantidade.Location = new System.Drawing.Point(519, 25);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(89, 26);
            this.txtQuantidade.TabIndex = 54;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            this.txtQuantidade.Leave += new System.EventHandler(this.txtQuantidade_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 61;
            this.label7.Text = "Qtd:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelNomeProduto
            // 
            this.labelNomeProduto.AutoSize = true;
            this.labelNomeProduto.Location = new System.Drawing.Point(151, 28);
            this.labelNomeProduto.Name = "labelNomeProduto";
            this.labelNomeProduto.Size = new System.Drawing.Size(65, 20);
            this.labelNomeProduto.TabIndex = 56;
            this.labelNomeProduto.Text = "Produto";
            this.labelNomeProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdProduto.Location = new System.Drawing.Point(17, 25);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(95, 26);
            this.txtIdProduto.TabIndex = 52;
            this.txtIdProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIdProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdProduto_KeyPress);
            this.txtIdProduto.Leave += new System.EventHandler(this.txtIdProduto_Leave);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.ForeColor = System.Drawing.Color.Black;
            this.txtValorTotal.Location = new System.Drawing.Point(747, 29);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(142, 26);
            this.txtValorTotal.TabIndex = 55;
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(803, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 56;
            this.label8.Text = "Vlr. Total:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(603, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "Data Emissão:";
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.Location = new System.Drawing.Point(264, 35);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(58, 20);
            this.labelNomeCliente.TabIndex = 52;
            this.labelNomeCliente.Text = "Cliente";
            this.labelNomeCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdCliente.Location = new System.Drawing.Point(130, 32);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(95, 26);
            this.txtIdCliente.TabIndex = 49;
            this.txtIdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIdCliente.TextChanged += new System.EventHandler(this.txtIdCliente_TextChanged);
            this.txtIdCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdCliente_KeyPress);
            this.txtIdCliente.Leave += new System.EventHandler(this.txtIdCliente_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(126, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 51;
            this.label9.Text = "Cliente:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDataVenda
            // 
            this.txtDataVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataVenda.Location = new System.Drawing.Point(607, 29);
            this.txtDataVenda.Mask = "00/00/0000";
            this.txtDataVenda.Name = "txtDataVenda";
            this.txtDataVenda.Size = new System.Drawing.Size(109, 26);
            this.txtDataVenda.TabIndex = 51;
            this.txtDataVenda.ValidatingType = typeof(System.DateTime);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.ForeColor = System.Drawing.Color.Black;
            this.txtId.Location = new System.Drawing.Point(15, 32);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 26);
            this.txtId.TabIndex = 48;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Número:";
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
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendas";
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
            // botaoRemover
            // 
            this.botaoRemover.Image = ((System.Drawing.Image)(resources.GetObject("botaoRemover.Image")));
            this.botaoRemover.Location = new System.Drawing.Point(943, 19);
            this.botaoRemover.Name = "botaoRemover";
            this.botaoRemover.Size = new System.Drawing.Size(112, 38);
            this.botaoRemover.TabIndex = 57;
            this.botaoRemover.Text = "Remover";
            this.botaoRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botaoRemover.UseVisualStyleBackColor = true;
            this.botaoRemover.Click += new System.EventHandler(this.botaoRemover_Click);
            // 
            // botaoAdicionar
            // 
            this.botaoAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("botaoAdicionar.Image")));
            this.botaoAdicionar.Location = new System.Drawing.Point(828, 19);
            this.botaoAdicionar.Name = "botaoAdicionar";
            this.botaoAdicionar.Size = new System.Drawing.Size(109, 38);
            this.botaoAdicionar.TabIndex = 56;
            this.botaoAdicionar.Text = "Adicionar";
            this.botaoAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botaoAdicionar.UseVisualStyleBackColor = true;
            this.botaoAdicionar.Click += new System.EventHandler(this.botaoAdicionar_Click);
            // 
            // botaoPesquisarProduto
            // 
            this.botaoPesquisarProduto.Image = ((System.Drawing.Image)(resources.GetObject("botaoPesquisarProduto.Image")));
            this.botaoPesquisarProduto.Location = new System.Drawing.Point(113, 24);
            this.botaoPesquisarProduto.Name = "botaoPesquisarProduto";
            this.botaoPesquisarProduto.Size = new System.Drawing.Size(36, 29);
            this.botaoPesquisarProduto.TabIndex = 53;
            this.botaoPesquisarProduto.UseVisualStyleBackColor = true;
            this.botaoPesquisarProduto.Click += new System.EventHandler(this.botaoPesquisarProduto_Click);
            // 
            // botaoPesquisaCliente
            // 
            this.botaoPesquisaCliente.Image = ((System.Drawing.Image)(resources.GetObject("botaoPesquisaCliente.Image")));
            this.botaoPesquisaCliente.Location = new System.Drawing.Point(226, 31);
            this.botaoPesquisaCliente.Name = "botaoPesquisaCliente";
            this.botaoPesquisaCliente.Size = new System.Drawing.Size(36, 29);
            this.botaoPesquisaCliente.TabIndex = 50;
            this.botaoPesquisaCliente.UseVisualStyleBackColor = true;
            this.botaoPesquisaCliente.Click += new System.EventHandler(this.botaoPesquisaCliente_Click);
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
            // FVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 692);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FVenda";
            this.Text = "FVenda";
            this.Load += new System.EventHandler(this.FVenda_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPesquisa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button botaoPesquisaCliente;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtDataVenda;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView GridProdutos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botaoRemover;
        private System.Windows.Forms.Button botaoAdicionar;
        private System.Windows.Forms.Button botaoPesquisarProduto;
        private System.Windows.Forms.Label labelNomeProduto;
        private System.Windows.Forms.TextBox txtIdProduto;
        internal System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuario;
    }
}