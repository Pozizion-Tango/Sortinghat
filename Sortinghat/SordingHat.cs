using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sortinghat
{
    internal class SordingHat
    {
        int lol = 0;//don't mind this one
        Random rnd = new Random();

        private List<string> students = new List<string>();
        private List<string> gryffindor = new List<string>();
        private List<string> hufflepuff = new List<string>();
        private List<string> ravenclaw = new List<string>();
        private List<string> slytherin = new List<string>();

        public List<string> Students
        {
            get { return students; }
            set { students = value; }
        }
        public List<string> Gryffindor
        {
            get { return gryffindor; }   
            set { gryffindor = value; }  
        }
        public List<string> Hufflepuff
        {
            get { return hufflepuff; }
            set { hufflepuff = value; }
        }
        public List<string> Ravenclaw
        {
            get { return ravenclaw; }
            set { ravenclaw = value; }
        }
        public List<string> Slytherin
        {
            get { return slytherin; }
            set { slytherin = value; }
        }
        public void Status()//Status of all houses, to show what names are already in the houses.
        {
            Console.WriteLine("Gryffindor household =");
            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine((String.Join(", ", this.Gryffindor))); Console.ResetColor();
            Console.WriteLine("Hufflepuff household =");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine((String.Join(", ", this.Hufflepuff))); Console.ResetColor();
            Console.WriteLine("Ravenclaw household =");
            Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine((String.Join(", ", this.Ravenclaw))); Console.ResetColor();
            Console.WriteLine("Slytherin household =");
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine((String.Join(", ", this.Slytherin))); Console.ResetColor();
        }
        public string StudentIdentity(string name)//Checks the name to see if it's used or not
        {
            
            if (name == "null")//This is just a little joke since "null" will be denyed
            {
                Console.WriteLine("'Very Funny' but i can also be funny you know?");
                Console.ReadKey();
                lol = lol + 1;
                return "Small pp "+lol.ToString() ;//but why deny them for that right? Let's give them a fitting name
            }
            else if (students.Contains(name) || name == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;  Console.WriteLine("Name unavailable, or Student already have a household!"); Console.ResetColor();
                return "null";//Well the student is already in a household. So we return "null" so they cannot proceed in the system.
            }
            else
            {
                return name;//I don't see a problem with your name, let it proceed
            }
        }
        public void House(string name)
        {
            students.Add(name);
            int housenumber = rnd.Next(1, 5);//It can either be 1 of 4 houses, let's see what you get by random chance
            if (housenumber == 1)//Gryffindor
            {
                Console.Write("Welcome! ");
                Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(name); Console.ResetColor();
                Console.WriteLine(" to the house of 'GRYFFINDOR'! ");
                gryffindor.Add(name);
            }
            else if (housenumber == 2)//Hufflepuff
            {
                Console.Write("Welcome! ");
                Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(name); Console.ResetColor();
                Console.WriteLine(" to the house of 'HUFFLEPUFF'! ");
                hufflepuff.Add(name);
            }
            else if (housenumber == 3)//Ravenclaw
            {
                Console.Write("Welcome! ");
                Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(name); Console.ResetColor();
                Console.WriteLine(" to the house of 'RAVENCLAW'! ");
                ravenclaw.Add(name);
            }
            else//Slytherin
            {
                Console.Write("Welcome! ");
                Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(name); Console.ResetColor();
                Console.WriteLine(" to the house of 'SLYTHERIN'! ");
                slytherin.Add(name);
            }
            for (int i = 0; i < 4; i++)//Just take a few seconds to read it, before resetting the program
            {
                Console.Write(". ");
                Thread.Sleep(500);
            }
            Console.WriteLine(". ");
            Console.Clear();
        }

    }
}
