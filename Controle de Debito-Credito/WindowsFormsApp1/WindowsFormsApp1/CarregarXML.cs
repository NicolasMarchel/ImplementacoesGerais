using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
  public  class CarregarXML:IExecute
    {

        public void ExcutaOpeçao(Caixa caixa, ArrayList Cad,Registro registro)
        {
            try
            {
                Serializar<Credito> c = new Serializar<Credito>("1");
                Serializar<Debito> d = new Serializar<Debito>("2");
                Cad.Clear();
                Cad.AddRange(c.RetornarArquivoXML());
                Cad.AddRange(d.RetornarArquivoXML());
            }
            catch(Exception)
            {
                MessageBox.Show("Erro desconhecido!");
            }

            caixa.CarregaGrid();
        }
    }
}
