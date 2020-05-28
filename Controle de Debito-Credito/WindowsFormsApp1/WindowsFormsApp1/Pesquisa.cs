using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Pesquisa : IExecute
    {
        public void ExcutaOpeçao(Caixa caixa, ArrayList Cad,Registro registro)
        {
           
            if (caixa.comboPesquisa.SelectedIndex == 0)
            {
         
                for (int i = 0; i < caixa.dgvDados.RowCount; i++)
                {               
                    if (caixa.dtpData.Value.Date ==((DateTime)caixa.dgvDados.Rows[i].Cells[0].Value).Date) 
                    {
                        caixa.dgvDados.CurrentCell = caixa.dgvDados.Rows[i].Cells[0];
                    }
                }
       
            }
            else
                if (caixa.comboPesquisa.SelectedIndex == 1)
            {
    
                for (int i = 0; i < caixa.dgvDados.RowCount; i++)
                {
                    if (caixa.txtPesquisa.Text == caixa.dgvDados.Rows[i].Cells[3].Value.ToString())
                    {
                        caixa.dgvDados.CurrentCell = caixa.dgvDados.Rows[i].Cells[3];
                    }
                }
     
            }
        }
    }
}
