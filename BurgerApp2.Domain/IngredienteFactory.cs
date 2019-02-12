using BurgerApp2.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerApp2.Domain
{
    public class IngredienteFactory
    {
        public LancheIngrediente CriarBacon() => new LancheIngrediente(IngredienteTipoEnum.Bacon, 1, 2m);
        public LancheIngrediente CriarHamburger() => new LancheIngrediente(IngredienteTipoEnum.HamburgerDeCarne, 1, 3m);
        public LancheIngrediente CriarAlface() => new LancheIngrediente(IngredienteTipoEnum.Alface, 1, 0.4m);
        public LancheIngrediente CriarOvo() => new LancheIngrediente(IngredienteTipoEnum.Ovo, 1, 0.8m);
        public LancheIngrediente CriarQueijo() => new LancheIngrediente(IngredienteTipoEnum.Queijo, 1, 1.5m);
    }
}
