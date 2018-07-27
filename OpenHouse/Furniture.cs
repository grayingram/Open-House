using System;
using System.Collections.Generic;
using System.Text;

namespace OpenHouse
{
    class Furniture
    {
        public int Age { get; set; } = 1;
        public string Type { get; set; }
        public bool IsComfortable { get; set; }
        public string Color { get; set; }
        public Random Turn { get; set; } = new Random();

        public void SetAge(int num)
        {
            switch (num)
            {
                case (1):
                    {
                        Age = Turn.Next(1, 10);
                        break;

                    }
                case (2):
                    Age = Turn.Next(3, 15);
                    break;

                case (3):
                    Age = Turn.Next(4, 20);
                    break;

                case (4):
                    Age = Turn.Next(5, 25);
                    break;
                case (5):
                    Age = Turn.Next(6, 30);
                    break;


                default:
                    break;
            }
        }
        public void SetComfy(int num)
        {
            switch (num)
            {
                case (1):
                    {
                        IsComfortable = true;
                        break;

                    }
                case (2):
                    {
                        IsComfortable = false;
                        break;
                    }


            }
        }
        public void SetType(int num)
        {
            switch (num)
            {
                case (1):
                    {
                        Type = "Chair";
                        break;

                    }
                case (2):
                    Type = "Bed";
                    break;

                case (3):
                    Type = "Table";
                    break;
                case (4):
                    Type = "Couch";
                    break;
                case (5):
                    Type = "Lamp";
                    break;
                default:
                    Type = "Stool";
                    break;
            }
        }
        public void SetColor(int num)
        {
            switch (num)
            {
                case (1):
                    {
                        Color = "Brown";
                        break;

                    }
                case (2):
                    Color = "Black";
                    break;

                case (3):
                    Color = "Tan";
                    break;
                case (4):
                    Color = "Blue";
                    break;
                case (5):
                    Color = "Green";
                    break;
                default:
                    Color = "Yellow";
                    break;
            }
        }
    }
}
