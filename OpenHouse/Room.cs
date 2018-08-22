using System;
using System.Collections.Generic;

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

            int items = Rond.Next(1, 5);
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
            for (int i = 0; i < Items.Count; i++)
            {
                Console.WriteLine("A " + Items[i].Type + " ");
                Console.WriteLine("It is " + Items[i].Age + " years old.");
                Console.WriteLine("Its color is " + Items[i].Color + ".");
                Console.WriteLine($"The {Items[i].Type} is {(Items[i].IsComfortable ? "" : "un")}comfortable.");

                if (i + 1 != Items.Count)
                    Console.WriteLine("\nThe next item is:");

                Console.ReadLine();
            }
        }
    }
}
