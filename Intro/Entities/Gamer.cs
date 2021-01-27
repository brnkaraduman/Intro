using GameIntro.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntro.Entities
{
   public class Gamer:IEntity
    {
        public int Id { get; set; }
        public long NationalityId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
