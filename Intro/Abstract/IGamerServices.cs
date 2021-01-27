using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntro.Abstract
{
   public interface IGamerServices
    {
        public virtual void Save(Gamer gamer)
        {
            Console.WriteLine("Saved to db: " + gamer.FirstName);
        }

        public virtual void Update(Gamer gamer)
        {
            Console.WriteLine("Update to db: " + gamer.FirstName);
        }
    }
}
