using GameIntro.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntro.Entities
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public String GameName { get; set; }
        public String GameCompany { get; set; }
        public int GamePrice { get; set; }

    }
}
