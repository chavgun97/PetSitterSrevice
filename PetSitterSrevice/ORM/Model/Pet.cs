using PetSitterSrevice.ORM.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PetSitterSrevice.ORM.Model
{   
    public class Pet
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public Breed Breed { get; set; }  //заменить на медель
        public bool Sex { get; set; }
        public DateTime DayOfBirthday { get; set; }
        public String Recommendations { get; set; }

        virtual public User User { get; set; }

    }
}