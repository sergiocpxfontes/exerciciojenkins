namespace xUnit
{
    public class UnitTest1
    {
        [Fact]
        public void Test_BomDia()
        {
            DateTime dt = new DateTime(2023, 5, 11, 11, 0, 0);
            string resultadoesperado = "Bom dia S�rgio Fontes";
            Assert.Equal(resultadoesperado, Lib.Saudacao.Cumprimentar("S�rgio Fontes", dt));
        }
        [Fact]
        public void Test_BoaTarde()
        {
            DateTime dt = new DateTime(2023, 5, 11, 15, 0, 0);
            string resultadoesperado = "Boa tarde S�rgio Fontes";
            Assert.Equal(resultadoesperado, Lib.Saudacao.Cumprimentar("S�rgio Fontes", dt));
        }
        [Fact]
        public void Test_BoaNoite()
        {
            DateTime dt = new DateTime(2023, 5, 11, 22, 0, 0);
            string resultadoesperado = "Boa noite S�rgio Fontes";
            Assert.Equal(resultadoesperado, Lib.Saudacao.Cumprimentar("S�rgio Fontes", dt));
        }
    }
}