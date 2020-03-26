using System;
using System.Collections.Generic;
using System.Diagnostics;
using IntuitionTest.Question1;
using IntuitionTest.Question2;
using IntuitionTest.Question3;

namespace IntuitionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUESTION 1 SOLUTION");
            Console.WriteLine("___________");
            Question1Solution();

            Console.WriteLine("");
            Console.WriteLine("QUESTION 2 SOLUTION");
            Console.WriteLine("___________");
            Question2Solution();

            Console.WriteLine("");
            Console.WriteLine("QUESTION 3 SOLUTION");
            Console.WriteLine("___________");
            Question3Solution();


            //delay
            Console.ReadLine();
        }
        
        public static void Question1Solution()
        {
            IEmployeeManager employeeManager = new EmployeeManager();

            Stopwatch sw = new Stopwatch();
            sw.Start();

            Random random = new Random();
            for (int i = 0; i < 1000; i++)
            {
                int employeeID = random.Next();
                Employee employee = new Employee(employeeID, "first name " + employeeID.ToString(), "last Name " + employeeID.ToString());
                employeeManager.AddEmployee(employee);

                employee = employeeManager.GetEmployee(employeeID);
                if (employee == null) throw new Exception("Employee not found");
                Console.WriteLine(employee.EmployeeID);

                var employeeArray = employeeManager.GetOrderedEmployeeArray();
                Console.WriteLine(employeeArray.Length);
                Console.WriteLine("___________");
            }

            sw.Stop();
            Console.WriteLine(sw.Elapsed);
        }

        public static void Question2Solution()
        {
            ITransport car = new Car();
            ITransport truck = new Truck();
            ITransport train = new Train();

            TransportManager.DoSomeLogic(car);
            TransportManager.DoSomeLogic(truck);
            TransportManager.DoSomeLogic(train);

        }

        public static void Question3Solution()
        {
            List<Product> products = new List<Product>();

            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                products.Add(new Product()
                {
                    Id = Guid.NewGuid(),
                    Price = random.NextDouble()*random.Next(1, 100)
                });
            }

            ILocalizationInfo us = new Us();
            ILocalizationInfo ca = new Canada();

            ICartTotal cart = new CartTotal();
            Console.WriteLine("US: "+cart.Calculate(products, us));
            Console.WriteLine("CA: " + cart.Calculate(products, ca));

        }
    }
}
