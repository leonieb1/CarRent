using CarRent.Car.Domain;
using CarRent.Repository;

namespace CarRent.Car.Infrastructure.Persistence
{
    public class CarClassRepository : ICarClassRepository
    {
        public void Add(CarClass car)
        {
            using (var context = new CarRentContext())
            {
                context.Add(new Repository.Tables.CarClass()
                {
                    CarClassID = car.Id.ToString(),
                    Name = car.Name,
                    DailyPrice = car.DailyPrice
                }) ;
                context.SaveChanges();
            }
        }

        public CarClass GetByCarClassName(string carClassName)
        {
            using (var context = new CarRentContext())
            {
                foreach (var item in context.CarClasses)
                {
                    if (item.Name == carClassName)
                    {
                        return new Car.Domain.CarClass()
                        {
                            Id = Guid.Parse(item.CarClassID),
                            Name = item.Name,
                            DailyPrice = item.DailyPrice
                        };
                    }
                }
                return null;
            }
        }

        public CarClass GetByID(Guid id)
        {
            using (var context = new CarRentContext())
            {
                foreach (var item in context.CarClasses)
                {
                    if (item.CarClassID == id.ToString())
                    {
                        return new CarClass()
                        {
                            Id = Guid.Parse(item.CarClassID),
                            Name = item.Name,
                            DailyPrice = item.DailyPrice
                        };
                    }
                }
                return null;
            }
        }

        public void Remove(CarClass car)
        {
            using (var context = new CarRentContext())
            {
                foreach (var item in context.CarClasses)
                {
                    if (item.CarClassID == car.Id.ToString())
                    {
                        context.CarClasses.Remove(item);
                    }
                }
                context.SaveChanges();
            }
        }

        public void Update(CarClass car)
        {
            using (var context = new CarRentContext())
            {
                foreach (var item in context.CarClasses)
                {
                    if (item.CarClassID == car.Id.ToString())
                    {
                        item.Name = car.Name;
                        item.DailyPrice = car.DailyPrice;
                    }
                }
                context.SaveChanges();
            }
        }
    }
}
