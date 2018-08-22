
namespace OpenHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Realtor realtor = new Realtor("Graygray");
            House house = new House();
            realtor.ShowHouse(house);
        }

    }
}
