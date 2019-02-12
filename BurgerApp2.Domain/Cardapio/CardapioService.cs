using System.Collections.Generic;

namespace BurgerApp2.Domain.Cardapio
{
    public class CardapioService : ICardapioService
    {
        readonly LancheFactory lancheFactory;

        public CardapioService(LancheFactory lancheFactory)
        {
            this.lancheFactory = lancheFactory;
        }

        public List<Lanche> Obter()
        {
            return new List<Lanche>
            {
                lancheFactory.CriarXBacon(),
                lancheFactory.CriarXBurger(),
                lancheFactory.CriarXEgg(),
                lancheFactory.CriarXEggBacon()
            };
        }
    }
}
