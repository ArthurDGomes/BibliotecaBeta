namespace BIBLIOTECA
{
    partial class Form_Revista
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Revista));
            this.ButPesqCli = new System.Windows.Forms.Button();
            this.GbPesquisaRe = new System.Windows.Forms.GroupBox();
            this.RbTodosRe = new System.Windows.Forms.RadioButton();
            this.ButFiltrarRe = new System.Windows.Forms.Button();
            this.txtBoxfiltro = new System.Windows.Forms.TextBox();
            this.labelrevista = new System.Windows.Forms.Label();
            this.RbtituloRe = new System.Windows.Forms.RadioButton();
            this.RbIDRe = new System.Windows.Forms.RadioButton();
            this.labelSitucao = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.labelEditora = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxtitulo = new System.Windows.Forms.TextBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.textBoxEditora = new System.Windows.Forms.TextBox();
            this.textBoxSituacao = new System.Windows.Forms.TextBox();
            this.butSAIR = new System.Windows.Forms.Button();
            this.butREMOVER = new System.Windows.Forms.Button();
            this.butEDITAR = new System.Windows.Forms.Button();
            this.butINSERIR = new System.Windows.Forms.Button();
            this.dgvRevista = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tITULODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDITORADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sITUACAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEVISTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bIBLIOTECA2020DataSet3 = new BIBLIOTECA.BIBLIOTECA2020DataSet3();
            this.rEVISTATableAdapter = new BIBLIOTECA.BIBLIOTECA2020DataSet3TableAdapters.REVISTATableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.GbPesquisaRe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEVISTABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECA2020DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // ButPesqCli
            // 
            this.ButPesqCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButPesqCli.Location = new System.Drawing.Point(408, 303);
            this.ButPesqCli.Margin = new System.Windows.Forms.Padding(2);
            this.ButPesqCli.Name = "ButPesqCli";
            this.ButPesqCli.Size = new System.Drawing.Size(108, 28);
            this.ButPesqCli.TabIndex = 33;
            this.ButPesqCli.Text = "&Pesquisar";
            this.ButPesqCli.UseVisualStyleBackColor = true;
            this.ButPesqCli.Click += new System.EventHandler(this.ButPesqCli_Click);
            // 
            // GbPesquisaRe
            // 
            this.GbPesquisaRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.GbPesquisaRe.Controls.Add(this.RbTodosRe);
            this.GbPesquisaRe.Controls.Add(this.ButFiltrarRe);
            this.GbPesquisaRe.Controls.Add(this.txtBoxfiltro);
            this.GbPesquisaRe.Controls.Add(this.labelrevista);
            this.GbPesquisaRe.Controls.Add(this.RbtituloRe);
            this.GbPesquisaRe.Controls.Add(this.RbIDRe);
            this.GbPesquisaRe.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbPesquisaRe.Location = new System.Drawing.Point(455, 36);
            this.GbPesquisaRe.Name = "GbPesquisaRe";
            this.GbPesquisaRe.Size = new System.Drawing.Size(398, 247);
            this.GbPesquisaRe.TabIndex = 32;
            this.GbPesquisaRe.TabStop = false;
            this.GbPesquisaRe.Text = "Pesquisar";
            this.GbPesquisaRe.Visible = false;
            // 
            // RbTodosRe
            // 
            this.RbTodosRe.AutoSize = true;
            this.RbTodosRe.Location = new System.Drawing.Point(17, 37);
            this.RbTodosRe.Name = "RbTodosRe";
            this.RbTodosRe.Size = new System.Drawing.Size(85, 29);
            this.RbTodosRe.TabIndex = 7;
            this.RbTodosRe.TabStop = true;
            this.RbTodosRe.Text = "Todos";
            this.RbTodosRe.UseVisualStyleBackColor = true;
            this.RbTodosRe.CheckedChanged += new System.EventHandler(this.RbTodosRe_CheckedChanged);
            // 
            // ButFiltrarRe
            // 
            this.ButFiltrarRe.Image = ((System.Drawing.Image)(resources.GetObject("ButFiltrarRe.Image")));
            this.ButFiltrarRe.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ButFiltrarRe.Location = new System.Drawing.Point(274, 193);
            this.ButFiltrarRe.Name = "ButFiltrarRe";
            this.ButFiltrarRe.Size = new System.Drawing.Size(109, 33);
            this.ButFiltrarRe.TabIndex = 6;
            this.ButFiltrarRe.Text = "Filtrar";
            this.ButFiltrarRe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButFiltrarRe.UseVisualStyleBackColor = true;
            this.ButFiltrarRe.Click += new System.EventHandler(this.ButFiltrarRe_Click);
            // 
            // txtBoxfiltro
            // 
            this.txtBoxfiltro.Location = new System.Drawing.Point(17, 190);
            this.txtBoxfiltro.Name = "txtBoxfiltro";
            this.txtBoxfiltro.Size = new System.Drawing.Size(251, 38);
            this.txtBoxfiltro.TabIndex = 3;
            // 
            // labelrevista
            // 
            this.labelrevista.Location = new System.Drawing.Point(25, 150);
            this.labelrevista.Name = "labelrevista";
            this.labelrevista.Size = new System.Drawing.Size(243, 34);
            this.labelrevista.TabIndex = 2;
            // 
            // RbtituloRe
            // 
            this.RbtituloRe.AutoSize = true;
            this.RbtituloRe.Location = new System.Drawing.Point(17, 107);
            this.RbtituloRe.Name = "RbtituloRe";
            this.RbtituloRe.Size = new System.Drawing.Size(89, 29);
            this.RbtituloRe.TabIndex = 1;
            this.RbtituloRe.TabStop = true;
            this.RbtituloRe.Text = "Título";
            this.RbtituloRe.UseVisualStyleBackColor = true;
            this.RbtituloRe.CheckedChanged += new System.EventHandler(this.RbtituloRe_CheckedChanged);
            // 
            // RbIDRe
            // 
            this.RbIDRe.AutoSize = true;
            this.RbIDRe.Location = new System.Drawing.Point(17, 72);
            this.RbIDRe.Name = "RbIDRe";
            this.RbIDRe.Size = new System.Drawing.Size(51, 29);
            this.RbIDRe.TabIndex = 0;
            this.RbIDRe.TabStop = true;
            this.RbIDRe.Text = "ID";
            this.RbIDRe.UseVisualStyleBackColor = true;
            this.RbIDRe.CheckedChanged += new System.EventHandler(this.RbIDRe_CheckedChanged);
            // 
            // labelSitucao
            // 
            this.labelSitucao.AutoSize = true;
            this.labelSitucao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelSitucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSitucao.Location = new System.Drawing.Point(23, 243);
            this.labelSitucao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSitucao.Name = "labelSitucao";
            this.labelSitucao.Size = new System.Drawing.Size(82, 24);
            this.labelSitucao.TabIndex = 31;
            this.labelSitucao.Text = "Situação";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValor.Location = new System.Drawing.Point(46, 198);
            this.labelValor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(59, 24);
            this.labelValor.TabIndex = 30;
            this.labelValor.Text = "Valor:";
            // 
            // labelEditora
            // 
            this.labelEditora.AutoSize = true;
            this.labelEditora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditora.Location = new System.Drawing.Point(31, 154);
            this.labelEditora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEditora.Name = "labelEditora";
            this.labelEditora.Size = new System.Drawing.Size(74, 24);
            this.labelEditora.TabIndex = 29;
            this.labelEditora.Text = "Editora:";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(44, 113);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(61, 24);
            this.labelTitulo.TabIndex = 28;
            this.labelTitulo.Text = "Título:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(73, 71);
            this.labelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(32, 24);
            this.labelID.TabIndex = 27;
            this.labelID.Text = "ID:";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(115, 71);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(94, 28);
            this.textBoxID.TabIndex = 18;
            // 
            // textBoxtitulo
            // 
            this.textBoxtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxtitulo.Location = new System.Drawing.Point(115, 115);
            this.textBoxtitulo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxtitulo.Name = "textBoxtitulo";
            this.textBoxtitulo.Size = new System.Drawing.Size(285, 28);
            this.textBoxtitulo.TabIndex = 19;
            // 
            // textBoxValor
            // 
            this.textBoxValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValor.Location = new System.Drawing.Point(115, 199);
            this.textBoxValor.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(73, 28);
            this.textBoxValor.TabIndex = 21;
            // 
            // textBoxEditora
            // 
            this.textBoxEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditora.Location = new System.Drawing.Point(115, 156);
            this.textBoxEditora.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEditora.Name = "textBoxEditora";
            this.textBoxEditora.Size = new System.Drawing.Size(253, 28);
            this.textBoxEditora.TabIndex = 20;
            // 
            // textBoxSituacao
            // 
            this.textBoxSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSituacao.Location = new System.Drawing.Point(115, 243);
            this.textBoxSituacao.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSituacao.Name = "textBoxSituacao";
            this.textBoxSituacao.Size = new System.Drawing.Size(73, 28);
            this.textBoxSituacao.TabIndex = 22;
            // 
            // butSAIR
            // 
            this.butSAIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSAIR.Location = new System.Drawing.Point(537, 302);
            this.butSAIR.Margin = new System.Windows.Forms.Padding(2);
            this.butSAIR.Name = "butSAIR";
            this.butSAIR.Size = new System.Drawing.Size(81, 28);
            this.butSAIR.TabIndex = 26;
            this.butSAIR.Text = "&Sair";
            this.butSAIR.UseVisualStyleBackColor = true;
            this.butSAIR.Click += new System.EventHandler(this.butSAIR_Click);
            // 
            // butREMOVER
            // 
            this.butREMOVER.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butREMOVER.Location = new System.Drawing.Point(281, 303);
            this.butREMOVER.Margin = new System.Windows.Forms.Padding(2);
            this.butREMOVER.Name = "butREMOVER";
            this.butREMOVER.Size = new System.Drawing.Size(107, 28);
            this.butREMOVER.TabIndex = 25;
            this.butREMOVER.Text = "&Remover";
            this.butREMOVER.UseVisualStyleBackColor = true;
            this.butREMOVER.Click += new System.EventHandler(this.butREMOVER_Click);
            // 
            // butEDITAR
            // 
            this.butEDITAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEDITAR.Location = new System.Drawing.Point(185, 302);
            this.butEDITAR.Margin = new System.Windows.Forms.Padding(2);
            this.butEDITAR.Name = "butEDITAR";
            this.butEDITAR.Size = new System.Drawing.Size(75, 29);
            this.butEDITAR.TabIndex = 24;
            this.butEDITAR.Text = "&Editar";
            this.butEDITAR.UseVisualStyleBackColor = true;
            this.butEDITAR.Click += new System.EventHandler(this.butEDITAR_Click);
            // 
            // butINSERIR
            // 
            this.butINSERIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butINSERIR.Location = new System.Drawing.Point(77, 303);
            this.butINSERIR.Margin = new System.Windows.Forms.Padding(2);
            this.butINSERIR.Name = "butINSERIR";
            this.butINSERIR.Size = new System.Drawing.Size(83, 28);
            this.butINSERIR.TabIndex = 23;
            this.butINSERIR.Text = "&Inserir";
            this.butINSERIR.UseVisualStyleBackColor = true;
            this.butINSERIR.Click += new System.EventHandler(this.butINSERIR_Click_1);
            // 
            // dgvRevista
            // 
            this.dgvRevista.AllowUserToAddRows = false;
            this.dgvRevista.AllowUserToDeleteRows = false;
            this.dgvRevista.AutoGenerateColumns = false;
            this.dgvRevista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvRevista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRevista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.tITULODataGridViewTextBoxColumn,
            this.eDITORADataGridViewTextBoxColumn,
            this.vALORDataGridViewTextBoxColumn,
            this.sITUACAODataGridViewTextBoxColumn});
            this.dgvRevista.DataSource = this.rEVISTABindingSource;
            this.dgvRevista.Location = new System.Drawing.Point(77, 362);
            this.dgvRevista.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRevista.Name = "dgvRevista";
            this.dgvRevista.RowHeadersWidth = 51;
            this.dgvRevista.RowTemplate.Height = 24;
            this.dgvRevista.Size = new System.Drawing.Size(553, 102);
            this.dgvRevista.TabIndex = 17;
            this.dgvRevista.DoubleClick += new System.EventHandler(this.dgvRevista_DoubleClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tITULODataGridViewTextBoxColumn
            // 
            this.tITULODataGridViewTextBoxColumn.DataPropertyName = "TITULO";
            this.tITULODataGridViewTextBoxColumn.HeaderText = "TITULO";
            this.tITULODataGridViewTextBoxColumn.Name = "tITULODataGridViewTextBoxColumn";
            // 
            // eDITORADataGridViewTextBoxColumn
            // 
            this.eDITORADataGridViewTextBoxColumn.DataPropertyName = "EDITORA";
            this.eDITORADataGridViewTextBoxColumn.HeaderText = "EDITORA";
            this.eDITORADataGridViewTextBoxColumn.Name = "eDITORADataGridViewTextBoxColumn";
            // 
            // vALORDataGridViewTextBoxColumn
            // 
            this.vALORDataGridViewTextBoxColumn.DataPropertyName = "VALOR";
            this.vALORDataGridViewTextBoxColumn.HeaderText = "VALOR";
            this.vALORDataGridViewTextBoxColumn.Name = "vALORDataGridViewTextBoxColumn";
            // 
            // sITUACAODataGridViewTextBoxColumn
            // 
            this.sITUACAODataGridViewTextBoxColumn.DataPropertyName = "SITUACAO";
            this.sITUACAODataGridViewTextBoxColumn.HeaderText = "SITUACAO";
            this.sITUACAODataGridViewTextBoxColumn.Name = "sITUACAODataGridViewTextBoxColumn";
            // 
            // rEVISTABindingSource
            // 
            this.rEVISTABindingSource.DataMember = "REVISTA";
            this.rEVISTABindingSource.DataSource = this.bIBLIOTECA2020DataSet3;
            // 
            // bIBLIOTECA2020DataSet3
            // 
            this.bIBLIOTECA2020DataSet3.DataSetName = "BIBLIOTECA2020DataSet3";
            this.bIBLIOTECA2020DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rEVISTATableAdapter
            // 
            this.rEVISTATableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Ravie", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 48);
            this.label1.TabIndex = 34;
            this.label1.Text = "Revista";
            // 
            // Form_Revista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(865, 472);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButPesqCli);
            this.Controls.Add(this.GbPesquisaRe);
            this.Controls.Add(this.labelSitucao);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.labelEditora);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxtitulo);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.textBoxEditora);
            this.Controls.Add(this.textBoxSituacao);
            this.Controls.Add(this.butSAIR);
            this.Controls.Add(this.butREMOVER);
            this.Controls.Add(this.butEDITAR);
            this.Controls.Add(this.butINSERIR);
            this.Controls.Add(this.dgvRevista);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Revista";
            this.Text = "Revista";
            this.Load += new System.EventHandler(this.Form_Revista_Load);
            this.GbPesquisaRe.ResumeLayout(false);
            this.GbPesquisaRe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEVISTABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECA2020DataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButPesqCli;
        private System.Windows.Forms.GroupBox GbPesquisaRe;
        private System.Windows.Forms.RadioButton RbTodosRe;
        private System.Windows.Forms.Button ButFiltrarRe;
        private System.Windows.Forms.TextBox txtBoxfiltro;
        private System.Windows.Forms.Label labelrevista;
        private System.Windows.Forms.RadioButton RbtituloRe;
        private System.Windows.Forms.RadioButton RbIDRe;
        private System.Windows.Forms.Label labelSitucao;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Label labelEditora;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxtitulo;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.TextBox textBoxEditora;
        private System.Windows.Forms.TextBox textBoxSituacao;
        private System.Windows.Forms.Button butSAIR;
        private System.Windows.Forms.Button butREMOVER;
        private System.Windows.Forms.Button butEDITAR;
        private System.Windows.Forms.Button butINSERIR;
        private System.Windows.Forms.DataGridView dgvRevista;
        private BIBLIOTECA2020DataSet3 bIBLIOTECA2020DataSet3;
        private System.Windows.Forms.BindingSource rEVISTABindingSource;
        private BIBLIOTECA2020DataSet3TableAdapters.REVISTATableAdapter rEVISTATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tITULODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDITORADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sITUACAODataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}