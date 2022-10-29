using Casting_Home.Models;
using Service.Helpers.Extensions;
using System;

namespace Casting_Home
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework
            //AccountController account1 = new AccountController();
            //account1.Login();

            //int num = 4;
            //if (num < 0)
            //{
            //    Console.WriteLine("Duzgun eded daxil edin");
            //    return;
            //}
            //Console.WriteLine(num.CalculateFactorial());
            #endregion

            //int num1 = 50;
            //byte num2 = (byte)num1;
            //Console.WriteLine(num2);

            //Eagle eagle1 = new Eagle();
            //Animal animal = eagle1;
            //Animal t1 = new Eagle();

            //string a = "50";
            //object b = a;
            //string c = b.ToString();



            //Console.WriteLine(b);


            Animal shark1 = new Shark();
            Animal eagle1 = new Eagle();
            //Animal shark2 = new Shark();
            //Shark shark3 = (Shark)shark2;

            object[] objects = { 1, 2, "P414", shark1 };

            foreach (var item in objects)
            {
                ((Animal)item).Name = "test";
                Console.WriteLine(((Animal)item).Name);
            }
        }
    }
}
