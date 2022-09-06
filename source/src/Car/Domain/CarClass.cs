namespace CarRent.Car.Domain
{
    using CarRent.Common.Domain;

    public class CarClass : Entity, IAggregateRoot
    {
        public Guid Id { get; }
        public string Name { get; }
        public decimal DailyPrice { get; }

        public CarClass()
        {    
        }
    }
}
