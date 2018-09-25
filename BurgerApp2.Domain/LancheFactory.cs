using BurgerApp2.Domain.Enums;
using System.Collections.Generic;

namespace BurgerApp2.Domain.Cardapio
{
    public class LancheFactory
    {

        public Lanche CriarLanchePersonalizado(List<LancheIngrediente> lista)
        {
            return new Lanche("Personalizado", lista);
        }

        public Lanche CriarXEggBacon()
        {
            return new Lanche("X-Egg-Bacon", new List<LancheIngrediente>
            {
                CriarOvo(), CriarBacon(), CriarHamburger(), CriarQueijo()
            });
        }

        public Lanche CriarXEgg()
        {
            return new Lanche("X-Egg", new List<LancheIngrediente>
            {
                CriarOvo(), CriarHamburger(), CriarQueijo()
            });
        }

        public Lanche CriarXBurger()
        {
            return new Lanche("X-Burger", new List<LancheIngrediente>
            {
                CriarHamburger(), CriarQueijo()
            });
        }

        public Lanche CriarXBacon()
        {
            return new Lanche("X-Bacon", new List<LancheIngrediente>
            {
                CriarBacon(), CriarHamburger(), CriarQueijo()
            });
        }

        private LancheIngrediente CriarBacon() => new LancheIngrediente(IngredienteTipoEnum.Bacon, 1, 2m);
        private LancheIngrediente CriarHamburger() => new LancheIngrediente(IngredienteTipoEnum.HamburgerDeCarne, 1, 3m);
        private LancheIngrediente CriarAlface() => new LancheIngrediente(IngredienteTipoEnum.Alface, 1, 0.4m);
        private LancheIngrediente CriarOvo() => new LancheIngrediente(IngredienteTipoEnum.Ovo, 1, 0.8m);
        private LancheIngrediente CriarQueijo() => new LancheIngrediente(IngredienteTipoEnum.Queijo, 1, 1.5m);
    }
}
