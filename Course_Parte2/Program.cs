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
        public static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach(T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }


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
            }

            //Specify the data source
            int[] numbers = new int[] { 2, 3, 4, 5, 6, 7 };

            //Define the query expression
            var ret = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

            //Execute the query
            foreach(int num in ret)
            {
                Console.WriteLine(num);
            }*/

            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computer and stuff", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            List<Product2> products = new List<Product2>()
            {
                new Product2() {Id = 1, Name = "Computer Dell", Price = 1100.00F, Category = c2},
                new Product2() {Id = 2, Name = "Hammer", Price = 90.00F, Category = c1},
                new Product2() {Id = 3, Name = "TV Samsung 24 polegadas", Price = 1700.00F, Category = c3},
                new Product2() {Id = 4, Name = "Notebook Microsoft i5 128GB", Price = 1300.00F, Category = c2},
                new Product2() {Id = 5, Name = "Saw", Price = 80.00F, Category = c1},
                new Product2() {Id = 6, Name = "Tablet Samsung", Price = 700.00F, Category = c2},
                new Product2() {Id = 7, Name = "Camera Go Pro", Price = 1100.00F, Category = c3},
                new Product2() {Id = 8, Name = "Printer", Price = 350.50F, Category = c3},
                new Product2() {Id = 9, Name = "MacBook Apple i5 64GB", Price = 1800.00F, Category = c2},
                new Product2() {Id = 10, Name = "Sound Bar", Price = 700.00F, Category = c3},
                new Product2() {Id = 11, Name = "Level", Price = 70.00F, Category = c1},

            };

            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0f);
            Print("TIER 1 and Price < 900", r1);

            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("NAME OF PRODUCTS FROM TOOLS", r2);

            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name});
            Print("NAME OF PRODUCTS WHICH STARTS WITH THE LETTER C and anonymous object:", r3);

            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("PRODUCTS FROM THE TIER 1 ORDER BY PRICE THEN BY NAME: ", r4);

            var r5 = r4.Skip(2).Take(4);
            Print("PRODUCTS FROM THE TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4: ", r5);

            var r6 = products.FirstOrDefault();
            Console.WriteLine("First or default test 1: " + r6);

            var r7 = products.Where(p => p.Price > 4000).FirstOrDefault();
            Console.WriteLine("First or default test 2: " + r7);
            Console.WriteLine();

            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or default test 1: " + r8);

            var r9 = products.Where(p => p.Id == 300).SingleOrDefault();
            Console.WriteLine("Single or default test 2: " + r9);

        }
        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.00;
        }
    }
}
