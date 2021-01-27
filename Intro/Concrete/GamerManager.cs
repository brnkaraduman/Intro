using GameIntro.Abstract;
using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntro.Concrete
{
    public class GamerManager : IGamerServices
    {
        public void Save(Gamer gamer)
        {
           if (CheckIfRealPerson(gamer))
            {
                Save(gamer);
            }
            else
            {
                Console.WriteLine("Not Valid Person");
            }         
        }


        public  void Update(Gamer gamer)
        {
            if (CheckIfRealPerson(gamer))
            {
               Update(gamer);
            }
            else
            {
                Console.WriteLine("Not Valid Person");
            }
        }

        private Boolean CheckIfRealPerson(Gamer gamer)
        {
            return true;
        }
    }
}
