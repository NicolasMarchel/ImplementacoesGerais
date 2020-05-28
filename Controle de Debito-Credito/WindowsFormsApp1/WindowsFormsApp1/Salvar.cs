using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Salvar : IExecute
    {
        public void ExcutaOpeçao(Caixa caixa, ArrayList Cad, Registro registro)
        {

            if (registro.txtValor.Text != "" && registro.txtDescriçao.Text != "" && registro.comboNatureza.SelectedIndex == 0 || registro.comboNatureza.SelectedIndex == 1)
            {
                if (registro.comboNatureza.SelectedIndex == 0)
                {
                    Credito x = new Credito();


                    try
                    {
                        x.Data = registro.dtpData.Value;
                        x.Valor = Convert.ToDouble(registro.txtValor.Text);
                        if (x.Valor <= 0)
                        {
                            throw new DivideByZeroException();
                        }

                        x.Descriçao = registro.txtDescriçao.Text;
                        x.Natureza = "Crédito";
                        Cad.Add(x);
                        caixa.CarregaGrid();
                        registro.Close();

                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Favor conferir se os dados de entrada de valor são numéricos.");

                    }
                    catch(DivideByZeroException)
                    {
                        MessageBox.Show("Verifique se os valores são maiores que zero.");
                    }
                    catch (StackOverflowException)
                    {
                        MessageBox.Show("O valor é muito grande.");
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("Erro desconhecido!");
                    }

                }
                else
                if (registro.comboNatureza.SelectedIndex == 1)
                {
                    Debito x = new Debito();

                    try
                    {
                        x.Data = registro.dtpData.Value;
                        x.Valor = Convert.ToDouble(registro.txtValor.Text);
                        if (x.Valor <= 0)
                        {
                            throw new DivideByZeroException();
                        }

                        x.Descriçao = registro.txtDescriçao.Text;
                        x.Natureza = "Débito";
                        Cad.Add(x);
                        caixa.CarregaGrid();
                        registro.Close();

                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Favor conferir se os dados de entrada de valor são numéricos.");

                    }
                    catch (DivideByZeroException)
                    {
                        MessageBox.Show("Verifique se os valores são maiores que zero.");
                    }
                    catch (StackOverflowException)
                    {
                        MessageBox.Show("O valor é muito grande.");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erro desconhecido!");
                    }

                }
            }


        }
    }
}