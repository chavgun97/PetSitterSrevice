using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PetSitterSrevice.Service.ExternalEntity
{
    [DataContract]
    public class User_x
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set;}
        [DataMember]
        public string UID { get; set; }
        [DataMember]
        public string UrlPhotoLable { get; set; }
        [DataMember]
        public int TestAmountInCoins { get; set; }
        [DataMember]
        public ICollection<Order_x> Orders { get; set; }
        [DataMember]
        public ICollection<Pet_x> Pets { get; set; }

        public User_x()
        {
            Orders = new List<Order_x>();
            Pets = new List<Pet_x>();
        }

    }
}