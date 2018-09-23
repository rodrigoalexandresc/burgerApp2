using BurgerApp2.Models.Promocoes;
using System.Collections.Generic;

namespace BurgerApp2.Domain.Promocoes
{
    public class PromocoesVigentes
    {
        public static PromocoesVigentes _instance;

        public static PromocoesVigentes instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PromocoesVigentes();
                }

                return _instance;
            }
        }

        public List<IPromocao> Promocoes { get; private set; }

        public PromocoesVigentes()
        {
            Promocoes = new List<IPromocao>
            {
                new Light(), new MuitaCarne(), new MuitoQueijo()
            };
        }
    }
}
