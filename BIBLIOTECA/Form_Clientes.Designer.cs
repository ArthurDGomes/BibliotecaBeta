namespace BIBLIOTECA
{
    partial class Form_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Clientes));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cURSODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mULTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bIBLIOTECA2020DataSet1 = new BIBLIOTECA.BIBLIOTECA2020DataSet1();
            this.butINSERIR = new System.Windows.Forms.Button();
            this.butEDITAR = new System.Windows.Forms.Button();
            this.butREMOVER = new System.Windows.Forms.Button();
            this.butSAIR = new System.Windows.Forms.Button();
            this.textBoxMULTA = new System.Windows.Forms.TextBox();
            this.textBoxCURSO = new System.Windows.Forms.TextBox();
            this.textBoxDIAS = new System.Windows.Forms.TextBox();
            this.textBoxNOME = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelNOME = new System.Windows.Forms.Label();
            this.labelCURSO = new System.Windows.Forms.Label();
            this.labelDIAS = new System.Windows.Forms.Label();
            this.labelMULTA = new System.Windows.Forms.Label();
            this.bIBLIOTECA2020DataSet = new BIBLIOTECA.BIBLIOTECA2020DataSet();
            this.cLIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTESTableAdapter = new BIBLIOTECA.BIBLIOTECA2020DataSetTableAdapters.CLIENTESTableAdapter();
            this.cLIENTESTableAdapter1 = new BIBLIOTECA.BIBLIOTECA2020DataSet1TableAdapters.CLIENTESTableAdapter();
            this.GbPesquisaCli = new System.Windows.Forms.GroupBox();
            this.RbTodosCli = new System.Windows.Forms.RadioButton();
            this.ButFiltrarLi = new System.Windows.Forms.Button();
            this.txtBoxfiltro = new System.Windows.Forms.TextBox();
            this.labelCli = new System.Windows.Forms.Label();
            this.RbNomeCli = new System.Windows.Forms.RadioButton();
            this.RbIDCli = new System.Windows.Forms.RadioButton();
            this.ButPesqCli = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECA2020DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECA2020DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).BeginInit();
            this.GbPesquisaCli.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nOMEDataGridViewTextBoxColumn,
            this.cURSODataGridViewTextBoxColumn,
            this.dIASDataGridViewTextBoxColumn,
            this.mULTADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cLIENTESBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(27, 345);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(700, 102);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nOMEDataGridViewTextBoxColumn
            // 
            this.nOMEDataGridViewTextBoxColumn.DataPropertyName = "NOME";
            this.nOMEDataGridViewTextBoxColumn.HeaderText = "NOME";
            this.nOMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nOMEDataGridViewTextBoxColumn.Name = "nOMEDataGridViewTextBoxColumn";
            this.nOMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // cURSODataGridViewTextBoxColumn
            // 
            this.cURSODataGridViewTextBoxColumn.DataPropertyName = "CURSO";
            this.cURSODataGridViewTextBoxColumn.HeaderText = "CURSO";
            this.cURSODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cURSODataGridViewTextBoxColumn.Name = "cURSODataGridViewTextBoxColumn";
            this.cURSODataGridViewTextBoxColumn.Width = 125;
            // 
            // dIASDataGridViewTextBoxColumn
            // 
            this.dIASDataGridViewTextBoxColumn.DataPropertyName = "DIAS";
            this.dIASDataGridViewTextBoxColumn.HeaderText = "DIAS";
            this.dIASDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dIASDataGridViewTextBoxColumn.Name = "dIASDataGridViewTextBoxColumn";
            this.dIASDataGridViewTextBoxColumn.Width = 125;
            // 
            // mULTADataGridViewTextBoxColumn
            // 
            this.mULTADataGridViewTextBoxColumn.DataPropertyName = "MULTA";
            this.mULTADataGridViewTextBoxColumn.HeaderText = "MULTA";
            this.mULTADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mULTADataGridViewTextBoxColumn.Name = "mULTADataGridViewTextBoxColumn";
            this.mULTADataGridViewTextBoxColumn.Width = 125;
            // 
            // cLIENTESBindingSource1
            // 
            this.cLIENTESBindingSource1.DataMember = "CLIENTES";
            this.cLIENTESBindingSource1.DataSource = this.bIBLIOTECA2020DataSet1;
            // 
            // bIBLIOTECA2020DataSet1
            // 
            this.bIBLIOTECA2020DataSet1.DataSetName = "BIBLIOTECA2020DataSet1";
            this.bIBLIOTECA2020DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // butINSERIR
            // 
            this.butINSERIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butINSERIR.Location = new System.Drawing.Point(91, 301);
            this.butINSERIR.Margin = new System.Windows.Forms.Padding(2);
            this.butINSERIR.Name = "butINSERIR";
            this.butINSERIR.Size = new System.Drawing.Size(83, 28);
            this.butINSERIR.TabIndex = 6;
            this.butINSERIR.Text = "&Inserir";
            this.butINSERIR.UseVisualStyleBackColor = true;
            this.butINSERIR.Click += new System.EventHandler(this.butINSERIR_Click);
            // 
            // butEDITAR
            // 
            this.butEDITAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEDITAR.Location = new System.Drawing.Point(214, 301);
            this.butEDITAR.Margin = new System.Windows.Forms.Padding(2);
            this.butEDITAR.Name = "butEDITAR";
            this.butEDITAR.Size = new System.Drawing.Size(75, 29);
            this.butEDITAR.TabIndex = 7;
            this.butEDITAR.Text = "&Editar";
            this.butEDITAR.UseVisualStyleBackColor = true;
            this.butEDITAR.Click += new System.EventHandler(this.butEDITAR_Click);
            // 
            // butREMOVER
            // 
            this.butREMOVER.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butREMOVER.Location = new System.Drawing.Point(327, 301);
            this.butREMOVER.Margin = new System.Windows.Forms.Padding(2);
            this.butREMOVER.Name = "butREMOVER";
            this.butREMOVER.Size = new System.Drawing.Size(107, 28);
            this.butREMOVER.TabIndex = 8;
            this.butREMOVER.Text = "&Remover";
            this.butREMOVER.UseVisualStyleBackColor = true;
            this.butREMOVER.Click += new System.EventHandler(this.butREMOVER_Click);
            // 
            // butSAIR
            // 
            this.butSAIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSAIR.Location = new System.Drawing.Point(580, 301);
            this.butSAIR.Margin = new System.Windows.Forms.Padding(2);
            this.butSAIR.Name = "butSAIR";
            this.butSAIR.Size = new System.Drawing.Size(81, 28);
            this.butSAIR.TabIndex = 9;
            this.butSAIR.Text = "&Sair";
            this.butSAIR.UseVisualStyleBackColor = true;
            this.butSAIR.Click += new System.EventHandler(this.butSAIR_Click);
            // 
            // textBoxMULTA
            // 
            this.textBoxMULTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMULTA.Location = new System.Drawing.Point(135, 250);
            this.textBoxMULTA.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMULTA.Name = "textBoxMULTA";
            this.textBoxMULTA.Size = new System.Drawing.Size(73, 28);
            this.textBoxMULTA.TabIndex = 5;
            // 
            // textBoxCURSO
            // 
            this.textBoxCURSO.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCURSO.Location = new System.Drawing.Point(135, 163);
            this.textBoxCURSO.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCURSO.Name = "textBoxCURSO";
            this.textBoxCURSO.Size = new System.Drawing.Size(253, 28);
            this.textBoxCURSO.TabIndex = 3;
            // 
            // textBoxDIAS
            // 
            this.textBoxDIAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDIAS.Location = new System.Drawing.Point(135, 206);
            this.textBoxDIAS.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDIAS.Name = "textBoxDIAS";
            this.textBoxDIAS.Size = new System.Drawing.Size(73, 28);
            this.textBoxDIAS.TabIndex = 4;
            // 
            // textBoxNOME
            // 
            this.textBoxNOME.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNOME.Location = new System.Drawing.Point(135, 122);
            this.textBoxNOME.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNOME.Name = "textBoxNOME";
            this.textBoxNOME.Size = new System.Drawing.Size(285, 28);
            this.textBoxNOME.TabIndex = 2;
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(135, 78);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(94, 28);
            this.textBoxID.TabIndex = 1;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(43, 78);
            this.labelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(32, 24);
            this.labelID.TabIndex = 10;
            this.labelID.Text = "ID:";
            // 
            // labelNOME
            // 
            this.labelNOME.AutoSize = true;
            this.labelNOME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelNOME.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNOME.Location = new System.Drawing.Point(43, 120);
            this.labelNOME.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNOME.Name = "labelNOME";
            this.labelNOME.Size = new System.Drawing.Size(67, 24);
            this.labelNOME.TabIndex = 11;
            this.labelNOME.Text = "Nome:";
            // 
            // labelCURSO
            // 
            this.labelCURSO.AutoSize = true;
            this.labelCURSO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelCURSO.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCURSO.Location = new System.Drawing.Point(43, 161);
            this.labelCURSO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCURSO.Name = "labelCURSO";
            this.labelCURSO.Size = new System.Drawing.Size(65, 24);
            this.labelCURSO.TabIndex = 12;
            this.labelCURSO.Text = "Curso:";
            // 
            // labelDIAS
            // 
            this.labelDIAS.AutoSize = true;
            this.labelDIAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelDIAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDIAS.Location = new System.Drawing.Point(43, 205);
            this.labelDIAS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDIAS.Name = "labelDIAS";
            this.labelDIAS.Size = new System.Drawing.Size(51, 24);
            this.labelDIAS.TabIndex = 13;
            this.labelDIAS.Text = "Dias:";
            // 
            // labelMULTA
            // 
            this.labelMULTA.AutoSize = true;
            this.labelMULTA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelMULTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMULTA.Location = new System.Drawing.Point(43, 250);
            this.labelMULTA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMULTA.Name = "labelMULTA";
            this.labelMULTA.Size = new System.Drawing.Size(60, 24);
            this.labelMULTA.TabIndex = 14;
            this.labelMULTA.Text = "Multa:";
            // 
            // bIBLIOTECA2020DataSet
            // 
            this.bIBLIOTECA2020DataSet.DataSetName = "BIBLIOTECA2020DataSet";
            this.bIBLIOTECA2020DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTESBindingSource
            // 
            this.cLIENTESBindingSource.DataMember = "CLIENTES";
            this.cLIENTESBindingSource.DataSource = this.bIBLIOTECA2020DataSet;
            // 
            // cLIENTESTableAdapter
            // 
            this.cLIENTESTableAdapter.ClearBeforeFill = true;
            // 
            // cLIENTESTableAdapter1
            // 
            this.cLIENTESTableAdapter1.ClearBeforeFill = true;
            // 
            // GbPesquisaCli
            // 
            this.GbPesquisaCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.GbPesquisaCli.Controls.Add(this.RbTodosCli);
            this.GbPesquisaCli.Controls.Add(this.ButFiltrarLi);
            this.GbPesquisaCli.Controls.Add(this.txtBoxfiltro);
            this.GbPesquisaCli.Controls.Add(this.labelCli);
            this.GbPesquisaCli.Controls.Add(this.RbNomeCli);
            this.GbPesquisaCli.Controls.Add(this.RbIDCli);
            this.GbPesquisaCli.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbPesquisaCli.Location = new System.Drawing.Point(452, 27);
            this.GbPesquisaCli.Name = "GbPesquisaCli";
            this.GbPesquisaCli.Size = new System.Drawing.Size(385, 247);
            this.GbPesquisaCli.TabIndex = 15;
            this.GbPesquisaCli.TabStop = false;
            this.GbPesquisaCli.Text = "Pesquisar";
            this.GbPesquisaCli.Visible = false;
            // 
            // RbTodosCli
            // 
            this.RbTodosCli.AutoSize = true;
            this.RbTodosCli.Location = new System.Drawing.Point(17, 37);
            this.RbTodosCli.Name = "RbTodosCli";
            this.RbTodosCli.Size = new System.Drawing.Size(85, 29);
            this.RbTodosCli.TabIndex = 7;
            this.RbTodosCli.TabStop = true;
            this.RbTodosCli.Text = "Todos";
            this.RbTodosCli.UseVisualStyleBackColor = true;
            this.RbTodosCli.CheckedChanged += new System.EventHandler(this.RbTodosCli_CheckedChanged);
            // 
            // ButFiltrarLi
            // 
            this.ButFiltrarLi.Image = ((System.Drawing.Image)(resources.GetObject("ButFiltrarLi.Image")));
            this.ButFiltrarLi.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ButFiltrarLi.Location = new System.Drawing.Point(274, 193);
            this.ButFiltrarLi.Name = "ButFiltrarLi";
            this.ButFiltrarLi.Size = new System.Drawing.Size(109, 33);
            this.ButFiltrarLi.TabIndex = 6;
            this.ButFiltrarLi.Text = "Filtrar";
            this.ButFiltrarLi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButFiltrarLi.UseVisualStyleBackColor = true;
            this.ButFiltrarLi.Click += new System.EventHandler(this.ButFiltrarLi_Click);
            // 
            // txtBoxfiltro
            // 
            this.txtBoxfiltro.Location = new System.Drawing.Point(17, 190);
            this.txtBoxfiltro.Name = "txtBoxfiltro";
            this.txtBoxfiltro.Size = new System.Drawing.Size(251, 38);
            this.txtBoxfiltro.TabIndex = 3;
            // 
            // labelCli
            // 
            this.labelCli.Location = new System.Drawing.Point(25, 150);
            this.labelCli.Name = "labelCli";
            this.labelCli.Size = new System.Drawing.Size(243, 34);
            this.labelCli.TabIndex = 2;
            // 
            // RbNomeCli
            // 
            this.RbNomeCli.AutoSize = true;
            this.RbNomeCli.Location = new System.Drawing.Point(17, 107);
            this.RbNomeCli.Name = "RbNomeCli";
            this.RbNomeCli.Size = new System.Drawing.Size(84, 29);
            this.RbNomeCli.TabIndex = 1;
            this.RbNomeCli.TabStop = true;
            this.RbNomeCli.Text = "Nome";
            this.RbNomeCli.UseVisualStyleBackColor = true;
            this.RbNomeCli.CheckedChanged += new System.EventHandler(this.RbNomeCli_CheckedChanged);
            // 
            // RbIDCli
            // 
            this.RbIDCli.AutoSize = true;
            this.RbIDCli.Location = new System.Drawing.Point(17, 72);
            this.RbIDCli.Name = "RbIDCli";
            this.RbIDCli.Size = new System.Drawing.Size(51, 29);
            this.RbIDCli.TabIndex = 0;
            this.RbIDCli.TabStop = true;
            this.RbIDCli.Text = "ID";
            this.RbIDCli.UseVisualStyleBackColor = true;
            this.RbIDCli.CheckedChanged += new System.EventHandler(this.RbIDCli_CheckedChanged);
            // 
            // ButPesqCli
            // 
            this.ButPesqCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButPesqCli.Location = new System.Drawing.Point(452, 302);
            this.ButPesqCli.Margin = new System.Windows.Forms.Padding(2);
            this.ButPesqCli.Name = "ButPesqCli";
            this.ButPesqCli.Size = new System.Drawing.Size(108, 28);
            this.ButPesqCli.TabIndex = 16;
            this.ButPesqCli.Text = "&Pesquisar";
            this.ButPesqCli.UseVisualStyleBackColor = true;
            this.ButPesqCli.Click += new System.EventHandler(this.ButPesqCli_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Ravie", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 48);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cliente";
            // 
            // Form_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButPesqCli);
            this.Controls.Add(this.GbPesquisaCli);
            this.Controls.Add(this.labelMULTA);
            this.Controls.Add(this.labelDIAS);
            this.Controls.Add(this.labelCURSO);
            this.Controls.Add(this.labelNOME);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxNOME);
            this.Controls.Add(this.textBoxDIAS);
            this.Controls.Add(this.textBoxCURSO);
            this.Controls.Add(this.textBoxMULTA);
            this.Controls.Add(this.butSAIR);
            this.Controls.Add(this.butREMOVER);
            this.Controls.Add(this.butEDITAR);
            this.Controls.Add(this.butINSERIR);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECA2020DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECA2020DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).EndInit();
            this.GbPesquisaCli.ResumeLayout(false);
            this.GbPesquisaCli.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butINSERIR;
        private System.Windows.Forms.Button butEDITAR;
        private System.Windows.Forms.Button butREMOVER;
        private System.Windows.Forms.Button butSAIR;
        private System.Windows.Forms.TextBox textBoxMULTA;
        private System.Windows.Forms.TextBox textBoxCURSO;
        private System.Windows.Forms.TextBox textBoxDIAS;
        private System.Windows.Forms.TextBox textBoxNOME;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelNOME;
        private System.Windows.Forms.Label labelCURSO;
        private System.Windows.Forms.Label labelDIAS;
        private System.Windows.Forms.Label labelMULTA;
        private BIBLIOTECA2020DataSet bIBLIOTECA2020DataSet;
        private System.Windows.Forms.BindingSource cLIENTESBindingSource;
        private BIBLIOTECA2020DataSetTableAdapters.CLIENTESTableAdapter cLIENTESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cURSODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mULTADataGridViewTextBoxColumn;
        private BIBLIOTECA2020DataSet1 bIBLIOTECA2020DataSet1;
        private System.Windows.Forms.BindingSource cLIENTESBindingSource1;
        private BIBLIOTECA2020DataSet1TableAdapters.CLIENTESTableAdapter cLIENTESTableAdapter1;
        private System.Windows.Forms.GroupBox GbPesquisaCli;
        private System.Windows.Forms.Button ButPesqCli;
        private System.Windows.Forms.TextBox txtBoxfiltro;
        private System.Windows.Forms.Label labelCli;
        private System.Windows.Forms.RadioButton RbNomeCli;
        private System.Windows.Forms.RadioButton RbIDCli;
        private System.Windows.Forms.Button ButFiltrarLi;
        private System.Windows.Forms.RadioButton RbTodosCli;
        private System.Windows.Forms.Label label1;
    }
}

