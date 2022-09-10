namespace CarRent.Car.Domain
{
    using CarRent.Common.Domain;

    public class CarClass : Entity, IAggregateRoot
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal DailyPrice { get; set; }

        public CarClass()
        {    
        }
    }
}
