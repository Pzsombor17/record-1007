namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<hotel> hotels = new List<hotel>()
{
    new hotel("Danube Palace", "Budapest", "Luxury", "Danube Group", 80){PricePerNight=52000,Rating= 9.3},
    new hotel("Central Garden", "Budapest", "Standard", "City hotels",70){PricePerNight=28000,Rating= 8.4},
    new hotel("Royal Budapest", "Budapest", "Luxury", "Royal hotels", 90){PricePerNight=61000,Rating= 9.5},
    new hotel("Balaton Resort", "Siofok", "Resort", "Lake Group", 120){PricePerNight=44000,Rating= 8.8},
    new hotel("Sunset hotel", "Siofok", "Standard", "Lake Group", 65){PricePerNight=31000,Rating= 8.2},
    new hotel("Golden Beach", "Siofok", "Luxury", "Royal hotels",85){PricePerNight=57000,Rating= 9.1},
    new hotel("Forest Lodge", "Eger", "Standard", "Nature hotels", 55){PricePerNight=26000,Rating= 8.6},
    new hotel("Castle View", "Eger", "Luxury", "Royal hotels",60){PricePerNight=49000,Rating= 9.2},
};
            hotels[0].SetAvailableRooms(25);
            hotels[1].SetAvailableRooms(8);
            hotels[2].SetAvailableRooms(30);
            hotels[3].SetAvailableRooms(18);
            hotels[4].SetAvailableRooms(15);
            hotels[5].SetAvailableRooms(20);
            hotels[6].SetAvailableRooms(6);

            Console.WriteLine(hotels.Where(x=> x.Category == "Luxury").Count());
            Console.WriteLine(hotels.Sum(x=> x.GetAvailableRooms()));
            Console.WriteLine(hotels.Where(x=> x.City == "Budapest").Average(x=> x.PricePerNight));

        }
    }
}
