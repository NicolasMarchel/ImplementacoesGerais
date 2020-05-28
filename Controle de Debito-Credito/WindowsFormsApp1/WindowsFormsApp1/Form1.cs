using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Caixa : Form
    {
        public Operaçoes Op;

        public Caixa()
        {
            InitializeComponent();
        }

        private void Caixa_Load(object sender, EventArgs e)
        {
            Op = new Operaçoes(this);
            if (Op.cadMovimentaçao != null)
                CarregaGrid();

            comboPesquisa.Items.Add("Data");
            comboPesquisa.Items.Add("Valor");
            comboMes.Items.Add("Janeiro");
            comboMes.Items.Add("Fevereiro");
            comboMes.Items.Add("Março");
            comboMes.Items.Add("Abril");
            comboMes.Items.Add("Maio");
            comboMes.Items.Add("Junho");
            comboMes.Items.Add("Julho");
            comboMes.Items.Add("Agosto");
            comboMes.Items.Add("Setembro");
            comboMes.Items.Add("Outubro");
            comboMes.Items.Add("Novembro");
            comboMes.Items.Add("Dezembro");

            txtPesquisa.Visible = false;
            dtpData.Visible = false;
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Op.ExecutaOperaçao(new Adicionar());
        }


        public void CarregaGrid()
        {
            dgvDados.DataSource = null;
            if (Op.cadMovimentaçao.Count != 0)
            {
                dgvDados.DataSource = Op.cadMovimentaçao;
                dgvDados.ClearSelection();
                dgvDados.Columns[0].Width = 80;
                dgvDados.Columns[1].Width = 80;
                dgvDados.Columns[2].Width = 320;
                dgvDados.Columns[3].Width = 80;

            }
        }
        public void CarregaGrid(ArrayList Temp)
        {
            dgvDados.DataSource = null;
            if (Temp.Count != 0)
            {
                dgvDados.DataSource = Temp;
                dgvDados.ClearSelection();
                dgvDados.Columns[0].Width = 80;
                dgvDados.Columns[1].Width = 80;
                dgvDados.Columns[2].Width = 320;
                dgvDados.Columns[3].Width = 80;

            }
        }
        private void btnSalvarXML_Click(object sender, EventArgs e)
        {
            Op.ExecutaOperaçao(new SalvarXML());
        }

        private void btnCarregarXML_Click(object sender, EventArgs e)
        {
            Op.ExecutaOperaçao(new CarregarXML());
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Op.ExecutaOperaçao(new Excluir());
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Op.ExecutaOperaçao(new Alterar());
        }



        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            Op.ExecutaOperaçao(new Ordenar());
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Op.ExecutaOperaçao(new Pesquisa());
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            Op.ExecutaOperaçao(new GerarRelatorio());
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void checkMes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMes.Checked == true)
                checkPeriodo.Checked = false;
           
        }

        private void checkPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPeriodo.Checked == true)
                checkMes.Checked = false;
        }



        private void btnTotalizarCredito_Click(object sender, EventArgs e)
        {
            Op.ExecutaOperaçao(new TotalizarCredito());
        }

        private void btnTotalizarDebito_Click(object sender, EventArgs e)
        {
            Op.ExecutaOperaçao(new TotalizarDebito());
        }

        private void btnSaldo_Click(object sender, EventArgs e)
        {
            Op.ExecutaOperaçao(new Saldo());
        }



        private void comboPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboPesquisa.SelectedIndex == 0)
            {
                dtpData.Visible = true;
                txtPesquisa.Visible = false;
            }
            else
            if (comboPesquisa.SelectedIndex == 1)
            {
                txtPesquisa.Visible = true;
                dtpData.Visible = false;
                txtPesquisa.Focus();
            }

        }
    }
}
