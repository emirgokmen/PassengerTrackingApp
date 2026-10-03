namespace PassengerTrackingApp.Models
{
    public class Passenger
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string FlightNumber { get; set; } = string.Empty;
        public string ServiceType { get; set; } = string.Empty; // Örn: Tekerlekli Sandalye, Sedye
        public string Status { get; set; } = "Bekliyor"; // Bekliyor, Hizmet Verildi, İptal
    }
}