using System;

namespace PersonalityTestSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            ////programm küsib kasutajal sisestada tema lemmik värvi;
            //kui kasutaja sisestab "punane", konsool kuvab "oled romantiline";
            //kui kasutaja sisestab "sinine", konsool kuvab "oled töökas";
            //kui kasutaja sisestab "roheline", konsool kuvab "oled looduse sõber";
            //kui kasutaja sisestab midagi muud, konsool kuvab "oled {userColor} ükssarvik";

            Console.WriteLine("Sisesta oma lemmikvärv");
            string userColor = Console.ReadLine().ToLower();

            switch (userColor)
            {
                case "punane": //if (userColor == "punane")
                    Console.WriteLine("Oled romantiline");
                    break;
                case "sinine": //if (userColor == "sinine")
                    Console.WriteLine("Oled töökas");
                    break;
                case "roheline": //if (userColor == "roheline")
                    Console.WriteLine("Oled looduse sõber");
                    break;
                default:
                    Console.WriteLine($"Oled {userColor} üksssarvik");
                    break;
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
