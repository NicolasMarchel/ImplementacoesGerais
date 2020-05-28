using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Ordenar : IExecute
    {
        public void ExcutaOpeçao(Caixa caixa, ArrayList Cad, Registro registro)
        {

            Cad.Sort(new minha_comparaçao());
            caixa.CarregaGrid();

        }

    }
    class minha_comparaçao : IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            return ((Movimentaçao)x).Data.CompareTo(((Movimentaçao)y).Data);
        }

    }
}
