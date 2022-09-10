namespace CarRent.Car.Domain
{
    using CarRent.Common.Domain;

    public interface ICarClassRepository : IRepository<CarClass>
    {
        CarClass GetByCarClassName(string carClassName);

        // weitere sinnvolle Suchbegriffe
    }
}
