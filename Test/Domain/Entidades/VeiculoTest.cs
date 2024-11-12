using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public class VeiculoTest
{
    [TestMethod]
    public void TestarGetSetPropiedades()
    {
        // Arrange
        var veiculo = new Veiculo();

        // Act
        veiculo.Id = 1;
        veiculo.Nome = "X6";
        veiculo.Marca = "BMW";
        veiculo.Ano = 2016;

        // Assert
        Assert.AreEqual(1, veiculo.Id);
        Assert.AreEqual("X6", veiculo.Nome);
        Assert.AreEqual("BMW", veiculo.Marca);
        Assert.AreEqual(2016, veiculo.Ano);

    }
}