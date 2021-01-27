using GameIntro.Abstract;
using GameIntro.Concrete;
using System;

namespace GameIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            IGamerServices gamerManager = new GamerManager();
            gamerManager.Save(new Entities.Gamer {DateOfBirth=new DateTime(1981,1,1),FirstName="Brn",LastName="Krdmn",NationalityId= 111111111112});
            gamerManager.Update(new Entities.Gamer { DateOfBirth = new DateTime(1981, 1, 1), FirstName = "Ali", LastName = "Krdmn", NationalityId = 111111111112 });

            //IGameServices gameManager = new GameManager();
            //gameManager.Save(new Entities.Game { GameName = "AAA", GameCompany = "BBB", GamePrice = 123 });


            ISaleManagerServices gameSaleManager = new GameSaleManager();
            
            
        }


    }
}
