﻿using System;
using System.Collections.Generic;
using Lambda_Delegates_LINQ.Entities;
using Lambda_Delegates_LINQ.Services;

namespace Course_Parte2
{
    delegate float BinaryNumericOperation(float x, float y);
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> produtos = new List<Product>();
            produtos.Add(new Product("TV", 900.00f));
            produtos.Add(new Product("Notebook", 1200.00f));
            produtos.Add(new Product("Tablet", 450.00f));
            produtos.Add(new Product("Mouse", 35.70f));

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
        }

    }
}
