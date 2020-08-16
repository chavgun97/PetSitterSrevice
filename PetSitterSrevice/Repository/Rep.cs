using PetSitterSrevice.ORM;
using PetSitterSrevice.Service.ExternalEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PetSitterSrevice.Repository
{
    /**
     * На данный момент я хочу сделать репозиторий синглтоном, это значит что все потоки будут использовать один обьект
     * для подключения к базе данных. В будущем это может быть узким горлышком, если
     * в Entyti Framework не реализована автоматическая оптимизация работы в многопоточной системе. То есть 
     * по моей логике если у нас один класс для управления бд, то и одно подключение к бд на одном потоке, 
     * что звучит как плохая оптимизация работы с бд. Но я работаю только с интерфейсом фреймфорка орм, и надесь,
     * что в внутриностях оптимизация реализована автоматически.
     */
    public class Rep : IRep
    {
        private static readonly Rep instance = new Rep();

        private Rep()
        {
        }
        
        public static Rep GetInstance()
        {
            return instance;
        }

        public int CreateOrder(Order_x order)
        {
            throw new NotImplementedException();
        }

        public int CreatePet(Pet_x pet, int UserId)
        {
            throw new NotImplementedException();
        }

        public int CreatePet(Pet_x pet)
        {
            throw new NotImplementedException();
        }

        public int CreateSitter(string Token)
        {
            throw new NotImplementedException();
        }

        public int CreateSitter(Sitter_x sitter_x)
        {
            throw new NotImplementedException();
        }

        public int CreateUser(string FireBaseAuthKey)
        {
            int result = -1;
            using (var context = new PetSitterDbContext())
            {
                var users = context.Users;
                bool isAlreadyExist = users.Any(x => x.FireBaseAuthKey == FireBaseAuthKey);
                if((isAlreadyExist || FireBaseAuthKey == null || FireBaseAuthKey.Equals("")) != true)
                {
                    context.Users.Add(new ORM.Model.User() { FireBaseAuthKey = FireBaseAuthKey });
                    context.SaveChanges();
                    result = 0;
                }
                else
                {
                    result = -1;
                }
            }

                return result;
        }

        public int CreateUser(User_x user_x)
        {
            throw new NotImplementedException();
        }

        public string[] GetAllBreeds()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Sitter_x> GetAllSitters()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order_x> GetOrdersBySitterId(int SitterId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order_x> GetOrdersByUserId(int UserId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pet_x> GetPetsByUserId(int UserId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Sitter_x> GetSitterByFilter(Filter_x filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Sitter_x> GetSittersByLocation(string location)
        {
            throw new NotImplementedException();
        }

        public User_x GetUserByToken(string FireBaseAuthKey)
        {
            User_x user = null;
            if((FireBaseAuthKey == null || FireBaseAuthKey.Equals("")) == true)
            {
                return null;
            }
            using (var context = new PetSitterDbContext())
            {
                try
                {
                    var DbUser = context.Users.First(x => x.FireBaseAuthKey == FireBaseAuthKey);
                    user = new User_x()
                    {
                        Id = DbUser.Id,
                        UID = DbUser.FireBaseAuthKey,
                        TestAmountInCoins = DbUser.TestAmountInCoins,
                        Orders = null,
                        Pets = null //<------------------------------------------------------ not corect impl 
                       
                    };

                }
                catch (Exception e )
                {
                    Console.WriteLine(e.Message);
                }
                
            }
            return user;
            
        }

        public int UpdateOrder(Order_x order)
        {
            throw new NotImplementedException();
        }

        public int UpdatePet(Pet_x pet)
        {
            throw new NotImplementedException();
        }

        public int UpdateSitter(Sitter_x sitter)
        {
            throw new NotImplementedException();
        }

        public int UpdateUser(User_x user)
        {
            throw new NotImplementedException();
        }
    }
}