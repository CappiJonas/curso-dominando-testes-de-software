namespace Features.Tests
{
    [TestCaseOrderer("Features.Tests.PriorityOrderer", "Features.Tests")]
    public class OrdemTestes
    {
        public static bool Teste1Chamado;
        public static bool Teste2Chamado;
        public static bool Teste3Chamado;
        public static bool Teste4Chamado;

        [Fact(DisplayName = "Teste 04"), TestPriority(3)]
        [Trait("Categoria", "Ordenacao Testes")]
        public void Teste04()
        {
            //Arrange
            Teste4Chamado = true;

            //Act
            //Assert
            Assert.True(Teste3Chamado);
            Assert.True(Teste1Chamado);
            Assert.False(Teste2Chamado);
        }

        [Fact(DisplayName = "Teste 01"), TestPriority(2)]
        [Trait("Categoria", "Ordenacao Testes")]
        public void Teste01()
        {
            //Arrange
            Teste1Chamado = true;
            
            //Act
            //Assert
            Assert.True(Teste3Chamado);
            Assert.False(Teste4Chamado);
            Assert.False(Teste2Chamado);
        }

        [Fact(DisplayName = "Teste 03"), TestPriority(1)]
        [Trait("Categoria", "Ordenacao Testes")]
        public void Teste03()
        {
            //Arrange
            Teste3Chamado = true;

            //Act
            //Assert
            Assert.False(Teste1Chamado);
            Assert.False(Teste2Chamado);
            Assert.False(Teste4Chamado);
        }

        [Fact(DisplayName = "Teste 02"), TestPriority(500)]
        [Trait("Categoria", "Ordenacao Testes")]
        public void Teste02()
        {
            //Arrange
            Teste2Chamado = true;

            //Act
            //Assert
            Assert.True(Teste3Chamado);
            Assert.True(Teste4Chamado);
            Assert.True(Teste1Chamado);
        }        
    }
}
