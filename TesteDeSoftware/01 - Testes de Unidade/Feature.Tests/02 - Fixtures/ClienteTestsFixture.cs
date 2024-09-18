using Bogus;
using Bogus.DataSets;
using Features.Clientes;

namespace Features.Tests
{
    [CollectionDefinition(nameof(ClienteCollection))]
    public class ClienteCollection : ICollectionFixture<ClienteTestsFixture> { }

    public class ClienteTestsFixture : IDisposable
    {
        public Cliente GerarClienteValido()
        {
            var cliente = new Cliente(
                Guid.NewGuid(),
                "Jonas",
                "Cappi",
                DateTime.Now.AddYears(-26),
                "jonas@cappi.com",
                true,
                DateTime.Now);

            return cliente;
        }

        public Cliente GerarClienteInvalido()
        {
            var cliente = new Cliente(
                Guid.NewGuid(),
                "",
                "",
                DateTime.Now,
                "jonas2cappi.com",
                true,
                DateTime.Now);

            return cliente;
        }

        public void Dispose() { }
    }
}
