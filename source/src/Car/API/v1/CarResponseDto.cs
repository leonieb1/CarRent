namespace CarRent.Car.API.v1
{
    using System.Text.Json.Serialization;
    public class CarResponseDto
    {
        [JsonPropertyName("car-id")]
        public Guid CarId { get; set; }
        [JsonPropertyName("car-number")]
        public string CarNumber { get; set; }
        public string Brand { get; set; }
        public string CarClass { get; set; }
        
        public string Type { get; set; }

        
    }
}
