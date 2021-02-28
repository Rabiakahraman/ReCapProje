using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleIU
{
    class Program
    {
        static void Main(string[] args)
        {
             CarTest();
            //BrandTest();

        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }
       

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("--------KİRALIK ARABA LİSTESİ--------");
            }
                

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(" Arabanın Modeli : " + car.Description +
                    "\n Arabanın Üretim Yılı :  " + car.ModelYear +
                    "\n Ararabanın Günlük Kira Fiyatı :  " + car.DailyPrice +
                    "\n----------------------------------------");
            }
        }
    }
}
