using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingLot.Models
{
    public class Vehicle
    {
        public int id { get; set; }
        public required string brand { get; set; }
        public required string model { get; set; }
        public required string color { get; set; }
        public required string plate { get; set; }
        public required string type { get; set; }
        public bool isParked { get; set; } = true;
        public required DateTime inputDate { get; set; } = DateTime.Now;
        public DateTime outputDate { get; set; }
        public required int companyId { get; set; }

    }
}
