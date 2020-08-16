using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Google.Apis.Auth.OAuth2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace PetSitterSrevice.FireBaseAuth
{
    public class FireBaseAuth
    {
        private static FirebaseApp FirebaseApp = FirebaseApp.Create(new AppOptions()
        {
            Credential = GoogleCredential.FromFile("C:\\Users\\Nikolaj\\Desktop\\Diplom\\Programm system\\PetSitterSrevice\\PetSitterSrevice\\FireBaseAuth\\petsy-a0383-firebase-adminsdk-j04q4-26b894a971.json")
        });
        private FireBaseAuth()
        {     
        }

        public static async Task<string> CheckAndGetUidFromToken(string Token)
        {
            FirebaseToken firebaseToken = await FirebaseAuth.DefaultInstance.VerifyIdTokenAsync(Token);
            return firebaseToken.Uid;
        }



    }
}