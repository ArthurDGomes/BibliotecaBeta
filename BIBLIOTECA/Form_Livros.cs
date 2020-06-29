using BIBLIOTECA.CAMADAS.BLL;
using BIBLIOTECA.CAMADAS.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIBLIOTECA
{
    public partial class Form_Livros : Form
    {

        public Form_Livros()
        {
            InitializeComponent();
        }

        private void ButVoltarLi_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void HabilitaControl(bool status)
        {
            LbltituLi.Enabled = status;
            LblEdiLi.Enabled = status;
            LblAutorLi.Enabled = status;
            LblValorLi.Enabled = status;
            LblSitLi.Enabled = status;
        }

        private void HabilitaBut(bool status)
        {
            ButInserirLi.Enabled = status;
            ButEditarLi.Enabled = status;
            ButRemoverLi.Enabled = status;
            ButCancelarLi.Enabled = !status;
            ButGravarLi.Enabled = !status;
        }

        private void LimparControles()
        {
            LblIDLi.Text = "-1";
            LbltituLi.Text = "";
            LblEdiLi.Text = "";
            LblAutorLi.Text = "";
            LblValorLi.Text = "";
            LblSitLi.Text = "";
        }

        private void Form_Livros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bIBLIOTECA2020DataSet2.LIVROS'. Você pode movê-la ou removê-la conforme necessário.
            this.lIVROSTableAdapter.Fill(this.bIBLIOTECA2020DataSet2.LIVROS);
            CAMADAS.DAL.Livros BllLivros = new CAMADAS.DAL.Livros();
            DtGridLivro.DataSource = "";
            DtGridLivro.DataSource = BllLivros.Select();
            HabilitaControl(false);
            HabilitaBut(true);
            LimparControles();
        }

        private void ButInserirLi_Click(object sender, EventArgs e)
        {
            LimparControles();
            HabilitaControl(true);
            HabilitaBut(false);
            LbltituLi.Focus();
        }

        private void ButEditarLi_Click(object sender, EventArgs e)
        {
            HabilitaControl(true);
            HabilitaBut(false);
            LbltituLi.Focus();

        }

        private void ButCancelarLi_Click(object sender, EventArgs e)
        {
            LimparControles();
            HabilitaControl(false);
            HabilitaBut(true);
        }

        private void ButGravarLi_Click(object sender, EventArgs e)
        {
            CAMADAS.DAL.Livros BllLivros = new CAMADAS.DAL.Livros();
            string msg = "";
            if (LblIDLi.Text == "-1")
                msg = "Deseja Inserir um Novo Livro?";
            else msg = "Deseja Alterar o Livro atual?";
            DialogResult resposta = MessageBox.Show(msg, "Gravar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resposta == DialogResult.Yes)
            {
                CAMADAS.MODEL.Livros livros = new CAMADAS.MODEL.Livros();
                livros.ID = Convert.ToInt32(LblIDLi.Text);
                livros.TITULO = LbltituLi.Text.Trim();
                livros.EDITORA = LblEdiLi.Text.Trim();
                livros.AUTOR = LblAutorLi.Text;
                livros.VALOR = Convert.ToSingle(LblValorLi.Text);
                livros.SITUACAO = Convert.ToInt32(LblSitLi.Text);
                if (LblIDLi.Text == "-1")
                {
                    BllLivros.Inserir(livros);
                }
                else BllLivros.UPDATE(livros);
            }

            DtGridLivro.DataSource = "";
            DtGridLivro.DataSource = BllLivros.Select();


            HabilitaControl(false);
            HabilitaBut(true);
            LimparControles();
        }

        private void ButRemoverLi_Click(object sender, EventArgs e)
        {
            CAMADAS.DAL.Livros bllLivro = new CAMADAS.DAL.Livros();

            if (LblIDLi.Text != "-1")
            {
                string msg = "Deseja Remover o atual livro?";
                DialogResult resp = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    int idLivro = Convert.ToInt32(LblIDLi.Text);
                    bllLivro.Delete(idLivro);
                }
            }
            else MessageBox.Show("Não há dados para Remover", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            DtGridLivro.DataSource = "";
            DtGridLivro.DataSource = bllLivro.Select();
            LimparControles();
        }

        private void DtGridLivro_DoubleClick(object sender, EventArgs e)
        {
            LblIDLi.Text = Convert.ToString(DtGridLivro.SelectedRows[0].Cells[0].Value.ToString());
            LbltituLi.Text = Convert.ToString(DtGridLivro.SelectedRows[0].Cells[1].Value.ToString());
            LblEdiLi.Text = Convert.ToString(DtGridLivro.SelectedRows[0].Cells[2].Value.ToString());
            LblAutorLi.Text = Convert.ToString(DtGridLivro.SelectedRows[0].Cells[3].Value.ToString());
            LblValorLi.Text = Convert.ToString(DtGridLivro.SelectedRows[0].Cells[4].Value.ToString());
            LblSitLi.Text = Convert.ToString(DtGridLivro.SelectedRows[0].Cells[5].Value.ToString());

        }

        private void ButPesLi_Click(object sender, EventArgs e)
        {
            GpbPesquisa.Visible = !GpbPesquisa.Visible;
        }

        private void RdbIDLi_CheckedChanged(object sender, EventArgs e)
        {
            LblFiltrarLi.Text = "Informe o ID: ";
            LblFiltroLi.Text = "";
            LblFiltrarLi.Visible = true;
            LblFiltroLi.Visible = true ;
            LblFiltroLi.Focus();
        }

        private void RdbTiLi_CheckedChanged(object sender, EventArgs e)
        {
            LblFiltrarLi.Text = "Informe o Título: ";
            LblFiltroLi.Text = "";
            LblFiltrarLi.Visible = true;
            LblFiltroLi.Visible = true;
            LblFiltroLi.Focus();
        }

        private void RdbTodosLi_CheckedChanged(object sender, EventArgs e)
        {
            LblFiltrarLi.Visible = false;
            LblFiltroLi.Visible = false;
        }

        private void ButFiltrarLi_Click(object sender, EventArgs e)
        {
            CAMADAS.DAL.Livros bllLivros = new CAMADAS.DAL.Livros();
            List<CAMADAS.MODEL.Livros> lstLivros = new List<CAMADAS.MODEL.Livros>();
            if (RdbTodosLi.Checked)
                lstLivros = bllLivros.Select();
            else if (RdbTiLi.Checked)
            {
                lstLivros = bllLivros.SelectTitulo(LblFiltrarLi.Text);

            }
            if (RdbTiLi.Checked && LblFiltroLi.Text == "")
            {
                MessageBox.Show("Não foi informado dados para filtrar", "Filtrar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (RdbIDLi.Checked)
            {
                int ID = Convert.ToInt32(LblFiltroLi.Text);
                lstLivros = bllLivros.SelectID(ID);
            }
            else if (RdbIDLi.Checked && LblFiltroLi.Text == "")
            {
                MessageBox.Show("Não foi informado dados para filtrar", "Filtrar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            DtGridLivro.DataSource = "";
            DtGridLivro.DataSource = lstLivros;
        }
    }
}
