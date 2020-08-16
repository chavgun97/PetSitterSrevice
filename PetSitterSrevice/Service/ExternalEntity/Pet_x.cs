using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PetSitterSrevice.Service.ExternalEntity
{
    [DataContract]
    public class Pet_x
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public bool Sex { get; set; }
        [DataMember]
        public DateTime DateOfBirthday { get; set; }
        [DataMember]
        public string UrlPhotoLable { get; set; }
        [DataMember]
        public KindOfPet_x Kind { get; set; }  //заменить на медель
        [DataMember]
        public string Breed { get; set; } //заменить на медель
        [DataMember]
        public string Recommendation { get; set; }
        [DataMember]
        virtual public User_x User { get; set; }

    }
}