using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class Movimentaçao
    {
        protected DateTime _Data;
        public DateTime Data
        {
            get { return _Data.Date; }
            set { _Data = value; }
        }
        protected string _Natureza;
        public string Natureza
        {
            get { return _Natureza; }
            set { _Natureza = value; }
        }
        protected string _Descriçao;
        public string Descriçao
        {
            get { return _Descriçao; }
            set { _Descriçao = value; }
        }
        protected double _Valor;
        public double Valor
        {
            get { return _Valor; }
            set { _Valor = value; }
        }
        public abstract double Totalizaçao(ArrayList cad);


    }
}
