namespace BIBLIOTECA
{
    partial class Form_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
            this.Cadastro = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PainelSubmenu2 = new System.Windows.Forms.Panel();
            this.ButLivrosRel = new System.Windows.Forms.Button();
            this.ButCliRel = new System.Windows.Forms.Button();
            this.ButRevistaRel = new System.Windows.Forms.Button();
            this.panelsubmenu1 = new System.Windows.Forms.Panel();
            this.ButLivrosCad = new System.Windows.Forms.Button();
            this.ButClienteCad = new System.Windows.Forms.Button();
            this.ButRevistaCad = new System.Windows.Forms.Button();
            this.ButSobre = new System.Windows.Forms.Button();
            this.ButMov = new System.Windows.Forms.Button();
            this.ButRelatorio = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.PainelSubmenu2.SuspendLayout();
            this.panelsubmenu1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Cadastro
            // 
            this.Cadastro.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastro.Location = new System.Drawing.Point(0, 136);
            this.Cadastro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(220, 46);
            this.Cadastro.TabIndex = 0;
            this.Cadastro.Text = "Cadastro";
            this.Cadastro.UseVisualStyleBackColor = true;
            this.Cadastro.Click += new System.EventHandler(this.Cadastro_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.PainelSubmenu2);
            this.panel1.Controls.Add(this.panelsubmenu1);
            this.panel1.Controls.Add(this.ButSobre);
            this.panel1.Controls.Add(this.ButMov);
            this.panel1.Controls.Add(this.ButRelatorio);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Cadastro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 614);
            this.panel1.TabIndex = 2;
            // 
            // PainelSubmenu2
            // 
            this.PainelSubmenu2.Controls.Add(this.ButLivrosRel);
            this.PainelSubmenu2.Controls.Add(this.ButCliRel);
            this.PainelSubmenu2.Controls.Add(this.ButRevistaRel);
            this.PainelSubmenu2.Location = new System.Drawing.Point(1, 320);
            this.PainelSubmenu2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PainelSubmenu2.Name = "PainelSubmenu2";
            this.PainelSubmenu2.Size = new System.Drawing.Size(218, 125);
            this.PainelSubmenu2.TabIndex = 11;
            // 
            // ButLivrosRel
            // 
            this.ButLivrosRel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButLivrosRel.Location = new System.Drawing.Point(-2, 42);
            this.ButLivrosRel.Name = "ButLivrosRel";
            this.ButLivrosRel.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.ButLivrosRel.Size = new System.Drawing.Size(219, 46);
            this.ButLivrosRel.TabIndex = 8;
            this.ButLivrosRel.Text = "Livros";
            this.ButLivrosRel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButLivrosRel.UseVisualStyleBackColor = true;
            this.ButLivrosRel.Click += new System.EventHandler(this.ButLivrosRel_Click);
            // 
            // ButCliRel
            // 
            this.ButCliRel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButCliRel.Location = new System.Drawing.Point(-2, 0);
            this.ButCliRel.Name = "ButCliRel";
            this.ButCliRel.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.ButCliRel.Size = new System.Drawing.Size(219, 46);
            this.ButCliRel.TabIndex = 7;
            this.ButCliRel.Text = "Cliente";
            this.ButCliRel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButCliRel.UseVisualStyleBackColor = true;
            this.ButCliRel.Click += new System.EventHandler(this.ButCliRel_Click);
            // 
            // ButRevistaRel
            // 
            this.ButRevistaRel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButRevistaRel.Location = new System.Drawing.Point(-2, 83);
            this.ButRevistaRel.Name = "ButRevistaRel";
            this.ButRevistaRel.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.ButRevistaRel.Size = new System.Drawing.Size(219, 46);
            this.ButRevistaRel.TabIndex = 9;
            this.ButRevistaRel.Text = "Revista";
            this.ButRevistaRel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButRevistaRel.UseVisualStyleBackColor = true;
            this.ButRevistaRel.Click += new System.EventHandler(this.ButRevistaRel_Click);
            // 
            // panelsubmenu1
            // 
            this.panelsubmenu1.Controls.Add(this.ButLivrosCad);
            this.panelsubmenu1.Controls.Add(this.ButClienteCad);
            this.panelsubmenu1.Controls.Add(this.ButRevistaCad);
            this.panelsubmenu1.Location = new System.Drawing.Point(0, 178);
            this.panelsubmenu1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelsubmenu1.Name = "panelsubmenu1";
            this.panelsubmenu1.Size = new System.Drawing.Size(218, 101);
            this.panelsubmenu1.TabIndex = 10;
            // 
            // ButLivrosCad
            // 
            this.ButLivrosCad.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButLivrosCad.Location = new System.Drawing.Point(0, 30);
            this.ButLivrosCad.Name = "ButLivrosCad";
            this.ButLivrosCad.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.ButLivrosCad.Size = new System.Drawing.Size(220, 37);
            this.ButLivrosCad.TabIndex = 5;
            this.ButLivrosCad.Text = "Livros";
            this.ButLivrosCad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButLivrosCad.UseVisualStyleBackColor = true;
            this.ButLivrosCad.Click += new System.EventHandler(this.ButLivrosCad_Click);
            // 
            // ButClienteCad
            // 
            this.ButClienteCad.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButClienteCad.Location = new System.Drawing.Point(0, 0);
            this.ButClienteCad.Name = "ButClienteCad";
            this.ButClienteCad.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.ButClienteCad.Size = new System.Drawing.Size(220, 37);
            this.ButClienteCad.TabIndex = 4;
            this.ButClienteCad.Text = "Cliente";
            this.ButClienteCad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButClienteCad.UseVisualStyleBackColor = true;
            this.ButClienteCad.Click += new System.EventHandler(this.ButClienteCad_Click);
            // 
            // ButRevistaCad
            // 
            this.ButRevistaCad.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButRevistaCad.Location = new System.Drawing.Point(0, 66);
            this.ButRevistaCad.Name = "ButRevistaCad";
            this.ButRevistaCad.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.ButRevistaCad.Size = new System.Drawing.Size(220, 37);
            this.ButRevistaCad.TabIndex = 6;
            this.ButRevistaCad.Text = "Revista";
            this.ButRevistaCad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButRevistaCad.UseVisualStyleBackColor = true;
            this.ButRevistaCad.Click += new System.EventHandler(this.ButRevistaCad_Click);
            // 
            // ButSobre
            // 
            this.ButSobre.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButSobre.ForeColor = System.Drawing.Color.Red;
            this.ButSobre.Location = new System.Drawing.Point(0, 491);
            this.ButSobre.Name = "ButSobre";
            this.ButSobre.Size = new System.Drawing.Size(218, 46);
            this.ButSobre.TabIndex = 3;
            this.ButSobre.Text = "Sobre";
            this.ButSobre.UseVisualStyleBackColor = true;
            this.ButSobre.Click += new System.EventHandler(this.ButSobre_Click);
            // 
            // ButMov
            // 
            this.ButMov.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButMov.Location = new System.Drawing.Point(0, 445);
            this.ButMov.Name = "ButMov";
            this.ButMov.Size = new System.Drawing.Size(218, 46);
            this.ButMov.TabIndex = 2;
            this.ButMov.Text = "Movimentos";
            this.ButMov.UseVisualStyleBackColor = true;
            this.ButMov.Click += new System.EventHandler(this.ButMov_Click);
            // 
            // ButRelatorio
            // 
            this.ButRelatorio.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButRelatorio.Location = new System.Drawing.Point(-1, 279);
            this.ButRelatorio.Name = "ButRelatorio";
            this.ButRelatorio.Size = new System.Drawing.Size(220, 41);
            this.ButRelatorio.TabIndex = 1;
            this.ButRelatorio.Text = "Relatório";
            this.ButRelatorio.UseVisualStyleBackColor = true;
            this.ButRelatorio.Click += new System.EventHandler(this.ButRelatorio_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 141);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.statusStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(220, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(946, 93);
            this.panel3.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 66);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(944, 25);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "Sistema Biblioteca";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(103, 20);
            this.toolStripStatusLabel1.Text = "Sistema Biblioteca";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Margin = new System.Windows.Forms.Padding(10, 3, 10, 2);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 20);
            this.toolStripStatusLabel2.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(224, 95);
            this.panel4.MaximumSize = new System.Drawing.Size(942, 507);
            this.panel4.MinimumSize = new System.Drawing.Size(675, 455);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(942, 507);
            this.panel4.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(942, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 614);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1182, 653);
            this.Name = "Form_Menu";
            this.Text = "Biblioteca";
            this.panel1.ResumeLayout(false);
            this.PainelSubmenu2.ResumeLayout(false);
            this.panelsubmenu1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cadastro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButSobre;
        private System.Windows.Forms.Button ButMov;
        private System.Windows.Forms.Button ButRelatorio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button ButRevistaCad;
        private System.Windows.Forms.Button ButLivrosCad;
        private System.Windows.Forms.Button ButClienteCad;
        private System.Windows.Forms.Button ButLivrosRel;
        private System.Windows.Forms.Button ButRevistaRel;
        private System.Windows.Forms.Button ButCliRel;
        private System.Windows.Forms.Panel PainelSubmenu2;
        private System.Windows.Forms.Panel panelsubmenu1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}