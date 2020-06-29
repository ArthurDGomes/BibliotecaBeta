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
    public partial class Form_Clientes : Form
    {
        public Form_Clientes()
        {
            InitializeComponent();
        }

        //Mostrar os dados do banco
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bIBLIOTECA2020DataSet1.CLIENTES'. Você pode movê-la ou removê-la conforme necessário.
            //this.cLIENTESTableAdapter1.Fill(this.bIBLIOTECA2020DataSet1.CLIENTES);
            CAMADAS.DAL.Clientes dalCli = new CAMADAS.DAL.Clientes();
            dataGridView1.DataSource = dalCli.Select();
        }
        // Inserir cliente
        private void butINSERIR_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Clientes cliente = new CAMADAS.MODEL.Clientes();
            cliente.NOME = textBoxNOME.Text;
            cliente.CURSO = textBoxCURSO.Text; ;
            cliente.DIAS = Convert.ToInt32(textBoxDIAS.Text);
            cliente.MULTA = Convert.ToSingle(textBoxMULTA.Text);

            CAMADAS.DAL.Clientes dalCli = new CAMADAS.DAL.Clientes();
            dalCli.Inserir(cliente);

            dataGridView1.DataSource = "";
            dataGridView1.DataSource = dalCli.Select();

        }
        //Sair
        private void butSAIR_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        // Deletar cliente
        private void butREMOVER_Click(object sender, EventArgs e)
        {
            int IDCli = Convert.ToInt32(textBoxID.Text);
            CAMADAS.DAL.Clientes dalCli = new CAMADAS.DAL.Clientes();
            dalCli.Delete(IDCli);

            dataGridView1.DataSource = "";
            dataGridView1.DataSource = dalCli.Select();
        }
        //Editar cliente
        private void butEDITAR_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Clientes cliente = new CAMADAS.MODEL.Clientes();
            cliente.ID = Convert.ToInt32(textBoxID.Text);
            cliente.NOME = textBoxNOME.Text;
            cliente.CURSO = textBoxCURSO.Text; ;
            cliente.DIAS = Convert.ToInt32(textBoxDIAS.Text);
            cliente.MULTA = Convert.ToSingle(textBoxMULTA.Text);

            CAMADAS.DAL.Clientes dalCli = new CAMADAS.DAL.Clientes();
            dalCli.UPDATE(cliente);

            dataGridView1.DataSource = "";
            dataGridView1.DataSource = dalCli.Select();
        }

        private void ButFiltrarLi_Click(object sender, EventArgs e)
        {
            CAMADAS.DAL.Clientes Dalcli = new CAMADAS.DAL.Clientes();
            List<CAMADAS.MODEL.Clientes> Lstcli = new List<CAMADAS.MODEL.Clientes>();
            if (RbTodosCli.Checked)
            {
                Lstcli = Dalcli.Select();
            }
            if (RbNomeCli.Checked)
            {
                Lstcli = Dalcli.SelectNome(txtBoxfiltro.Text);

            }
            if (RbNomeCli.Checked && txtBoxfiltro.Text == "")
            {
                MessageBox.Show("Não foi informado dados para filtrar", "Filtrar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
             if (RbIDCli.Checked)
            {
                int ID = Convert.ToInt32(txtBoxfiltro.Text);
                Lstcli = Dalcli.SelectbyID(ID);
            }
             if (RbIDCli.Checked && txtBoxfiltro.Text == "")
            {
                MessageBox.Show("Não foi informado dados para filtrar", "Filtrar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = Lstcli;
        }

        private void ButPesqCli_Click(object sender, EventArgs e)
        {
            GbPesquisaCli.Visible = !GbPesquisaCli.Visible;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textBoxID.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            textBoxNOME.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            textBoxCURSO.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            textBoxDIAS.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
            textBoxMULTA.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
        }

        private void RbIDCli_CheckedChanged(object sender, EventArgs e)
        {
            labelCli.Text = "Informe o ID: ";
            txtBoxfiltro.Text = "";
            labelCli.Visible = true;
            txtBoxfiltro.Visible = true;
            txtBoxfiltro.Focus();
        }

        private void RbNomeCli_CheckedChanged(object sender, EventArgs e)
        {
            labelCli.Text = "Informe o Nome: ";
            txtBoxfiltro.Text = "";
            labelCli.Visible = true;
            txtBoxfiltro.Visible = true;
            txtBoxfiltro.Focus();
        }

        private void RbTodosCli_CheckedChanged(object sender, EventArgs e)
        {
            labelCli.Visible = false;
            txtBoxfiltro.Visible = false;
        }
    }
}
