using System;
using System.Collections.Generic;

namespace OpenHouse
{
    class House
    {
        public House()
        {
            Random Rand = new Random();
            Rooms = new List<Room>();
            int numofRooms = Rand.Next(3, 8);
            for (int i = 0; i < numofRooms; i++)
                Rooms.Add(new Room(Room.Rooms[i]));
        }

        public string Address { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
