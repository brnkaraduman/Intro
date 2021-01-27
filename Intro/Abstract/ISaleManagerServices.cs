using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntro.Abstract
{
   public interface ISaleManagerServices
    {
        void NewCampaignAdd(Gamer gamer, Game game);
        void DeleteCampaign(Gamer gamer, Game game);
        void UpdateCampaign(Gamer gamer, Game game);
    }
}
