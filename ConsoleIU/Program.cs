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
            CarManager carManager = new CarManager(new EfCarDal());

            Console.WriteLine("--------KİRALIK ARABA LİSTESİ--------");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(" Arabanın Modeli : " + car.Description +
                    "\n Arabanın Üretim Yılı :  " + car.ModelYear +
                    "\n Ararabanın Günlük Kira Fiyatı :  " + car.DailyPrice +
                    "\n----------------------------------------");
            }
        }
    }
}
