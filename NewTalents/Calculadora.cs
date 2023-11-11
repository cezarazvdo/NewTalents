using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> historico = new List<string>();

        public int Somar(int val1, int val2)
        {
            var result = val1 + val2;
            historico.Add($"Soma: {val1} + {val2} = {result}");
            return result;
        }
        public int Subtrair(int val1, int val2)
        {
            var result = val1 - val2;
            historico.Add($"Subtrair: {val1} - {val2} = {result}");
            return result;
        }
        public int Multiplicar(int val1, int val2)
        {
            var result = val1 * val2;
            historico.Add($"Multiplicar: {val1} * {val2} = {result}");
            return result;
        }
        public int Dividir(int val1, int val2)
        {
            var result = val1 / val2;
            historico.Add($"Dividir: {val1} / {val2} = {result}");
            return result;
        }

        public List<string> Historico()
        {
            return historico;
        }
    }
}
