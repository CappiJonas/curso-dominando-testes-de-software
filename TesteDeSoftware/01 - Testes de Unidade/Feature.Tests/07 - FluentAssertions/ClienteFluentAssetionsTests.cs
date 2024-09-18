using Features.Clientes;
using FluentAssertions;
using MediatR;
using Moq;
using Xunit.Abstractions;

namespace Features.Tests
{
    [Collection(nameof(ClienteAutoMockerCollection))]
    public class ClienteFluentAssetionsTests
    {
        private readonly ClienteTestsAutoMockerFixture _clienteTestsFixture;
        private ITestOutputHelper _outputHelper;

        public ClienteFluentAssetionsTests(ClienteTestsAutoMockerFixture clienteTestsFixture, ITestOutputHelper outputHelper)
        {
            _clienteTestsFixture = clienteTestsFixture;
            _outputHelper = outputHelper;
        }

        [Fact(DisplayName = "Novo Cliente Válido")]
        [Trait("Categoria", "Cliente Fluent Assertion Testes")]
        public void Cliente_NovoCliente_DeveEstarValido()
        {
            //Arrange
            var cliente = _clienteTestsFixture.GerarClienteValido();

            //Act
            var result = cliente.EhValido();

            //Assert
            //Assert.True(result);
            //Assert.Empty(cliente.ValidationResult.Errors);

            //Assert
            result.Should().BeTrue();
            cliente.ValidationResult.Errors.Should().HaveCount(0);
        }

        [Fact(DisplayName = "Novo Cliente Inválido")]
        [Trait("Categoria", "Cliente Fluent Assertion Testes")]
        public void Cliente_NovoCliente_DeveEstarInvalido()
        {
            //Arrange
            var cliente = _clienteTestsFixture.GerarClienteInvalido();

            //Act
            var result = cliente.EhValido();

            //Assert
            //Assert.False(result);
            //Assert.NotEmpty(cliente.ValidationResult.Errors);

            //Assert
            result.Should().BeFalse();
            cliente.ValidationResult.Errors.Should().HaveCountGreaterThanOrEqualTo(0, "Deve possuir erros de validação");
            _outputHelper.WriteLine($"Foram encontrados {cliente.ValidationResult.Errors.Count} erros nesta validação");
        }
    }
}