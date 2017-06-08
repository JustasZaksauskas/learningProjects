using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<User> users = new List<User>();

            var user = new User();
            user.Name = "Justas";
            user.Surname = "Zaksauskas";
            user.Age = 26;
            user.Role = Role.admin;

            var user2 = new User();
            user2.Name = "Algis";
            user2.Surname = "Ramanauskas";
            user2.Age = 42;
            user2.Role = Role.editor;


            users.Add(user);
            users.Add(user2);


            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine($"Name: {users[i].Name} Surname: {users[i].Surname} Age: {users[i].Age} Is Adult: {users[i].IsAdult} Role: {users[i].Role}");
                Console.WriteLine(string.Concat(users[i].Name + " " + users[i].Surname) + " Age: " + users[i].Age);
            }

            foreach (var userr in users)
            {
                Console.WriteLine(userr.Name);
            }

            Console.ReadLine();

        }
        
        //Sukurti tokias klases: Kompiuteris, Procesorius, RAM, IODevice,Screen,GraphicCard
        //klase kompiuteris turi tureti properties : (Procesorius, ram , iodivice, graphiccard) ir metodus (Turn on, turnoff, sleep)
        //klase ram turi tureti properties (gamintojas, memorysize)
        //klase iodevice turi tureti properties (type, gamintojas)
        //klase screen turi tureti properties (gamintojas, raiska, dydis)
        //klase graphincard turi tureti propterties (gamintojas, pavadinimas, dydis)

        //sukurti klase KompiuteriuParduotuve, turi tureti metoda Pasidetikompiuteriisandeli,,,pasimti is sandelio, parodyti sandelio sarasa

        //sukurti 3 kompiuterius, 1 kompiuteriu parduotuve, i kompiuteriu parduotuves sandeli padeti 3 kompiuterius ir pasimti viena is sandelio

        

    }
}
