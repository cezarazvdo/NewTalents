using NewTalents;

namespace TestsNewTalents
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            var resultadoCalc = calc.Somar(val1, val2);

            Assert.Equal(resultado, resultadoCalc);
        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(5, 5, 0)]
        public void TesteSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            var resultadoCalc = calc.Subtrair(val1, val2);

            Assert.Equal(resultado, resultadoCalc);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            var resultadoCalc = calc.Multiplicar(val1, val2);

            Assert.Equal(resultado, resultadoCalc);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TesteDividir(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            var resultadoCalc = calc.Dividir(val1, val2);

            Assert.Equal(resultado, resultadoCalc);
        }

        public void TestarDivisaoPorZero()
        {
            Calculadora calc = new Calculadora();

            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = new Calculadora();

            calc.Somar(1, 2);
            calc.Somar(3, 4);
            calc.Somar(5, 6);
            calc.Somar(7, 8);
            var lista = calc.Historico();

            Assert.NotEmpty(calc.Historico());
            Assert.Equal(4, lista.Count());
        }
    }
}