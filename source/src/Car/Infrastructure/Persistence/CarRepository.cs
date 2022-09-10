using CarRent.Car.Domain;
using CarRent.Car.Infrastructure.Persistence;
using CarRent.Repository;

namespace CarRent.Car.Persistence
{
    public class CarRepository : ICarRepository
    {
        private readonly ICarClassRepository _carClassRepository;
        public CarRepository()
        {
            _carClassRepository = new CarClassRepository();
        }
        public void Add(Domain.Car car)
        {
            using (var context = new CarRentContext())
            {
                context.Add(new Repository.Tables.Car()
                {
                    CarID = car.Id.ToString(),
                    CarNumber = car.CarNumber,
                    CarClassID = car.CarClass.Id.ToString(),
                    Brand = car.Brand,
                    Type = car.Type
                });
                context.SaveChanges();
            }
        }

        public Domain.Car GetByCarNumber(string carNumber)
        {
            using (var context = new CarRentContext())
            {
                foreach (var item in context.Cars)
                {
                    if (item.CarNumber == carNumber)
                    {
                        return new Car.Domain.Car()
                        {
                            Id = Guid.Parse(item.CarID),
                            CarNumber = item.CarNumber,
                            CarClass = _carClassRepository.GetByID(Guid.Parse(item.CarClassID)),
                            Brand = item.Brand,
                            Type= item.Type
                        };
                    }
                }
                return null;
            }
        }

        public Domain.Car GetByID(Guid id)
        {
            using (var context = new CarRentContext())
            {
                foreach (var item in context.Cars)
                {
                    if (item.CarID == id.ToString())
                    {
                        return new Car.Domain.Car()
                        {
                            Id = Guid.Parse(item.CarID),
                            CarNumber = item.CarNumber,
                            CarClass = _carClassRepository.GetByID(Guid.Parse(item.CarClassID)),
                            Brand = item.Brand,
                            Type = item.Type
                        };
                    }
                }
                return null;
            }
        }

        public void Remove(Domain.Car car)
        {
            using (var context = new CarRentContext())
            {
                foreach(var item in context.Cars)
                {
                    if (item.CarID == car.Id.ToString())
                    {
                        context.Cars.Remove(item);
                    }
                }
                context.SaveChanges();
            }
        }

        public void Update(Domain.Car car)
        {
            using (var context = new CarRentContext())
            {
                foreach (var item in context.Cars)
                {
                    if (item.CarID == car.Id.ToString())
                    {
                        item.CarNumber = car.CarNumber;
                        item.CarClassID = car.CarClass.Id.ToString();
                        item.Brand = car.Brand;
                        item.Type = car.Type;
                    }
                }
                context.SaveChanges();
            }
        }
    }
}
