using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PetSitterSrevice.Service.ExternalEntity
{
    [DataContract]
    //Пока не реализован

    public class Filter_x
    {
        //Пока не реализован
        [DataMember]
        public KindOfPet_x KindOfPet { get; set; }
        [DataMember]
        public TypeSitter_x TypeSitter { get; set; }

    }
}