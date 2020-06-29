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
    public partial class Form_Revista : Form
    {
        public Form_Revista()
        {
            InitializeComponent();
        }

        private void Form_Revista_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bIBLIOTECA2020DataSet3.REVISTA'. Você pode movê-la ou removê-la conforme necessário.
            this.rEVISTATableAdapter.Fill(this.bIBLIOTECA2020DataSet3.REVISTA);
            CAMADAS.DAL.Revista dalrevista = new CAMADAS.DAL.Revista();
            dgvRevista.DataSource = dalrevista.Select();
        }
        private void butINSERIR_Click_1(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Revista revista = new CAMADAS.MODEL.Revista();
            revista.TITULO = textBoxtitulo.Text;
            revista.EDITORA = textBoxEditora.Text;
            revista.VALOR = Convert.ToSingle(textBoxValor.Text);
            revista.SITUACAO = Convert.ToInt32(textBoxSituacao.Text);

            CAMADAS.DAL.Revista dalrevista = new CAMADAS.DAL.Revista();
            dalrevista.Inserir(revista);

            dgvRevista.DataSource = "";
            dgvRevista.DataSource = dalrevista.Select();

            if(textBoxtitulo == null && textBoxEditora == null && textBoxValor == null && textBoxSituacao == null)
                MessageBox.Show("Informe todos os campos", "Inserir", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void butSAIR_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void butREMOVER_Click(object sender, EventArgs e)
        {
            int IDRevista = Convert.ToInt32(textBoxID.Text);
            CAMADAS.DAL.Revista dallrevista = new CAMADAS.DAL.Revista();
            dallrevista.Delete(IDRevista);

            dgvRevista.DataSource = "";
            dgvRevista.DataSource = dallrevista.Select();
        }

        private void butEDITAR_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Revista revista = new CAMADAS.MODEL.Revista();
            revista.ID = Convert.ToInt32(textBoxID.Text);
            revista.TITULO = textBoxtitulo.Text;
            revista.EDITORA = textBoxEditora.Text;
            revista.VALOR = Convert.ToSingle(textBoxValor.Text);
            revista.SITUACAO = Convert.ToInt32(textBoxSituacao.Text);

            CAMADAS.DAL.Revista dalrevista = new CAMADAS.DAL.Revista();
            dalrevista.UPDATE(revista);

            dgvRevista.DataSource = "";
            dgvRevista.DataSource = dalrevista.Select();
        }

        private void dgvRevista_DoubleClick(object sender, EventArgs e)
        {
            textBoxID.Text = Convert.ToString(dgvRevista.SelectedRows[0].Cells[0].Value.ToString());
            textBoxtitulo.Text = Convert.ToString(dgvRevista.SelectedRows[0].Cells[1].Value.ToString());
            textBoxEditora.Text = Convert.ToString(dgvRevista.SelectedRows[0].Cells[2].Value.ToString());
            textBoxValor.Text = Convert.ToString(dgvRevista.SelectedRows[0].Cells[3].Value.ToString());
            textBoxSituacao.Text = Convert.ToString(dgvRevista.SelectedRows[0].Cells[4].Value.ToString());
        }

        private void ButFiltrarRe_Click(object sender, EventArgs e)
        {
            CAMADAS.DAL.Revista Dalrevista = new CAMADAS.DAL.Revista();
            List<CAMADAS.MODEL.Revista> LstRevista = new List<CAMADAS.MODEL.Revista>();
            if (RbTodosRe.Checked)
            {
                LstRevista = Dalrevista.Select();
            }
            if (RbtituloRe.Checked)
            {
                LstRevista = Dalrevista.SelectTitulo(txtBoxfiltro.Text);
            }
            if(RbtituloRe.Checked && txtBoxfiltro ==null)
            {
                MessageBox.Show("Não foi informado dados para filtrar", "Filtrar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            if(RbIDRe.Checked)
            {
                int ID = Convert.ToInt32(txtBoxfiltro.Text);
                LstRevista = Dalrevista.SelectID(ID);
            }
            if(RbIDRe.Checked && txtBoxfiltro == null)
            {
                MessageBox.Show("Não foi informado dados para filtrar", "Filtrar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            dgvRevista.DataSource = "";
            dgvRevista.DataSource = LstRevista;
        }

        private void ButPesqCli_Click(object sender, EventArgs e)
        {
            GbPesquisaRe.Visible = !GbPesquisaRe.Visible;
        }

        private void RbTodosRe_CheckedChanged(object sender, EventArgs e)
        {
            labelrevista.Visible = false;
            txtBoxfiltro.Visible = false;
        }

        private void RbIDRe_CheckedChanged(object sender, EventArgs e)
        {
            labelrevista.Text = "Informe o ID:";
            txtBoxfiltro.Text = "";
            labelrevista.Visible = true;
            txtBoxfiltro.Visible = true;
            txtBoxfiltro.Focus();
        }

        private void RbtituloRe_CheckedChanged(object sender, EventArgs e)
        {
            labelrevista.Text = "Informe o Título:";
            txtBoxfiltro.Text = "";
            labelrevista.Visible = true;
            txtBoxfiltro.Visible = true;
            txtBoxfiltro.Focus();
        }
    }
}
