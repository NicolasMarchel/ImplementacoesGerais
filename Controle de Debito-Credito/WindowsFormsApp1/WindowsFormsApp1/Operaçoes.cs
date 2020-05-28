using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Operaçoes
    {
        public ArrayList cadMovimentaçao = new ArrayList();

        private Caixa meuCaixa;
        private IExecute OP;
        public Operaçoes(Caixa x)
        {
            meuCaixa = x;
        }
        public void ExecutaOperaçao(IExecute x, Registro registro = null)
        {
            OP = x;
            OP.ExcutaOpeçao(meuCaixa, cadMovimentaçao,registro);
        }

    }
}
