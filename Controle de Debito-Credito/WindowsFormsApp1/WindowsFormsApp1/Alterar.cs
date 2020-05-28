using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1
{
    public class Alterar : IExecute
    {

        public void ExcutaOpeçao(Caixa caixa, ArrayList Cad,Registro registro)
        {
            Movimentaçao x = (Movimentaçao)Cad[caixa.dgvDados.CurrentRow.Index];
            Registro meuRegistro = new Registro(caixa);
           
            meuRegistro.txtValor.Text = x.Valor.ToString();
            meuRegistro.txtDescriçao.Text = x.Descriçao;
            meuRegistro.dtpData.Value = x.Data;

            meuRegistro.comboNatureza.Items.Clear();
            meuRegistro.comboNatureza.Items.Add("Crédito");
            meuRegistro.comboNatureza.Items.Add("Débito");

            if (x.Natureza == "Crédito")
                meuRegistro.comboNatureza.SelectedIndex = 0;
            else
                meuRegistro.comboNatureza.SelectedIndex = 1;

            meuRegistro.ShowDialog();

                
        }


    }
}
