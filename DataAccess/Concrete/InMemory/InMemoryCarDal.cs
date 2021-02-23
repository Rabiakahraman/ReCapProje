using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car> {
                new Car { CarId=1 , BrandId =1 , ColorId = 1 , DailyPrice = 450 , Description="BMW" , ModelYear=2011},
                new Car { CarId=2 , BrandId =1 , ColorId = 2 , DailyPrice = 550 , Description="Mercedes" , ModelYear=2016},
                new Car { CarId=3 , BrandId =2 , ColorId = 1 , DailyPrice = 475 , Description="Audi" , ModelYear=2015},
                new Car { CarId=4 , BrandId =2 , ColorId = 3 , DailyPrice = 650 , Description="Fıat" , ModelYear=2020},
                new Car { CarId=5 , BrandId =3 , ColorId = 2 , DailyPrice = 675 , Description="Hyundai" , ModelYear=2020}
            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = carToDelete = _car.SingleOrDefault(c => c.CarId == car.CarId);
            _car.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByCarId(int carId)
        {
            return _car.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = carToUpdate = _car.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
