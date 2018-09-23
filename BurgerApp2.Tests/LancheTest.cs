using BurgerApp2.Domain;
using BurgerApp2.Domain.Enums;
using System.Collections.Generic;
using Xunit;

namespace BurgerApp2.Domain.Tests
{
    public class LancheTest
    {
        [Fact]
        public void CalcularValorBrutoTest()
        {
            var xBacon = new Lanche("X-Bacon", new List<LancheIngrediente>
            {
                new LancheIngrediente(IngredienteTipoEnum.Bacon, 1, 2m),
                new LancheIngrediente(IngredienteTipoEnum.HamburgerDeCarne, 1, 3m),
                new LancheIngrediente(IngredienteTipoEnum.Queijo, 1, 1.5m)
            });

            Assert.Equal(6.5m, xBacon.ValorBruto);
        }

        [Fact]
        public void PromocaoLightTest()
        {
            var light = new Lanche("DuploCarne", new List<LancheIngrediente>
            {
                new LancheIngrediente(IngredienteTipoEnum.Alface, 1, 0.4m),
                new LancheIngrediente(IngredienteTipoEnum.HamburgerDeCarne, 1, 3m),
                new LancheIngrediente(IngredienteTipoEnum.Queijo, 1, 1.5m)
            });

            Assert.Equal(4.41m, light.ValorTotal);
        }

        [Fact]
        public void PromocaoMuitaCarne()
        {
            var duploCarne = new Lanche("Light", new List<LancheIngrediente>
            {
                new LancheIngrediente(IngredienteTipoEnum.Alface, 1, 0.4m),
                new LancheIngrediente(IngredienteTipoEnum.Bacon, 1, 2m),
                new LancheIngrediente(IngredienteTipoEnum.HamburgerDeCarne, 3, 3m),
                new LancheIngrediente(IngredienteTipoEnum.Queijo, 1, 1.5m)
            });

            Assert.Equal(9.9m, duploCarne.ValorTotal);
        }

        [Fact]
        public void PromocaoMuitoQueijo()
        {
            var duploQueijo = new Lanche("Light", new List<LancheIngrediente>
            {
                new LancheIngrediente(IngredienteTipoEnum.Alface, 1, 0.4m),
                new LancheIngrediente(IngredienteTipoEnum.Bacon, 1, 2m),
                new LancheIngrediente(IngredienteTipoEnum.HamburgerDeCarne, 1, 3m),
                new LancheIngrediente(IngredienteTipoEnum.Queijo, 3, 1.5m)
            });

            Assert.Equal(8.4m, duploQueijo.ValorTotal);
        }
    }
}
