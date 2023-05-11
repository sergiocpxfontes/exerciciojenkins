namespace xUnit
{
    public class UnitTest1
    {
        [Fact]
        public void Test_BomDia()
        {
            DateTime dt = new DateTime(2023, 5, 11, 11, 0, 0);
            string resultadoesperado = "Bom dia Sérgio Fontes";
            Assert.Equal(resultadoesperado, Lib.Saudacao.Cumprimentar("Sérgio Fontes", dt));
        }
        [Fact]
        public void Test_BoaTarde()
        {
            DateTime dt = new DateTime(2023, 5, 11, 15, 0, 0);
            string resultadoesperado = "Boa tarde Sérgio Fontes";
            Assert.Equal(resultadoesperado, Lib.Saudacao.Cumprimentar("Sérgio Fontes", dt));
        }
        [Fact]
        public void Test_BoaNoite()
        {
            DateTime dt = new DateTime(2023, 5, 11, 22, 0, 0);
            string resultadoesperado = "Boa noite Sérgio Fontes";
            Assert.Equal(resultadoesperado, Lib.Saudacao.Cumprimentar("Sérgio Fontes", dt));
        }
    }
}