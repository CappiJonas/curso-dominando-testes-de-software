namespace Demo.Tests
{
    public class AssertStringsTests
    {
        [Fact]
        public void StringsTools_UnirNome_RetornarNomeCompleto()
        {
            //Arrange
            var sut = new StringsTools();

            //Act
            var nomeCompleto = sut.Unir("Jonas", "Cappi");

            //Assert
            Assert.Equal("Jonas Cappi", nomeCompleto);
        }

        [Fact]
        public void StringsTools_UnirNomes_DeveIgnorarCase()
        {
            //Arrange
            var sut = new StringsTools();

            //Act
            var nomeCompleto = sut.Unir("Jonas", "Cappi");

            //Assert
            Assert.Equal("JONAS CAPPI", nomeCompleto, true);
        }

        [Fact]
        public void StringsTools_UnirNomes_DeveConterTrecho()
        {
            //Arrange
            var sut = new StringsTools();

            //Act
            var nomeCompleto = sut.Unir("Jonas", "Cappi");

            //Assert
            Assert.Contains("nas", nomeCompleto);
        }

        [Fact]
        public void StringsTools_UnirNomes_DeveComecarCom()
        {
            //Arrange
            var sut = new StringsTools();

            //Act
            var nomeCompleto = sut.Unir("Jonas", "Cappi");

            //Assert
            Assert.StartsWith("Jon", nomeCompleto);
        }

        [Fact]
        public void StringsTools_UnirNome_DeveAcabarCom()
        {
            //Arrange
            var sut = new StringsTools();

            //Act
            var nomeCompleto = sut.Unir("Jonas", "Cappi");

            //Assert
            Assert.EndsWith("ppi", nomeCompleto);
        }

        [Fact]
        public void StringsTools_UnirNomes_ValidarExpressaoRegular()
        {
            //Arrange
            var sut = new StringsTools();

            //Act
            var nomeCompleto = sut.Unir("Jonas", "Cappi");

            //Assert
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", nomeCompleto);
        }
    }
}
