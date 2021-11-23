using Entity;

using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    class GroupDL
    {

        public async Task<Group> getGroupById(int id)
        {
            using (StreamReader reader = System.IO.File.OpenText("M:/webAPI/MyFirstWebApiSite/user.txt"))
            {
                string currentUser;
                while ((currentUser = await reader.ReadLineAsync()) != null)
                {

                    user user = JsonSerializer.Deserialize<user>(currentUser);
                    if (user.email == email && user.password == password)
                        return user;
                }
            }
            return null;
        }


        public async Task<List<Group>> getGroups()
        {
            return 
        }
        public async Task<Group> postGroup(Group g)
        {
            int numberOfUsers = System.IO.File.ReadLines("M:/webAPI/MyFirstWebApiSite/user.txt").Count();
            u.id = numberOfUsers + 1;
            string userJson = JsonSerializer.Serialize(u);
            await System.IO.File.AppendAllTextAsync("M:/webAPI/MyFirstWebApiSite/user.txt", userJson + Environment.NewLine);
            return u;
        }
        public async void putGroup(Group g)
        {

            string textToReplace = "";
            using (StreamReader reader = System.IO.File.OpenText("M:/webAPI/MyFirstWebApiSite/user.txt"))
            {
                string currentUser;
                while ((currentUser = await reader.ReadLineAsync()) != null)
                {

                    user user = JsonSerializer.Deserialize<user>(currentUser);
                    if (user.id == id)
                        textToReplace = currentUser;
                }
            }

            if (textToReplace != string.Empty)
            {
                string text = await System.IO.File.ReadAllTextAsync("M:/webAPI/MyFirstWebApiSite/user.txt");
                text = text.Replace(textToReplace, JsonSerializer.Serialize(u));
                await System.IO.File.WriteAllTextAsync("M:/webAPI/MyFirstWebApiSite/user.txt", text);
            }






        }
    }
