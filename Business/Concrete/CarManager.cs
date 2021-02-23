using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

            using (NorthwindContext context = new NorthwindContext())
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
    }
}
