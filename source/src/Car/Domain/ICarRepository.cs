namespace CarRent.Car.Domain
{
    public interface ICarRepository
    {
        Car GetByID(Guid id);
        Car GetByCarNumber(string carNumber);
        Car GetByCarName(string carName);

        // weitere sinnvolle Suchbegriffe

        void Add(Car car);
        void Update(Car car);
        void Remove(Car car);
    }
}
