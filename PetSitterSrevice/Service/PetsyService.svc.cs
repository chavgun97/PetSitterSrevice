using PetSitterSrevice.Service.ExternalEntity;
using PetSitterSrevice.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using PetSitterSrevice.FireBaseAuth;
using System.ServiceModel.Web;
using PetSitterSrevice.ORM.Model;

namespace PetSitterSrevice.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PetsyService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PetsyService.svc or PetsyService.svc.cs at the Solution Explorer and start debugging.
    public class PetsyService : IPetsyService
    {
        private IRep repository = MockRep.GetInstance();


        public int CreateUser(User_x user)
        {
            string UID = checkJWT(WebOperationContext.Current);
            if (user.UID != UID) throw new Exception("UidProvideUserDontMachWithAuthUid");
            
            return repository.CreateUser(user);

        }

        public User_x GetUserByToken()
        {
            string idUser = checkJWT(WebOperationContext.Current);

            User_x user = repository.GetUserByToken(idUser);

            return user;
        }

        public string IsWorking()
        {
            return "i am working!";
        }

        public IEnumerable<Sitter_x> GetAllSitters()
        {
            checkJWT(WebOperationContext.Current);

            return repository.GetAllSitters();
        }

        public IEnumerable<Sitter_x> GetSittersByLocation(string location)
        {
            checkJWT(WebOperationContext.Current);

            return repository.GetSittersByLocation(location);
        }

        public IEnumerable<Sitter_x> GetSitterByFilter(Filter_x filter)
        {
            checkJWT(WebOperationContext.Current);

            return repository.GetSitterByFilter(filter);
        }

        public int CreateSitter(Sitter_x sitter)
        {
            string UID = checkJWT(WebOperationContext.Current);
            if (sitter.UID != UID) throw new Exception("UidProvideUserDontMachWithAuthUid");

            return repository.CreateSitter(sitter);
        }

        //needs tests
        public int CreateOrder(Order_x order)
        {
            checkJWT(WebOperationContext.Current);
            string UID = checkJWT(WebOperationContext.Current);
            if ( (order.User!= null & order.User.UID != UID ) && (order.Sitter != null & order.Sitter.UID != UID) ) 
                throw new Exception("UidProvideUserDontMachWithAuthUid");

            return repository.CreateOrder(order);
        }

        public int CreatePet(Pet_x pet)
        {
            string UID = checkJWT(WebOperationContext.Current);
            if (pet.User.UID != UID) throw new Exception("UidProvideUserDontMachWithAuthUid");

            return repository.CreatePet(pet);
        }

        public int UpdateUser(User_x user)
        {
            string UID = checkJWT(WebOperationContext.Current);
            if (user.UID != UID) throw new Exception("UidProvideUserDontMachWithAuthUid");

            return repository.UpdateUser(user);
        }

        public int UpdateSitter(Sitter_x sitter)
        {
            string UID = checkJWT(WebOperationContext.Current);
            if (sitter.UID != UID) throw new Exception("UidProvideUserDontMachWithAuthUid");

            return repository.UpdateSitter(sitter);
        }

        public int UpdatePet(Pet_x pet)
        {
            string UID = checkJWT(WebOperationContext.Current);
            if (pet.User.UID != UID) throw new Exception("UidProvideUserDontMachWithAuthUid");

            return repository.UpdatePet(pet);
        }

        public int UpdateOrder(Order_x order)
        {
            checkJWT(WebOperationContext.Current);
            string UID = checkJWT(WebOperationContext.Current);
            if ((order.User != null & order.User.UID != UID) && (order.Sitter != null & order.Sitter.UID != UID))
                throw new Exception("UidProvideUserDontMachWithAuthUid");

            return repository.UpdateOrder(order);
        }

        public string[] GetAllBreeds()
        {
            checkJWT(WebOperationContext.Current);

            return repository.GetAllBreeds();
        }
        public string checkJWT(WebOperationContext context)
        {
            var req = context.IncomingRequest.Headers.Get("Authorization");
            var stringValues = req.Split(' ');
            if (stringValues.Length != 2 || !stringValues[0].Equals("Bearer"))
                throw new Exception("Bed Authorithation Token in Header");
            var FireBaseAuthKey = stringValues[1];
            return FireBaseAuth.FireBaseAuth.CheckAndGetUidFromToken(FireBaseAuthKey).Result;
        }
    }
}
