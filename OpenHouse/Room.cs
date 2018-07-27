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

        public Room()
        {
            int items = Rond.Next(5);
            for(int j = 0; j < items; j++)
            {
                Furniture item = new Furniture();
                item.SetAge(Rond.Next(6));
                item.SetComfy(Rond.Next(2));
                item.SetType(Rond.Next(6));
                item.SetColor(Rond.Next(6));
                Items.Add(item);

            }

        }
        public void SetName(int number)
        {
            switch (number)
            {
                case (1):
                    {
                        Name = "Kitchen";
                        break;
                    }
                case (2):
                    Name = "Attic";
                    break;

                case (3):
                    Name= "Dining Room";
                    break;
                
                case (4):
                    Name = "Master Bed Room";
                    break;
                
                case (5):
                    Name = "Master Bathroom";
                    break;
                
                case (6):
                    Name = "Basement";
                    break;
                
                    

                default:
                    break;
            }
        }
    }
}
