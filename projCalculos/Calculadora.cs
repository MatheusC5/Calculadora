using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projCalculos
{
    class Calculadora
    {        
        private decimal _num1;
        public decimal Num1
        {
            get
            {
                return _num1;
            }

            set
            {
                _num1 = value;
            }
        }

        private decimal _num2;
        public decimal Num2
        {
            get
            {
                return _num2;
            }

            set
            {
                _num2 = value;
            }
        }

        private decimal _resultado;
        public decimal Resultado
        {
            get
            {
                return _resultado;
            }

            set
            {
                _resultado = value;
            }
        }

        public void Somar()
        {
            _resultado = _num1 + _num2;
        }
        public string Subtrair()
        {
            _resultado = _num1 - _num2;
            return _resultado.ToString();
        }
        public string Multiplicar()
        {
            _resultado = _num1 * _num2;
            return _resultado.ToString();
        }

        public void Dividir()
        {
            _resultado = _num1 / _num2;

        }

        public string Comparar()
        {
            _resultado = _num1 = _num2;
            return _resultado.ToString();
        }

        public string RestoInt()
        {
            _resultado = _num1 % _num2;
            return _resultado.ToString();
        }

        public void ParImpar()
        {
            _resultado = _num1 %= _num2;
        }
    }
}

