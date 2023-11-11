using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> historico;
        private DateTime data = new DateTime();
        public Calculadora(DateTime data)
        {
            historico = new List<string>();
            this.data = data;
        }

        public int Somar(int val1, int val2)
        {
            var result = val1 + val2;
            historico.Insert(0, $"Soma: {val1} + {val2} = {result} - data: {data}");
            return result;
        }
        public int Subtrair(int val1, int val2)
        {
            var result = val1 - val2;
            historico.Insert(0, $"Subtrair: {val1} - {val2} = {result} - data: {data}");
            return result;
        }
        public int Multiplicar(int val1, int val2)
        {
            var result = val1 * val2;
            historico.Insert(0, $"Multiplicar: {val1} * {val2} = {result} - data: {data}");
            return result;
        }
        public int Dividir(int val1, int val2)
        {
            var result = val1 / val2;
            historico.Insert(0, $"Dividir: {val1} / {val2} = {result} - data: {data}");
            return result;
        }

        public List<string> Historico()
        {
            historico.RemoveRange(3, historico.Count - 3);

            return historico;
        }
    }
}
