using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PetSitterSrevice.Service.ExternalEntity
{
    [DataContract]
    public class Order_x
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int PriseInCoin { get; set; }
        [DataMember]
        public TypeSitter_x Type { get; set; }
        [DataMember]
        public DateTime? From { get; set; }
        [DataMember]
        public DateTime? To { get; set; }
        [DataMember]
        public bool IsActive { get; set; }
        [DataMember]
         public User_x User { get; set; }
        [DataMember]
         public Sitter_x Sitter { get; set; }
        [DataMember]
        public Pet_x Pet { get; set; }



    }
}