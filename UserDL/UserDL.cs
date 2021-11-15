using Entity;
using System;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace DL
{
    public class UserDL : IUserDL
    {
        public user getUser(string email, string password)
        {
            using (StreamReader reader = System.IO.File.OpenText("M:/webAPI/MyFirstWebApiSite/user.txt"))
            {
                string currentUser;
                while ((currentUser = reader.ReadLine()) != null)
                {

                    user user = JsonSerializer.Deserialize<user>(currentUser);
                    if (user.email == email && user.password == password)
                        return user;
                }
            }
            return null;
        }
        public user postUser(user u)
        {
            int numberOfUsers = System.IO.File.ReadLines("M:/webAPI/MyFirstWebApiSite/user.txt").Count();
            u.id = numberOfUsers + 1;
            string userJson = JsonSerializer.Serialize(u);
            System.IO.File.AppendAllText("M:/webAPI/MyFirstWebApiSite/user.txt", userJson + Environment.NewLine);
            return u;
        }
        public void putUser(int id, user u)
        {

            string textToReplace = "";
            using (StreamReader reader = System.IO.File.OpenText("M:/webAPI/MyFirstWebApiSite/user.txt"))
            {
                string currentUser;
                while ((currentUser = reader.ReadLine()) != null)
                {

                    user user = JsonSerializer.Deserialize<user>(currentUser);
                    if (user.id == id)
                        textToReplace = currentUser;
                }
            }

            if (textToReplace != string.Empty)
            {
                string text = System.IO.File.ReadAllText("M:/webAPI/MyFirstWebApiSite/user.txt");
                text = text.Replace(textToReplace, JsonSerializer.Serialize(u));
                System.IO.File.WriteAllText("M:/webAPI/MyFirstWebApiSite/user.txt", text);
            }






        }
    }
}



