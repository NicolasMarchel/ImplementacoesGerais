using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class GerarRelatorio : IExecute
    {

        public void ExcutaOpeçao(Caixa caixa, ArrayList Cad,Registro registro)
        {
            int dia=0, mes=0, ano=0;
         
            ArrayList Temp = new ArrayList();
            if (caixa.checkMes.Checked)
            {

                switch (caixa.comboMes.SelectedIndex)
                {

                    case 0:
                        mes = 01;
                       
                        break;
                    case 1:
                        mes = 02;
                      
                        break;
                    case 2:
                        mes = 03;
                      
                        break;
                    case 3:
                        mes = 04;
                      
                        break;
                    case 4:
                        mes = 05;
                     
                        break;
                    case 5:
                        mes = 06;
                      
                        break;
                    case 6:
                        mes = 07;
                     
                        break;
                    case 7:
                        mes = 08;
                      
                        break;
                    case 8:
                        mes = 09;
                    
                        break;
                    case 9:
                        mes = 10;
                  
                        break;
                    case 10:
                        mes = 11;
                   
                        break;
                    case 11:
                        mes = 12;
                   
                        break;


                }
                for (int i = 0; i < Cad.Count; i++)
                {
                    if (((Movimentaçao)Cad[i]).Data.Month == mes)
                    {
                        Temp.Add(Cad[i]);
                    }
                }
                caixa.CarregaGrid(Temp);
            }
            else
                 if (caixa.checkPeriodo.Checked)
            {

                DateTime Inicial = caixa.dtpInicial.Value;
                DateTime Final = caixa.dtpFinal.Value;
                for (int i = 0; i < Cad.Count; i++)
                {
                   
                    if (((Movimentaçao)Cad[i]).Data >= Inicial && ((Movimentaçao)Cad[i]).Data <= Final)
                    {
                        Temp.Add(Cad[i]);
                    }
                }

                caixa.CarregaGrid(Temp);
            }
        }

    }
}
