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
            var cardapioService = new CardapioService();
            var cardapio = cardapioService.Obter();

            Assert.IsType<List<Lanche>>(cardapio);
        }
    }
}
