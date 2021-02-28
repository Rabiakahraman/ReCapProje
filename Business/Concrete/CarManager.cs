using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System.Linq;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void Add(Car car)
        {

            using (RentACarContext context = new RentACarContext())
            {
                if (car.DailyPrice > 0 && context.Brands.SingleOrDefault(b => b.BrandId == car.BrandId).BrandName.Length > 2)
                {
                    _carDal.Add(car);
                }
                else
                {
                    Console.WriteLine("Ekleme işleminiz yapılamamıştır.");
                }

            }
        }
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
        public List<Car> GetCarByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByDailyPrice(decimal minPrice, decimal maxPrice)
        {
            return _carDal.GetAll(c => c.DailyPrice >= minPrice && c.DailyPrice <= maxPrice);
        }
    }
}
