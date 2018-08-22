using System;
using System.Collections.Generic;
using System.Text;

namespace OpenHouse
{
    class Realtor
    {
        public string Name { get; set; }

        public Realtor(string name)
        {
            Name = name;
        }

        public string GetResponse(string question)
        {
            Console.WriteLine(question);
            string response = Console.ReadLine();
            while (String.IsNullOrWhiteSpace(response))
            {
                Console.WriteLine("Please enter an actual value for the question.\n" + question);
                response = Console.ReadLine();
            }
            return response;
        }
        public bool GetYesNo(string question)
        {
            string response = GetResponse(question).ToUpper();
            while (!(response.Equals("YES")) && !(response.Equals("NO")))
            {
                response = GetResponse("Please enter yes or no. " + question).ToUpper();
            }
            return response == "YES";
        }
        public void ShowHouse(House house)
        {
            Console.WriteLine("Welcome to our open house!");
            Console.WriteLine($"My name is {Name}.");

            string name = GetResponse("What is your name?");
            Console.WriteLine($"Welcome, {name}!");

            foreach(Room room in house.Rooms)
            {
                if (GetYesNo("Do you want to see the: " + room.Name))
                {
                    room.ShowItems();
                }
            }
            Console.WriteLine("Have a wonderful day");
        }
    }
}
