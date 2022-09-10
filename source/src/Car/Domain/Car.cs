namespace CarRent.Car.Domain
{
    using CarRent.Common.Domain;

    public class Car : Entity, IAggregateRoot
    {
        public Guid Id { get; set; }
        public string CarNumber { get; set; }
        public CarClass CarClass { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
    }
}
