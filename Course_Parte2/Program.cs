﻿using System;
using System.Collections.Generic;
using System.Linq;
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
            /*List<Product> produtos = new List<Product>();
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
            Console.WriteLine("\nDELEGATE ACTION:");
            produtos.ForEach(p => { p.Price += p.Price * 0.10f; });
            foreach(Product p in produtos)
            {
                Console.WriteLine(p);
            }

            //FUNC
            Console.WriteLine("\nDELEGATE FUNC:");
            List<string> resultado = produtos.Select(p => p.Name.ToUpper()).ToList();
            foreach(string res in resultado)
            {
                Console.WriteLine(res);
            }

            //PREDICATE
            Console.WriteLine("\nDELEGATE PREDICATE:");
            produtos.RemoveAll(ProductTest);
            foreach(Product p in produtos)
            {
                Console.WriteLine(p);
            }*/

            //Specify the data source
            int[] numbers = new int[] { 2, 3, 4, 5, 6, 7 };

            //Define the query expression
            var ret = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

            //Execute the query
            foreach(int num in ret)
            {
                Console.WriteLine(num);
            }

        }
        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.00;
        }
    }
}
