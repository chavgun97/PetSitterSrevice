using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PetSitterSrevice.ORM.Model
{
    public class User
    {
        public int Id { get; set; }
        
        public string FireBaseAuthKey { get; set; }

        public int TestAmountInCoins { get; set; }

        virtual public ICollection<Order> Orders { get; set; }

       
        virtual public ICollection<Pet> Pets { get; set; }

    }
}