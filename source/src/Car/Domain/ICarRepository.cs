namespace CarRent.Car.Domain
{
    using CarRent.Common.Domain;

    public interface ICarRepository : IRepository<Car>
    {
        Car GetByCarNumber(string carNumber);
        Car GetByCarName(string carName);

        // weitere sinnvolle Suchbegriffe
    }
}
