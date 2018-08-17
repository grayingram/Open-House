using System;
using System.Collections.Generic;
using System.Text;

namespace OpenHouse
{
    class Room
    {
        public string Name { get; set; }
        public List<Furniture> Items { get; set; } = new List<Furniture>();
        public Random Rond = new Random();

        public static string[] Rooms = { "Kitchen", "Attic", "Dining Room", "Master Bedroom", "Master Bathroom", "Basement", "Storage" };

        public Room(string name)
        {
            Name = name;

            int items = Rond.Next(5);
            for (int j = 0; j < items; j++)
            {
                Furniture item = new Furniture();
                item.SetAge(Rond.Next(6));
                item.SetComfy(Rond.Next(2));
                item.SetType(Rond.Next(6));
                item.SetColor(Rond.Next(6));

                Items.Add(item);
            }

        }
        public void ShowItems()
        {
            Console.WriteLine("The " + Name + " has many items including:");
            foreach (Furniture item in Items)
            {
                Console.WriteLine("A " + item.Type + " ");
                Console.WriteLine("It is " + item.Age + " years old.");
                Console.WriteLine("Its color is " + item.Color + " .");
                Console.WriteLine("The status of it being comfortable is " + item.IsComfortable);
                Console.WriteLine("The next item is");
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
