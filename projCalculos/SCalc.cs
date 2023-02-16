using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projCalculos
{

    //Criar diagrama: botao direito no projeto>>Add>>New Item>>ClassDiagram
    public class SCalc
    {
        private decimal _numAtual;//Botão direito>>opção com a lampada, primeira opção
        private decimal _numAnterior;
        private string _opc;

        public decimal NumAtual //Isso é encapsulamento de Orientação a Objeto
        {
            get
            {
                return _numAtual;
            }

            set
            {
                _numAtual = value;
            }
        }

        public decimal NumAnterior
        {
            get
            {
                return _numAnterior;
            }

            set
            {
                _numAnterior = value;
            }
        }

        public string Operação
        {
            get
            {
                return _opc;
            }

            set
            {
                _opc = value;
            }
        }//Aqui começa o metodo e os calculos
        public string Calcular()
        {
            string resultado="";
            decimal r;
            double rp;
            
            switch(_opc)
            {
                case "+":
                    {
                        r = _numAnterior + _numAtual;
                        resultado = r.ToString();
                        break;
                    }
                case "-":
                    {
                        r = _numAnterior - _numAtual;
                        resultado = r.ToString();
                        break;
                    }
                case ":":
                    {
                        r = _numAnterior / _numAtual;
                        resultado = r.ToString();
                        break;
                    }
                case "X":
                    {
                        r = _numAnterior * _numAtual;
                        resultado = r.ToString();
                        break;
                    }
                case "^":
                    {
                        rp = Math.Pow((double)_numAnterior, (double) _numAtual);
                        resultado = rp.ToString();
                        break;
                    }

            }
            return resultado;
        }
    }
}
