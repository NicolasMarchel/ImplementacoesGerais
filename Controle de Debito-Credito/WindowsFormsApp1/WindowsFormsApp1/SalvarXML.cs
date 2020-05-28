using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class SalvarXML : IExecute
    {
        public void ExcutaOpeçao(Caixa caixa, ArrayList Cad, Registro registro)
        {
            try
            {
                ArrayList cadCredito = new ArrayList();
                foreach (var item in Cad)
                {
                    if (item.GetType() == typeof(Credito))
                    {
                        cadCredito.Add(item);
                    }
                }
                ArrayList cadDebito = new ArrayList();
                foreach (var item in Cad)
                {
                    if (item.GetType() == typeof(Debito))
                    {
                        cadDebito.Add(item);
                    }
                }

                Serializar<Credito> c = new Serializar<Credito>(cadCredito, "1");
                Serializar<Debito> d = new Serializar<Debito>(cadDebito, "2");

                c.SalvarXML();
                d.SalvarXML();

            }
            catch (Exception)
            {
                MessageBox.Show("Erro desconhecido!");
            }


        }
    }
}
