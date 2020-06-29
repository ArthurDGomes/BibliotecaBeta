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
    public partial class Form_Emprestimo : Form
    {
        public Form_Emprestimo()
        {
            InitializeComponent();
        }

        private void ButSairEmp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Emprestimo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bIBLIOTECA2020DataSet4.EMPRESTIMO'. Você pode movê-la ou removê-la conforme necessário.
            this.eMPRESTIMOTableAdapter.Fill(this.bIBLIOTECA2020DataSet4.EMPRESTIMO);
            CAMADAS.BLL.Emprestimo bllemp = new CAMADAS.BLL.Emprestimo();
            DgvEmprestimo.DataSource = bllemp.Select();

            CAMADAS.DAL.Clientes Dalcli = new CAMADAS.DAL.Clientes();
            CbNomeEmp.DisplayMember = "NOME";
            CbNomeEmp.ValueMember = "ID";
            CbNomeEmp.DataSource = Dalcli.Select();

            CAMADAS.BLL.Livros BllLivro = new CAMADAS.BLL.Livros();
            CbnTituloLivro.DisplayMember = "TITULO";
            CbnTituloLivro.ValueMember = "ID";
            CbnTituloLivro.DataSource = BllLivro.Select();
        }
        private void LimparEmprestimo()
        {
            lblIDEmp.Text = "-1";
            DtpEmp.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        }

        private void LimparItem()
        {
            LblIDLivro.Text = "-1";
            DtpLivro.Value = Convert.ToDateTime("1/1/1990");
        }

        private void CbNomeEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxEmp.Text = CbNomeEmp.SelectedValue.ToString();
        }

        private void textBoxEmp_Leave(object sender, EventArgs e)
        {
            try
            {
                CbNomeEmp.SelectedValue = Convert.ToInt32(textBoxEmp.Text);
            }
            catch 
            {
                MessageBox.Show("Cliente inválido");
                CbNomeEmp.Focus();
            }

        }

        private void ButNonoEmp_Click(object sender, EventArgs e)
        {
            LimparEmprestimo();
            CbNomeEmp.Focus();
        }

        private void ButGravarEmp_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Emprestimo emprestimo = new CAMADAS.MODEL.Emprestimo();
            emprestimo.ID = Convert.ToInt32(lblIDEmp.Text);
            emprestimo.CLIENTE_ID = Convert.ToInt32(CbNomeEmp.SelectedValue.ToString());
            emprestimo.DATA = DtpEmp.Value;

            CAMADAS.BLL.Emprestimo bllemprestimo = new CAMADAS.BLL.Emprestimo();

            if (lblIDEmp.Text == "-1")
                bllemprestimo.Insert(emprestimo);
            else bllemprestimo.Update(emprestimo);

            List<CAMADAS.MODEL.Emprestimo> LstEmprestimo = bllemprestimo.Select();

            DgvEmprestimo.DataSource = "";
            DgvEmprestimo.DataSource = LstEmprestimo;
        }

        private void DgvEmprestimo_DoubleClick(object sender, EventArgs e)
        {
            lblIDEmp.Text = DgvEmprestimo.SelectedRows[0].Cells[0].Value.ToString();
            CbNomeEmp.Text = DgvEmprestimo.SelectedRows[0].Cells[2].Value.ToString();
            DtpEmp.Value = Convert.ToDateTime(DgvEmprestimo.SelectedRows[0].Cells[3].Value.ToString());
        }

        private void ButNovoLivro_Click(object sender, EventArgs e)
        {
            if (lblIDEmp.Text != "-1" && lblIDEmp.Text != "")
            {
                LimparItem();
                CbnTituloLivro.Focus();
            }
            else MessageBox.Show("Não há emprestimo selecionado");
        }

        private void CbnTituloLivro_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxIdLivro.Text = CbnTituloLivro.SelectedValue.ToString();
        }

        private void VerificarLivro()
        {
            int ID = Convert.ToInt32(textBoxIdLivro.Text);
            CAMADAS.BLL.Livros BllLivro = new CAMADAS.BLL.Livros();
            List<CAMADAS.MODEL.Livros> LstLivros = BllLivro.SelectID(ID);
            if (LstLivros.Count() != 0)
            {
                if(LstLivros[0].SITUACAO != 1)
                {
                    MessageBox.Show("Livro" + LstLivros[0].TITULO.Trim() + " está emprestado");
                    CbnTituloLivro.Focus();
                }
                CbnTituloLivro.SelectedValue = Convert.ToInt32(textBoxIdLivro.Text);
            }
            else
            {
                MessageBox.Show("livro Invalido!!");
                CbnTituloLivro.Focus();
            }
        }

        private void textBoxIdLivro_Leave(object sender, EventArgs e)
        {
            VerificarLivro();
        }

        private void CbnTituloLivro_Leave(object sender, EventArgs e)
        {
            VerificarLivro();
        }

        private void ButGravarLivro_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Itens itens = new CAMADAS.MODEL.Itens();
            CAMADAS.BLL.Itens BllItens = new CAMADAS.BLL.Itens();
            itens.ID = Convert.ToInt32( LblItemID.Text);
            itens.EMPRESTIMO_ID = Convert.ToInt32(lblIDEmp.Text);
            itens.LIVRO_ID = Convert.ToInt32(textBoxIdLivro.Text);
            itens.ENTREGA = Convert.ToDateTime("1/1/1990");

            BllItens.Insert(itens);
            DgvLivros.DataSource = BllItens.Select();
        }
    }
}
