using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetSitterSrevice.Service.ExternalEntity;

namespace PetSitterSrevice.Repository
{
    interface IRep
    {
        User_x GetUserByToken(String UID);
        IEnumerable<Pet_x> GetPetsByUserId(int UserId);
        IEnumerable<Sitter_x> GetAllSitters();
        IEnumerable<Order_x> GetOrdersByUserId(int UserId);
        IEnumerable<Order_x> GetOrdersBySitterId(int SitterId);
        IEnumerable<Sitter_x> GetSittersByLocation(String location);
        IEnumerable<Sitter_x> GetSitterByFilter(Filter_x filter);

        int CreateUser(User_x user_x);
        int CreateSitter(Sitter_x sitter_x);
        int CreateOrder(Order_x order);
        int CreatePet(Pet_x pet, int UserId);
        int CreatePet(Pet_x pet);
        int UpdatePet(Pet_x pet);
        int UpdateUser(User_x user);
        int UpdateSitter(Sitter_x sitter);
        int UpdateOrder(Order_x order);
        string[] GetAllBreeds();

    }
}
