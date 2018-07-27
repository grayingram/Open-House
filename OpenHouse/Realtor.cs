using System;
using System.Collections.Generic;
using System.Text;

namespace OpenHouse
{
    class Realtor
    {
        public string Name { get; set; }
        public Random Rand { get; set; } = new Random();
        public List<Room> Rooms { get; set; } = new List<Room>();

        public Realtor()
        {
            int numofRooms = Rand.Next(7);
            for(int i = 0; i < numofRooms; i++)
            {
                Room aRoom = new Room();
                aRoom.SetName(Rand.Next(7));
                Rooms.Add(aRoom);
            }
            

        }
        public string GetResponse(string question)
        {
            Console.WriteLine(question);
            string response = Console.ReadLine();
            while (String.IsNullOrWhiteSpace(response))
            {
                Console.WriteLine("Please enter an actual value for the question\n" + question);
                response = Console.ReadLine();
            }

            return response;
        }
        public bool GetYesNo(string question)
        {
            string response = GetResponse(question);
            response = response.ToUpper();
            while (!(response.Equals("YES")) && !(response.Equals("NO")))
            {
                Console.WriteLine("Please enter yes or no.");
                response = GetResponse(question);
                response = response.ToUpper();
            }
            if (response == "YES")
            {
                return true;
            }
            return false;

        }
        public void ShowHouse()
        {
            foreach(Room room in Rooms)
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
