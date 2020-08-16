using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PetSitterSrevice.ORM.Model
{
    [DataContract]
    public enum TypeSitter
    {
        [EnumMember]
        PetSitting,
        [EnumMember]
        Сritter,
        [EnumMember]
        Walking
    }
}