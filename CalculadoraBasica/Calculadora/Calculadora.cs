using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraBasica
{
    public class Calculadora
    {
        private readonly decimal _primeiroNumero;
        private readonly decimal _segundoNumero;

        public Calculadora(Decimal primeiroNumero, Decimal segundoNumero)
        {
            _primeiroNumero = primeiroNumero;
            _segundoNumero = segundoNumero;
        }

        public Decimal Calcular()
        {
            return _primeiroNumero + _segundoNumero;
        }

        public Decimal Multiplicar()
        {
            return _primeiroNumero * _segundoNumero;
        }

        public Decimal Subtrair()
        {
            return _primeiroNumero - _segundoNumero;
        }

        public Decimal Dividir()
        {
            return _primeiroNumero / _segundoNumero;
        }
    }
}
