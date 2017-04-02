using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _04.ReDirectory
{
    public class Products
    {

        private static string path = "AciveProducts.txt";
        private static SortedDictionary<string, Dictionary<string, List<decimal>>> productsDict
            = new SortedDictionary<string, Dictionary<string, List<decimal>>>();

        public static void Main()
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }

            var lines = File.ReadAllLines(path);

            foreach (var line in lines)
            {
                var currentLine = line.Split(' ');
                var productName = currentLine[1];
                var productType = currentLine[0];
                var productPrice = decimal.Parse(currentLine[2]);
                var productQuantity = decimal.Parse(currentLine[3]);
                
                FillDictionary(productName, productType, productPrice, productQuantity);
            }

            var inputProducts = File.ReadAllLines("../../inputProducts.txt");
            var salesDict = new Dictionary<string, decimal>();

            foreach (var product in inputProducts)
            {
                var currentProduct = product.Split(' ');

                if (currentProduct[0] == "exit")
                {
                    return;
                }
                else if (currentProduct[0] == "sales")
                {
                    SalesProducts(salesDict);
                }
                else if (currentProduct[0] == "analyze")
                {
                    var fileInfo = new FileInfo(path);

                    if (fileInfo.Length == 0)
                    {
                        Console.WriteLine("No products stocked");
                    }
                    else
                    {
                        lines = File.ReadAllLines(path);

                        foreach (var line in lines)
                        {
                            var currentLine = line.Split(' ');
                            var productName = currentLine[1];
                            var productType = currentLine[0];
                            var productPrice = decimal.Parse(currentLine[2]);
                            var productQuantity = decimal.Parse(currentLine[3]);

                            Console.WriteLine($"{productType}, Product: {productName}\r\nPrice: ${productPrice}, Amount Left: {productQuantity}");
                        }
                    }
                }
                else if (currentProduct[0] == "stock")
                {
                    StockProducts();
                }
                else
                {
                    GetProducts(currentProduct);
                }
            }
        }

        private static void GetProducts(string[] currentProduct)
        {
            var productName = currentProduct[0];
            var productType = currentProduct[1];
            var productPrice = decimal.Parse(currentProduct[2]);
            var productQuantity = decimal.Parse(currentProduct[3]);

            FillDictionary(productName, productType, productPrice, productQuantity);
        }

        private static void FillDictionary(string productName, string productType, decimal productPrice, decimal productQuantity)
        {
            if (!productsDict.ContainsKey(productType))
            {
                productsDict.Add(productType, new Dictionary<string, List<decimal>>());
            }
            if (!productsDict[productType].ContainsKey(productName))
            {
                productsDict[productType].Add(productName, new List<decimal>());
            }

            productsDict[productType][productName] = new List<decimal> { productPrice, productQuantity };
        }

        private static void SalesProducts(Dictionary<string, decimal> salesDict)
        {
            decimal currentTypeSum = 0;

            foreach (var type in productsDict)
            {
                foreach (var name in type.Value)
                {
                    var price = name.Value[0];
                    var quantity = name.Value[1];

                    currentTypeSum += price * quantity;
                }

                salesDict.Add(type.Key, currentTypeSum);
                currentTypeSum = 0;
            }

            foreach (var type in salesDict.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{type.Key}: ${type.Value:f2}");
            }

            salesDict.Clear();
        }

        private static void StockProducts()
        {
            File.WriteAllText(path, string.Empty);
            File.Create(path).Close();

            foreach (var type in productsDict)
            {
                foreach (var name in type.Value)
                {
                    var price = name.Value[0];
                    var quantity = name.Value[1];
                    
                    File.AppendAllLines(path, new[] { $"{type.Key} {name.Key} {price} {quantity}" });
                }
            }
        }
    }
}