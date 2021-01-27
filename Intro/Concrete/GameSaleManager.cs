using GameIntro.Abstract;
using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntro.Concrete
{
    public class GameSaleManager: ISaleManagerServices
    {
        public void DeleteCampaign(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName + " adlı oyuncu " + game.GameName + " adlı oyunu Sildi.");
        }

        public void NewCampaignAdd(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName + " adlı oyuncu " + game.GameName + " adlı oyunu satın aldı.");
        }

        public void UpdateCampaign(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName + " adlı oyuncu " + game.GameName + " adlı oyunu  versiyon satın aldı.");
        }
    }
}
