namespace ParkingLot.Models
{
    public class Company
    {
        public int id { get; set; }
        public required string name { get; set; }
        public required string address { get; set; }
        public required string telephone { get; set; }
        public required int motorcycleSpaces { get; set; }
        public required int carSpaces { get; set; }
    }
}
