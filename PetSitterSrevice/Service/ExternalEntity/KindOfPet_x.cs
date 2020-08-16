using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PetSitterSrevice.Service.ExternalEntity
{
    [DataContract]
    public enum KindOfPet_x
    {
        [EnumMember]
        NONE,
        [EnumMember]
        DOG,
        [EnumMember]
        CAT,
        [EnumMember]
        FROG
    }
}