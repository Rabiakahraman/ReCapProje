using Business.Concrete;
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
             CarTest();
            //BrandTest();
            //ColorTest();

        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color color = new Color() { ColorId = 5, ColorName = "turuncu" };
            colorManager.Add(color);
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand1 = new Brand() { BrandId = 4, BrandName = "Rabia" };
            brandManager.Add(brand1);
            brandManager.Delete(new Brand { BrandId = 1, BrandName = "fiat" });
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }
       

        private static void CarTest()
        {
           
         
            CarManager carManager = new CarManager(new EfCarDal());
            var data = carManager.GetAll();
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

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine("--------KİRALIK ARABA LİSTESİ--------");
            //}


            //foreach (var car in carManager.GetCarDetails())
            //{
            //    Console.WriteLine(" Arabanın Modeli : " + car.Description +
             //      "\n Arabanın Üretim Yılı :  " + car.ModelYear +
            //        "\n Ararabanın Günlük Kira Fiyatı :  " + car.DailyPrice +
            //         "\n---------------");
            //   Console.WriteLine(car.Description);

        }
    }
    
}
