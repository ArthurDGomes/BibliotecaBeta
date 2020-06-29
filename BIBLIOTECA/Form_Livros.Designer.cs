namespace BIBLIOTECA
{
    partial class Form_Livros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Livros));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblIDLi = new System.Windows.Forms.Label();
            this.LblSitLi = new System.Windows.Forms.TextBox();
            this.LblValorLi = new System.Windows.Forms.TextBox();
            this.LblAutorLi = new System.Windows.Forms.TextBox();
            this.LblEdiLi = new System.Windows.Forms.TextBox();
            this.LbltituLi = new System.Windows.Forms.TextBox();
            this.ButInserirLi = new System.Windows.Forms.Button();
            this.ButEditarLi = new System.Windows.Forms.Button();
            this.ButRemoverLi = new System.Windows.Forms.Button();
            this.ButCancelarLi = new System.Windows.Forms.Button();
            this.ButGravarLi = new System.Windows.Forms.Button();
            this.ButVoltarLi = new System.Windows.Forms.Button();
            this.DtGridLivro = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tITULODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDITORADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUTORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sITUACAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lIVROSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bIBLIOTECA2020DataSet2 = new BIBLIOTECA.BIBLIOTECA2020DataSet2();
            this.lIVROSTableAdapter = new BIBLIOTECA.BIBLIOTECA2020DataSet2TableAdapters.LIVROSTableAdapter();
            this.ButPesLi = new System.Windows.Forms.Button();
            this.GpbPesquisa = new System.Windows.Forms.GroupBox();
            this.ButFiltrarLi = new System.Windows.Forms.Button();
            this.LblFiltroLi = new System.Windows.Forms.TextBox();
            this.LblFiltrarLi = new System.Windows.Forms.Label();
            this.RdbTiLi = new System.Windows.Forms.RadioButton();
            this.RdbIDLi = new System.Windows.Forms.RadioButton();
            this.RdbTodosLi = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtGridLivro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIVROSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECA2020DataSet2)).BeginInit();
            this.GpbPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Título:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Editora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Autor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Valor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 264);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Situação:";
            // 
            // LblIDLi
            // 
            this.LblIDLi.BackColor = System.Drawing.SystemColors.Window;
            this.LblIDLi.Enabled = false;
            this.LblIDLi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIDLi.Location = new System.Drawing.Point(130, 89);
            this.LblIDLi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblIDLi.Name = "LblIDLi";
            this.LblIDLi.Size = new System.Drawing.Size(86, 20);
            this.LblIDLi.TabIndex = 19;
            // 
            // LblSitLi
            // 
            this.LblSitLi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSitLi.Location = new System.Drawing.Point(130, 261);
            this.LblSitLi.Margin = new System.Windows.Forms.Padding(2);
            this.LblSitLi.Name = "LblSitLi";
            this.LblSitLi.Size = new System.Drawing.Size(33, 26);
            this.LblSitLi.TabIndex = 5;
            // 
            // LblValorLi
            // 
            this.LblValorLi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValorLi.Location = new System.Drawing.Point(130, 225);
            this.LblValorLi.Margin = new System.Windows.Forms.Padding(2);
            this.LblValorLi.Name = "LblValorLi";
            this.LblValorLi.Size = new System.Drawing.Size(60, 26);
            this.LblValorLi.TabIndex = 4;
            // 
            // LblAutorLi
            // 
            this.LblAutorLi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAutorLi.Location = new System.Drawing.Point(130, 189);
            this.LblAutorLi.Margin = new System.Windows.Forms.Padding(2);
            this.LblAutorLi.Name = "LblAutorLi";
            this.LblAutorLi.Size = new System.Drawing.Size(284, 26);
            this.LblAutorLi.TabIndex = 3;
            // 
            // LblEdiLi
            // 
            this.LblEdiLi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEdiLi.Location = new System.Drawing.Point(130, 153);
            this.LblEdiLi.Margin = new System.Windows.Forms.Padding(2);
            this.LblEdiLi.Name = "LblEdiLi";
            this.LblEdiLi.Size = new System.Drawing.Size(263, 26);
            this.LblEdiLi.TabIndex = 2;
            // 
            // LbltituLi
            // 
            this.LbltituLi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbltituLi.Location = new System.Drawing.Point(130, 117);
            this.LbltituLi.Margin = new System.Windows.Forms.Padding(2);
            this.LbltituLi.Name = "LbltituLi";
            this.LbltituLi.Size = new System.Drawing.Size(284, 26);
            this.LbltituLi.TabIndex = 1;
            // 
            // ButInserirLi
            // 
            this.ButInserirLi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButInserirLi.Location = new System.Drawing.Point(120, 307);
            this.ButInserirLi.Name = "ButInserirLi";
            this.ButInserirLi.Size = new System.Drawing.Size(71, 32);
            this.ButInserirLi.TabIndex = 6;
            this.ButInserirLi.Text = "&Inserir";
            this.ButInserirLi.UseVisualStyleBackColor = true;
            this.ButInserirLi.Click += new System.EventHandler(this.ButInserirLi_Click);
            // 
            // ButEditarLi
            // 
            this.ButEditarLi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButEditarLi.Location = new System.Drawing.Point(204, 307);
            this.ButEditarLi.Name = "ButEditarLi";
            this.ButEditarLi.Size = new System.Drawing.Size(71, 32);
            this.ButEditarLi.TabIndex = 7;
            this.ButEditarLi.Text = "&Editar";
            this.ButEditarLi.UseVisualStyleBackColor = true;
            this.ButEditarLi.Click += new System.EventHandler(this.ButEditarLi_Click);
            // 
            // ButRemoverLi
            // 
            this.ButRemoverLi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButRemoverLi.Location = new System.Drawing.Point(288, 307);
            this.ButRemoverLi.Name = "ButRemoverLi";
            this.ButRemoverLi.Size = new System.Drawing.Size(83, 32);
            this.ButRemoverLi.TabIndex = 8;
            this.ButRemoverLi.Text = "&Remover";
            this.ButRemoverLi.UseVisualStyleBackColor = true;
            this.ButRemoverLi.Click += new System.EventHandler(this.ButRemoverLi_Click);
            // 
            // ButCancelarLi
            // 
            this.ButCancelarLi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButCancelarLi.Location = new System.Drawing.Point(384, 307);
            this.ButCancelarLi.Name = "ButCancelarLi";
            this.ButCancelarLi.Size = new System.Drawing.Size(83, 32);
            this.ButCancelarLi.TabIndex = 9;
            this.ButCancelarLi.Text = "&Cancelar";
            this.ButCancelarLi.UseVisualStyleBackColor = true;
            this.ButCancelarLi.Click += new System.EventHandler(this.ButCancelarLi_Click);
            // 
            // ButGravarLi
            // 
            this.ButGravarLi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButGravarLi.Location = new System.Drawing.Point(480, 307);
            this.ButGravarLi.Name = "ButGravarLi";
            this.ButGravarLi.Size = new System.Drawing.Size(71, 32);
            this.ButGravarLi.TabIndex = 10;
            this.ButGravarLi.Text = "&Gravar";
            this.ButGravarLi.UseVisualStyleBackColor = true;
            this.ButGravarLi.Click += new System.EventHandler(this.ButGravarLi_Click);
            // 
            // ButVoltarLi
            // 
            this.ButVoltarLi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButVoltarLi.Location = new System.Drawing.Point(689, 307);
            this.ButVoltarLi.Name = "ButVoltarLi";
            this.ButVoltarLi.Size = new System.Drawing.Size(71, 32);
            this.ButVoltarLi.TabIndex = 11;
            this.ButVoltarLi.Text = "&Voltar";
            this.ButVoltarLi.UseVisualStyleBackColor = true;
            this.ButVoltarLi.Click += new System.EventHandler(this.ButVoltarLi_Click);
            // 
            // DtGridLivro
            // 
            this.DtGridLivro.AllowUserToAddRows = false;
            this.DtGridLivro.AllowUserToDeleteRows = false;
            this.DtGridLivro.AutoGenerateColumns = false;
            this.DtGridLivro.BackgroundColor = System.Drawing.Color.White;
            this.DtGridLivro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtGridLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGridLivro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.tITULODataGridViewTextBoxColumn,
            this.eDITORADataGridViewTextBoxColumn,
            this.aUTORDataGridViewTextBoxColumn,
            this.vALORDataGridViewTextBoxColumn,
            this.sITUACAODataGridViewTextBoxColumn});
            this.DtGridLivro.DataSource = this.lIVROSBindingSource;
            this.DtGridLivro.Location = new System.Drawing.Point(43, 369);
            this.DtGridLivro.Name = "DtGridLivro";
            this.DtGridLivro.ReadOnly = true;
            this.DtGridLivro.RowHeadersWidth = 51;
            this.DtGridLivro.Size = new System.Drawing.Size(801, 104);
            this.DtGridLivro.TabIndex = 12;
            this.DtGridLivro.DoubleClick += new System.EventHandler(this.DtGridLivro_DoubleClick);
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
            // tITULODataGridViewTextBoxColumn
            // 
            this.tITULODataGridViewTextBoxColumn.DataPropertyName = "TITULO";
            this.tITULODataGridViewTextBoxColumn.HeaderText = "TITULO";
            this.tITULODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tITULODataGridViewTextBoxColumn.Name = "tITULODataGridViewTextBoxColumn";
            this.tITULODataGridViewTextBoxColumn.ReadOnly = true;
            this.tITULODataGridViewTextBoxColumn.Width = 125;
            // 
            // eDITORADataGridViewTextBoxColumn
            // 
            this.eDITORADataGridViewTextBoxColumn.DataPropertyName = "EDITORA";
            this.eDITORADataGridViewTextBoxColumn.HeaderText = "EDITORA";
            this.eDITORADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eDITORADataGridViewTextBoxColumn.Name = "eDITORADataGridViewTextBoxColumn";
            this.eDITORADataGridViewTextBoxColumn.ReadOnly = true;
            this.eDITORADataGridViewTextBoxColumn.Width = 125;
            // 
            // aUTORDataGridViewTextBoxColumn
            // 
            this.aUTORDataGridViewTextBoxColumn.DataPropertyName = "AUTOR";
            this.aUTORDataGridViewTextBoxColumn.HeaderText = "AUTOR";
            this.aUTORDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aUTORDataGridViewTextBoxColumn.Name = "aUTORDataGridViewTextBoxColumn";
            this.aUTORDataGridViewTextBoxColumn.ReadOnly = true;
            this.aUTORDataGridViewTextBoxColumn.Width = 125;
            // 
            // vALORDataGridViewTextBoxColumn
            // 
            this.vALORDataGridViewTextBoxColumn.DataPropertyName = "VALOR";
            this.vALORDataGridViewTextBoxColumn.HeaderText = "VALOR";
            this.vALORDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vALORDataGridViewTextBoxColumn.Name = "vALORDataGridViewTextBoxColumn";
            this.vALORDataGridViewTextBoxColumn.ReadOnly = true;
            this.vALORDataGridViewTextBoxColumn.Width = 125;
            // 
            // sITUACAODataGridViewTextBoxColumn
            // 
            this.sITUACAODataGridViewTextBoxColumn.DataPropertyName = "SITUACAO";
            this.sITUACAODataGridViewTextBoxColumn.HeaderText = "SITUACAO";
            this.sITUACAODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sITUACAODataGridViewTextBoxColumn.Name = "sITUACAODataGridViewTextBoxColumn";
            this.sITUACAODataGridViewTextBoxColumn.ReadOnly = true;
            this.sITUACAODataGridViewTextBoxColumn.Width = 125;
            // 
            // lIVROSBindingSource
            // 
            this.lIVROSBindingSource.DataMember = "LIVROS";
            this.lIVROSBindingSource.DataSource = this.bIBLIOTECA2020DataSet2;
            // 
            // bIBLIOTECA2020DataSet2
            // 
            this.bIBLIOTECA2020DataSet2.DataSetName = "BIBLIOTECA2020DataSet2";
            this.bIBLIOTECA2020DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lIVROSTableAdapter
            // 
            this.lIVROSTableAdapter.ClearBeforeFill = true;
            // 
            // ButPesLi
            // 
            this.ButPesLi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButPesLi.Location = new System.Drawing.Point(570, 307);
            this.ButPesLi.Name = "ButPesLi";
            this.ButPesLi.Size = new System.Drawing.Size(96, 32);
            this.ButPesLi.TabIndex = 21;
            this.ButPesLi.Text = "&Pesquisar";
            this.ButPesLi.UseVisualStyleBackColor = true;
            this.ButPesLi.Click += new System.EventHandler(this.ButPesLi_Click);
            // 
            // GpbPesquisa
            // 
            this.GpbPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.GpbPesquisa.Controls.Add(this.ButFiltrarLi);
            this.GpbPesquisa.Controls.Add(this.LblFiltroLi);
            this.GpbPesquisa.Controls.Add(this.LblFiltrarLi);
            this.GpbPesquisa.Controls.Add(this.RdbTiLi);
            this.GpbPesquisa.Controls.Add(this.RdbIDLi);
            this.GpbPesquisa.Controls.Add(this.RdbTodosLi);
            this.GpbPesquisa.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbPesquisa.Location = new System.Drawing.Point(517, 42);
            this.GpbPesquisa.Name = "GpbPesquisa";
            this.GpbPesquisa.Size = new System.Drawing.Size(436, 242);
            this.GpbPesquisa.TabIndex = 22;
            this.GpbPesquisa.TabStop = false;
            this.GpbPesquisa.Text = "Filtrar Dados";
            this.GpbPesquisa.Visible = false;
            // 
            // ButFiltrarLi
            // 
            this.ButFiltrarLi.Image = ((System.Drawing.Image)(resources.GetObject("ButFiltrarLi.Image")));
            this.ButFiltrarLi.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ButFiltrarLi.Location = new System.Drawing.Point(334, 198);
            this.ButFiltrarLi.Name = "ButFiltrarLi";
            this.ButFiltrarLi.Size = new System.Drawing.Size(94, 33);
            this.ButFiltrarLi.TabIndex = 5;
            this.ButFiltrarLi.Text = "Filtrar";
            this.ButFiltrarLi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButFiltrarLi.UseVisualStyleBackColor = true;
            this.ButFiltrarLi.Click += new System.EventHandler(this.ButFiltrarLi_Click);
            // 
            // LblFiltroLi
            // 
            this.LblFiltroLi.Location = new System.Drawing.Point(15, 197);
            this.LblFiltroLi.Name = "LblFiltroLi";
            this.LblFiltroLi.Size = new System.Drawing.Size(299, 38);
            this.LblFiltroLi.TabIndex = 4;
            // 
            // LblFiltrarLi
            // 
            this.LblFiltrarLi.Location = new System.Drawing.Point(18, 160);
            this.LblFiltrarLi.Name = "LblFiltrarLi";
            this.LblFiltrarLi.Size = new System.Drawing.Size(257, 33);
            this.LblFiltrarLi.TabIndex = 3;
            // 
            // RdbTiLi
            // 
            this.RdbTiLi.AutoSize = true;
            this.RdbTiLi.Location = new System.Drawing.Point(15, 112);
            this.RdbTiLi.Name = "RdbTiLi";
            this.RdbTiLi.Size = new System.Drawing.Size(89, 29);
            this.RdbTiLi.TabIndex = 2;
            this.RdbTiLi.Text = "Título";
            this.RdbTiLi.UseVisualStyleBackColor = true;
            this.RdbTiLi.CheckedChanged += new System.EventHandler(this.RdbTiLi_CheckedChanged);
            // 
            // RdbIDLi
            // 
            this.RdbIDLi.AutoSize = true;
            this.RdbIDLi.Location = new System.Drawing.Point(15, 68);
            this.RdbIDLi.Name = "RdbIDLi";
            this.RdbIDLi.Size = new System.Drawing.Size(51, 29);
            this.RdbIDLi.TabIndex = 1;
            this.RdbIDLi.Text = "ID";
            this.RdbIDLi.UseVisualStyleBackColor = true;
            this.RdbIDLi.CheckedChanged += new System.EventHandler(this.RdbIDLi_CheckedChanged);
            // 
            // RdbTodosLi
            // 
            this.RdbTodosLi.AutoSize = true;
            this.RdbTodosLi.Checked = true;
            this.RdbTodosLi.Location = new System.Drawing.Point(15, 28);
            this.RdbTodosLi.Name = "RdbTodosLi";
            this.RdbTodosLi.Size = new System.Drawing.Size(85, 29);
            this.RdbTodosLi.TabIndex = 0;
            this.RdbTodosLi.TabStop = true;
            this.RdbTodosLi.Text = "Todos";
            this.RdbTodosLi.UseVisualStyleBackColor = true;
            this.RdbTodosLi.CheckedChanged += new System.EventHandler(this.RdbTodosLi_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label7.Font = new System.Drawing.Font("Ravie", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 48);
            this.label7.TabIndex = 23;
            this.label7.Text = "Livros";
            // 
            // Form_Livros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 488);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GpbPesquisa);
            this.Controls.Add(this.ButPesLi);
            this.Controls.Add(this.DtGridLivro);
            this.Controls.Add(this.ButVoltarLi);
            this.Controls.Add(this.ButGravarLi);
            this.Controls.Add(this.ButCancelarLi);
            this.Controls.Add(this.ButRemoverLi);
            this.Controls.Add(this.ButEditarLi);
            this.Controls.Add(this.ButInserirLi);
            this.Controls.Add(this.LbltituLi);
            this.Controls.Add(this.LblEdiLi);
            this.Controls.Add(this.LblAutorLi);
            this.Controls.Add(this.LblValorLi);
            this.Controls.Add(this.LblSitLi);
            this.Controls.Add(this.LblIDLi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Livros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Livros";
            this.Load += new System.EventHandler(this.Form_Livros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtGridLivro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIVROSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECA2020DataSet2)).EndInit();
            this.GpbPesquisa.ResumeLayout(false);
            this.GpbPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblIDLi;
        private System.Windows.Forms.TextBox LblSitLi;
        private System.Windows.Forms.TextBox LblValorLi;
        private System.Windows.Forms.TextBox LblAutorLi;
        private System.Windows.Forms.TextBox LblEdiLi;
        private System.Windows.Forms.TextBox LbltituLi;
        private System.Windows.Forms.Button ButInserirLi;
        private System.Windows.Forms.Button ButEditarLi;
        private System.Windows.Forms.Button ButRemoverLi;
        private System.Windows.Forms.Button ButCancelarLi;
        private System.Windows.Forms.Button ButGravarLi;
        private System.Windows.Forms.Button ButVoltarLi;
        private System.Windows.Forms.DataGridView DtGridLivro;
        private BIBLIOTECA2020DataSet2 bIBLIOTECA2020DataSet2;
        private System.Windows.Forms.BindingSource lIVROSBindingSource;
        private BIBLIOTECA2020DataSet2TableAdapters.LIVROSTableAdapter lIVROSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tITULODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDITORADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUTORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sITUACAODataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ButPesLi;
        private System.Windows.Forms.Button ButFiltrarLi;
        private System.Windows.Forms.TextBox LblFiltroLi;
        private System.Windows.Forms.Label LblFiltrarLi;
        private System.Windows.Forms.RadioButton RdbTiLi;
        private System.Windows.Forms.RadioButton RdbIDLi;
        private System.Windows.Forms.RadioButton RdbTodosLi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox GpbPesquisa;
    }
}