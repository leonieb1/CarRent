namespace CarRent.Car.Domain
{
    using CarRent.Common.Domain;

    public class Car : Entity, IAggregateRoot
    {
        public Guid Id { get; }
        public string CarNumber { get; }
        public CarClass CarClass { get; }
        public string Brand { get; }
        public string Type { get; }
    }
}
