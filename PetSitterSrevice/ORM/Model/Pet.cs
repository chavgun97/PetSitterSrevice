using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetSitterSrevice.ORM.Model
{
    public class Pet
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string Name { get; set; }

        public KindOfPet Kind { get; set; }  //заменить на медель

        public SizePetType Size { get; set; } //заменить на медель

        virtual public User User { get; set; }

    }
}