using BIBLIOTECA.CAMADAS.DAL;
using BIBLIOTECA.CAMADAS.Relatório;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIBLIOTECA
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
            CustDesing();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();
        }
        private void CustDesing()
        {
            panelsubmenu1.Visible = false;
            PainelSubmenu2.Visible = false;
        }
        private void EsconderSubmenu()
        {
            if (panelsubmenu1.Visible == true)
            {
                PainelSubmenu2.Visible = false;
            }
            if (PainelSubmenu2.Visible == true)
            {
                panelsubmenu1.Visible = false;
            }

        }
        void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                EsconderSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void Cadastro_Click(object sender, EventArgs e)
        {
            showSubMenu(panelsubmenu1);
        }

        private void ButRelatorio_Click(object sender, EventArgs e)
        {
            showSubMenu(PainelSubmenu2);
        }

        private void ButClienteCad_Click(object sender, EventArgs e)
        {
            //codigo pra abrir o form
            AbrirFormFilho(new Form_Clientes());
            EsconderSubmenu();
        }

        private void ButLivrosCad_Click(object sender, EventArgs e)
        {
            //codigo pra abrir o form
            AbrirFormFilho(new Form_Livros());
            EsconderSubmenu();
        }

        private void ButRevistaCad_Click(object sender, EventArgs e)
        {
            //codigo pra abrir o form
            AbrirFormFilho(new Form_Revista());
            EsconderSubmenu();
        }

        private void ButCliRel_Click(object sender, EventArgs e)
        {
            Relatorios_Cliente.RelProduto();
            EsconderSubmenu();
        }

        private void ButLivrosRel_Click(object sender, EventArgs e)
        {
            Relatório_Livros.RelProdutoLivros();
            EsconderSubmenu();
        }

        private void ButRevistaRel_Click(object sender, EventArgs e)
        {
            Relatorio_Revista.RelProdutoRevistas();
            EsconderSubmenu();
        }
        private Form activeForm = null;
        private void AbrirFormFilho(Form FormFilho)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = FormFilho;
            FormFilho.TopLevel = false;
            FormFilho.FormBorderStyle = FormBorderStyle.None;
            FormFilho.Dock = DockStyle.Fill;
            panel4.Controls.Add(FormFilho);
            //PainelSubmenu2.Controls.Add(FormFilho);
            panel4.Tag = FormFilho;
            //PainelSubmenu2.Tag = FormFilho;
            FormFilho.BringToFront();
            FormFilho.Show();

        }

        private void ButMov_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(new Form_Emprestimo());
            EsconderSubmenu();
        }

        private void ButSobre_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(new Form_Sobre());
            EsconderSubmenu();
        }
    }
}
