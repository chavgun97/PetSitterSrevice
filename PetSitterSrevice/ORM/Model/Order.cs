using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PetSitterSrevice.ORM.Model
{
    public class Order
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int PetId { get; set; }

        public int SitterId { get; set; }

        public int PriseInCoin { get; set; }

        public TypeSitter Type { get; set; }

        public DateTime? From { get; set; }

        public DateTime? To { get; set; }

        public bool IsActive { get; set; }

        virtual public User User { get; set; }

        virtual public Sitter Sitter { get; set; }


    }
}