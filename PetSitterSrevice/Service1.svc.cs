using PetSitterSrevice.ORM;
using PetSitterSrevice.ORM.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PetSitterSrevice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData()
        {
            string r ="";
            using (var context = new PetSitterDbContext())
            {
                var user = new User() { TestAmountInCoins = 555, Pets = new List<Pet>() { new Pet() { Kind = KindOfPet.FROG } } };
                var sitter = new Sitter();
                context.Users.Add(user) ;
                context.Sitters.Add(sitter);
                context.SaveChanges();
                context.Orders.Add(new Order() { User = user, Sitter = sitter, PetId = context.Users.First(x => x.Id == 25).Pets.First().Id }); 
                context.SaveChanges();
                r = context.Users.ToArray<User>().Length.ToString();

            }
                return r;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
