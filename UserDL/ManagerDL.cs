using Entity;
using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace DL
{
    public class ManagerDL : IManagerDL
    {
        public async Task <Manager> getManager(string ManagerName, string password)
        {
           Manager manager=await DonationManagementContext.
                    if (manager.password == password && manager.ManagerName == ManagerName)
                        return manager;
          return null;
        }
        //public async Task<user> postUser(user u)
        //{
        //    int numberOfUsers =  System.IO.File.ReadLines("M:/webAPI/MyFirstWebApiSite/user.txt").Count();
        //    u.id = numberOfUsers + 1;
        //    string userJson = JsonSerializer.Serialize(u);
        //  await  System.IO.File.AppendAllTextAsync("M:/webAPI/MyFirstWebApiSite/user.txt", userJson + Environment.NewLine);
        //    return u;
        //}
        public async void putUser(int id, user u)
        {

            string textToReplace = "";
            using (StreamReader reader = System.IO.File.OpenText("M:/webAPI/MyFirstWebApiSite/user.txt"))
            {
                string currentUser;
                while ((currentUser =await reader.ReadLineAsync()) != null)
                {

                    user user = JsonSerializer.Deserialize<user>(currentUser);
                    if (user.id == id)
                        textToReplace = currentUser;
                }
            }

            if (textToReplace != string.Empty)
            {
                string text =await System.IO.File.ReadAllTextAsync("M:/webAPI/MyFirstWebApiSite/user.txt");
                text = text.Replace(textToReplace, JsonSerializer.Serialize(u));
               await System.IO.File.WriteAllTextAsync("M:/webAPI/MyFirstWebApiSite/user.txt", text);
            }






        }
    }
}



