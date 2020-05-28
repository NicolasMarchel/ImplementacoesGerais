using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public class Excluir : IExecute
    {
        public void ExcutaOpeçao(Caixa caixa, ArrayList cad,Registro registro)
        {
            cad.RemoveAt(caixa.dgvDados.CurrentRow.Index);
            caixa.CarregaGrid();
        }


    }
}
