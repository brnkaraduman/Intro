using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntro.Abstract
{
    public interface IGameServices
    {
        public  void Save(Game game)
        {
            Console.WriteLine("Saved to db: " + game.GameName);
        }

        public  void Update(Game game)
        {
            Console.WriteLine("Update to db: " + game.GameName);
        }
    }
}
