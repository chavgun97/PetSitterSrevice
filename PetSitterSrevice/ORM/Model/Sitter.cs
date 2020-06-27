using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.Drawing;
using System.Linq;
using System.Web;

namespace PetSitterSrevice.ORM.Model
{
    public class Sitter
    {
        public int Id { get; set; }

        public string FireBaseAuthKey { get; set; }

        public TypeSitter Type { get; set; }  //заменить на списко медлей

        public SizePetType TypeSizePetSitter { get; set; } //заменить на списко медлей

        public KindOfPet KindofPet { get; set; } //заменить на списко медлей

        public DbGeography Location { get; set; }

        public int PriceInCoins { get; set; }

        public int TestAmountInCoins { get; set; }

        virtual public ICollection<Order> Orders { get; set; }



    }
}