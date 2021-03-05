using Business.Concrete;
using Core;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleIU
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
                
                var result = carManager.GetCarDetails();
                if (result.Success == true)
                {
                    foreach (var car in result.Data)
                    {
                        Console.WriteLine(" Arabanın Modeli : " + car.Description +
                                 "\n Arabanın Üretim Yılı :  " + car.ModelYear +
                                 "\n Ararabanın Günlük Kira Fiyatı :  " + car.DailyPrice +
                                 "\n---------------");
                    }
                }
                else
                {
                    Console.WriteLine(result.Message);
                }
        }


    }
}
