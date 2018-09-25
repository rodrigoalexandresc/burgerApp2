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
        public void CalcularValorBrutoComOutrosValoresTest()
        {
            var xBacon = new Lanche("X-Bacon", new List<LancheIngrediente>
            {
                new LancheIngrediente(IngredienteTipoEnum.Bacon, 1, 3m),
                new LancheIngrediente(IngredienteTipoEnum.HamburgerDeCarne, 1, 4m),
                new LancheIngrediente(IngredienteTipoEnum.Queijo, 1, 2m)
            });

            Assert.Equal(9m, xBacon.ValorBruto);
        }

        [Fact]
        public void PromocaoLightTest()
        {
            var light = new Lanche("Light", new List<LancheIngrediente>
            {
                new LancheIngrediente(IngredienteTipoEnum.Alface, 1, 0.4m),
                new LancheIngrediente(IngredienteTipoEnum.HamburgerDeCarne, 1, 3m),
                new LancheIngrediente(IngredienteTipoEnum.Queijo, 1, 1.5m)
            });

            Assert.Equal(4.41m, light.ValorTotal);
        }

        [Fact]
        public void PromocaoMuitaCarneTest()
        {
            var duploCarne = new Lanche("MuitaCarne", new List<LancheIngrediente>
            {
                new LancheIngrediente(IngredienteTipoEnum.Alface, 1, 0.4m),
                new LancheIngrediente(IngredienteTipoEnum.Bacon, 1, 2m),
                new LancheIngrediente(IngredienteTipoEnum.HamburgerDeCarne, 3, 3m),
                new LancheIngrediente(IngredienteTipoEnum.Queijo, 1, 1.5m)
            });

            Assert.Equal(9.9m, duploCarne.ValorTotal);
        }

        [Fact]
        public void PromocaoMuitaCarneComVariasPorcoesTest()
        {
            var duploCarne = new Lanche("MuitaCarne", new List<LancheIngrediente>
            {
                new LancheIngrediente(IngredienteTipoEnum.Alface, 1, 0.4m),
                new LancheIngrediente(IngredienteTipoEnum.Bacon, 1, 2m),
                new LancheIngrediente(IngredienteTipoEnum.HamburgerDeCarne, 6, 3m),
                new LancheIngrediente(IngredienteTipoEnum.Queijo, 1, 1.5m)
            });

            Assert.Equal(15.9m, duploCarne.ValorTotal);
        }

        [Fact]
        public void PromocaoMuitoQueijoTest()
        {
            var duploQueijo = new Lanche("Queijo", new List<LancheIngrediente>
            {
                new LancheIngrediente(IngredienteTipoEnum.Alface, 1, 0.4m),
                new LancheIngrediente(IngredienteTipoEnum.Bacon, 1, 2m),
                new LancheIngrediente(IngredienteTipoEnum.HamburgerDeCarne, 1, 3m),
                new LancheIngrediente(IngredienteTipoEnum.Queijo, 3, 1.5m)
            });

            Assert.Equal(8.4m, duploQueijo.ValorTotal);
        }

        [Fact]
        public void PromocaoMuitoQueijoComVariasPorcoesTest()
        {
            var duploQueijo = new Lanche("Queijo", new List<LancheIngrediente>
            {
                new LancheIngrediente(IngredienteTipoEnum.Alface, 1, 0.4m),
                new LancheIngrediente(IngredienteTipoEnum.Bacon, 1, 2m),
                new LancheIngrediente(IngredienteTipoEnum.HamburgerDeCarne, 1, 3m),
                new LancheIngrediente(IngredienteTipoEnum.Queijo, 6, 1.5m)
            });

            Assert.Equal(11.4m, duploQueijo.ValorTotal);
        }
    }
}
