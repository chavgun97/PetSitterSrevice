using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PetSitterSrevice.ORM.Model
{
    [DataContract]
    public enum SizePetType
    {
        [EnumMember]
        BIG,
        [EnumMember]
        MIDDLE ,
        [EnumMember]
        SMALL
    }
}