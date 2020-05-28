using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class TotalizarDebito : IExecute
    {

        public void ExcutaOpeçao(Caixa caixa, ArrayList Cad, Registro registro)
        {
           
            int dia=0, mes=0, ano=0;
         
            Debito total = new Debito();
            ArrayList Temp = new ArrayList();
            if (Cad.Count > 0)
            {

                if (caixa.checkMes.Checked)
                {
                    string textoMes = "";
                    switch (caixa.comboMes.SelectedIndex)
                    {

                        case 0:
                            mes = 01;
                            textoMes = "Janeiro";
                            break;
                        case 1:
                            mes = 02;
                            textoMes = "Fevereiro";
                            break;
                        case 2:
                            mes = 03;
                            textoMes = "Março";
                            break;
                        case 3:
                            mes = 04;
                            textoMes = "Abril";
                            break;
                        case 4:
                            mes = 05;
                            textoMes = "Maio";
                            break;
                        case 5:
                            mes = 06;
                            textoMes = "Junho";
                            break;
                        case 6:
                            mes = 07;
                            textoMes = "Julho";
                            break;
                        case 7:
                            mes= 08;
                            textoMes = "Agosto";
                            break;
                        case 8:
                            mes = 09;
                            textoMes = "Setembro";
                            break;
                        case 9:
                            mes = 10;
                            textoMes = "Outubro";
                            break;
                        case 10:
                            mes = 11;
                            textoMes = "Novembro";
                            break;
                        case 11:
                            mes = 12;
                            textoMes = "Dezembro";
                            break;

                    }
                    for (int i = 0; i < Cad.Count; i++)
                    {
                        if (((Movimentaçao)Cad[i]).Data.Month == mes && (Cad[i]).GetType() == typeof(Debito))
                        {
                            Temp.Add(Cad[i]);
                        }
                    }
                    caixa.txtTotal.Visible = true;
                    caixa.txtTotal.Enabled = true;
                        caixa.txtTotal.Text = "R$ " + total.Totalizaçao(Temp).ToString();
                        caixa.lblMensagem.Visible = true;
                        caixa.lblMensagem.Text = "O Débito total em " + textoMes + " é...";
                        caixa.txtTotal.Enabled = false;
                    
                   
                }
                else
                 if (caixa.checkPeriodo.Checked)
                {

                    DateTime Inicial = caixa.dtpInicial.Value;
                    DateTime Final = caixa.dtpFinal.Value;
                    for (int i = 0; i < Cad.Count; i++)
                    {
                        if (Cad[i].GetType() == typeof(Debito))
                        {
                          

                            if (((Movimentaçao)Cad[i]).Data >= Inicial && ((Movimentaçao)Cad[i]).Data <= Final)
                            {
                                Temp.Add(Cad[i]);
                            }
                        }


                    }
                    caixa.txtTotal.Visible = true;
                    caixa.txtTotal.Enabled = true;

                        caixa.txtTotal.Text = "R$ " + total.Totalizaçao(Temp).ToString();
                        caixa.lblMensagem.Visible = true;
                        caixa.lblMensagem.Text = "O Débito total entre " + caixa.dtpInicial.Value.ToString().Substring(0, 10) +
                          " e " + caixa.dtpFinal.Value.ToString().Substring(0, 10) + " é ...";
                        caixa.txtTotal.Enabled = false;
                    
                  
                }
            }




        }

    }
}
