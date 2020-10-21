using System;
using System.Collections.Generic;
using Lambda_Delegates_LINQ.Entities;
using Lambda_Delegates_LINQ.Services;

namespace Course_Parte2
{
    delegate float BinaryNumericOperation(float x, float y);
    delegate void BinaryNumericOperator(float x, float y);
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> produtos = new List<Product>();
            produtos.Add(new Product("TV", 900.00f));
            produtos.Add(new Product("Notebook", 1200.00f));
            produtos.Add(new Product("Tablet", 450.00f));
            produtos.Add(new Product("Mouse", 35.70f));
            produtos.Add(new Product("HD Case", 80.90f));
            

            //Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            produtos.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach(Product p in produtos)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("---------------------------------------------");
            float a = 10;
            float b = 22;
            BinaryNumericOperation op = CalculationService.Min;

            float result = op.Invoke(a, b);
            Console.WriteLine(result);

            Console.WriteLine("---------------------------------------------");
            float m = 20;
            float n = 15;
            BinaryNumericOperator oper = CalculationService2.ShowSum;
            oper += CalculationService2.ShowMax;
            oper.Invoke(m, n);

            //ACTION
            Console.WriteLine("\nACTION");
            produtos.ForEach(UpdatePrice);
            foreach(Product p in produtos)
            {
                Console.WriteLine(p);
            }

            //PREDICATE
            Console.WriteLine("\nPREDICATE");
            produtos.RemoveAll(ProductTest);
            foreach(Product p in produtos)
            {
                Console.WriteLine(p);
            }

        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.00;
        }

        public static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1f;
        }

    }
}
