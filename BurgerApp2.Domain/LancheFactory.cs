using BurgerApp2.Domain.Enums;
using System.Collections.Generic;

namespace BurgerApp2.Domain.Cardapio
{
    public class LancheFactory
    {
        readonly IngredienteFactory ingredienteFactory;
        public LancheFactory(IngredienteFactory ingredienteFactory)
        {
            this.ingredienteFactory = ingredienteFactory;
        }

        public Lanche CriarLanchePersonalizado(List<LancheIngrediente> lista)
        {
            return new Lanche("Personalizado", lista);
        }

        public Lanche CriarXEggBacon()
        {
            return new Lanche("X-Egg-Bacon", new List<LancheIngrediente>
            {
                ingredienteFactory.CriarOvo(),
                ingredienteFactory.CriarBacon(),
                ingredienteFactory.CriarHamburger(),
                ingredienteFactory.CriarQueijo()
            });
        }

        public Lanche CriarXEgg()
        {
            return new Lanche("X-Egg", new List<LancheIngrediente>
            {
                ingredienteFactory.CriarOvo(),
                ingredienteFactory.CriarHamburger(),
                ingredienteFactory.CriarQueijo()
            });
        }

        public Lanche CriarXBurger()
        {
            return new Lanche("X-Burger", new List<LancheIngrediente>
            {
                ingredienteFactory.CriarHamburger(),
                ingredienteFactory.CriarQueijo()
            });
        }

        public Lanche CriarXBacon()
        {
            return new Lanche("X-Bacon", new List<LancheIngrediente>
            {
                ingredienteFactory.CriarBacon(),
                ingredienteFactory.CriarHamburger(),
                ingredienteFactory.CriarQueijo()
            });
        }
    }
}
