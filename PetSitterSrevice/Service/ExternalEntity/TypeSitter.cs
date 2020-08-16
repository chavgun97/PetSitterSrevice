using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PetSitterSrevice.Service.ExternalEntity
{
    [DataContract]
    public enum TypeSitter_x
    {
        [EnumMember]
        None,
        [EnumMember]
        PetSitting,
        [EnumMember]
        Сritter,
        [EnumMember]
        Walking
    }
}