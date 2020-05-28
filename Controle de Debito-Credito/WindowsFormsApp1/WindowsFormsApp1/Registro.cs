using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Registro : Form
    {
        private Caixa caixa;
        private bool alterado;
        public Registro(Caixa caixaPrincipal)
        {
            InitializeComponent();
            caixa = caixaPrincipal;
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            comboNatureza.Items.Add("Crédito");
            comboNatureza.Items.Add("Débito");

            if (txtValor.Text != "" && txtDescriçao.Text != "" && comboNatureza.SelectedIndex == 0 || comboNatureza.SelectedIndex == 1)
            {
                alterado = true;
            }
            else
                alterado = false;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (alterado)
            {
                caixa.Op.cadMovimentaçao.RemoveAt(caixa.dgvDados.CurrentRow.Index);
            }
            caixa.Op.ExecutaOperaçao(new Salvar(), this);         
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult Resp = new DialogResult();
            string TextoMSG = "Deseja Cancelar o registro?";
            string TituloMSG = "Confirmação de saída...";
            MessageBoxButtons BotaoMSG = MessageBoxButtons.YesNo;
            MessageBoxIcon IconeMSG = MessageBoxIcon.Question;
            Resp = MessageBox.Show(TextoMSG, TituloMSG, BotaoMSG, IconeMSG);
            if (Resp == DialogResult.Yes)
                Close();
        }

        private void comboNatureza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txtValor.Focus();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                dtpData.Focus();
        }

        private void dtpData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txtDescriçao.Focus();
        }

        private void txtDescriçao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSalvar.Focus();
                btnSalvar.PerformClick();
            }
        }
    }
}
