using BurgerApp2.Domain.Cardapio;
using System.Collections.Generic;
using Xunit;

namespace BurgerApp2.Domain.Tests
{
    public class CardapioServiceTest
    {
        [Fact]
        public void ObterTest()
        {
            var ingredienteFactory = new IngredienteFactory();
            var lancheFactory = new LancheFactory(ingredienteFactory);

            var cardapioService = new CardapioService(lancheFactory);
            var cardapio = cardapioService.Obter();

            Assert.IsType<List<Lanche>>(cardapio);
        }
    }
}
