using System;
using System.Collections.Generic;

namespace SimpleGame.Classes
{
    static class RandomNamer
    {
        private static List<string> Names = new List<string>
        {
            "Chester",
            "Kelan",
            "Milosz",
            "Philip",
            "Gabriella",
            "Helin",
            "Domas",
            "Danny",
            "Stephen",
            "Deniz",
            "Nala",
            "Avani",
            "Ishika",
            "Emre",
            "Storm",
            "Maddie",
            "Edan",
            "Brenna",
            "Tierney",
            "Rufus",
            "Elif",
            "Ellesse",
            "Zofia",
            "Josiah",
            "Muskaan",
            "Jamie",
            "Freja",
            "Keanu",
            "Margot",
            "Adrienne",
            "Mari",
            "Shanai",
            "Bret",
            "Tahmid",
            "Bertha",
            "Zackery",
            "Delia",
            "Emmeline",
            "Matylda",
            "Emma",
            "Trey",
            "Mercedes",
            "Tammy",
            "Jordan",
            "Ronald",
            "Nathanial",
            "Caolan",
            "Trevor",
            "Lance",
            "Rhona"
        };

        public static string GetName()
        {
            var rand = new Random();
            int randomInt = rand.Next(0, Names.Count);
            string returnedName = Names[randomInt];
            Names.RemoveAt(randomInt);
            return returnedName;
        }
    }
}
