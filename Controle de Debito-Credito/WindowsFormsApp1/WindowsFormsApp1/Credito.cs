using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Credito : Movimentaçao
    {


        public override double Totalizaçao(ArrayList cad)
        {
            double Total = 0;
            foreach (Movimentaçao item in cad)
            {
                if (item.GetType() == typeof(Credito))
                    Total += item.Valor;
            }
            return Total;
        }


    }
}
