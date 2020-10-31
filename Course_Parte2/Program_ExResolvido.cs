using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using Lambda_Delegates_LINQ.Entities;

namespace Lambda_Delegates_LINQ
{
    class Program_ExResolvido
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            List<Product> lista = new List<Product>();
            
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] dados = sr.ReadLine().Split(",");
                        string name = dados[0];
                        float price = float.Parse(dados[1], CultureInfo.InvariantCulture);
                        lista.Add(new Product(name, price));
                    }
                }
                //Calcula o preço médio de todos os produtos do arquivo externo
                var ret = lista.Average(p => p.Price);
                Console.WriteLine("Average price: " + ret.ToString("F2", CultureInfo.InvariantCulture));

                //Calcula quais produtos tem o preco inferior ao preco médio e mostra o nome dos produtos em ordem decrescente
                var funcao = lista.Where(p => p.Price < ret).OrderByDescending(p => p.Name).Select(p => p.Name);
                foreach(string produto in funcao)
                {
                    Console.WriteLine(produto);
                }


            }catch(IOException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }
    }
}
