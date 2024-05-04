using StoreManagement.Entities;
using StoreManagement.Data;
using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace StoreManagement.Data
{
    public class Product_Data
    {

        public static Product[] ReadListProduct()
        {
            Product[] listProducts;
            string[] lines;
            string[] product;
            int productNumber = 0;

            const string path = "\\Files\\Product.txt";
            string? dir = System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().Location);
            string filepath = dir + path;
            StreamReader file = new StreamReader(filepath);
            lines = file.ReadToEnd().Split(new char[] { '\n' });
            file.Close();

            for (int i = 0; i < lines.Length; i++)
            {
                product = lines[i].Split(",");
                if (!string.IsNullOrEmpty(product[0]))
                {
                    productNumber++;
                }
            }

            listProducts = new Product[productNumber];

            for (int i = 0; i < productNumber; i++)
            {
                product = lines[i].Split(",");
                if (!string.IsNullOrEmpty(product[0]))
                {
                    listProducts[i].Id = int.Parse(product[0]);
                    listProducts[i].Name = product[1];
                    listProducts[i].ExpiredDate = product[2];
                    listProducts[i].Company = product[3];
                    listProducts[i].ManufactureDate = product[4];
                    listProducts[i].Category = product[5];
                    listProducts[i].Price = int.Parse(product[6]);
                }
            }

            return listProducts;
        }

        public static void SaveProducts(string path, Product[] listProducts)
        {
            string? dir = System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().Location);
            string filepath = dir + path;
            StreamWriter file = new StreamWriter(filepath);
            string productId;
            string productPrice;
            string line;
            for (int i = 0; i < listProducts.Length; i++)
            {
                productId = listProducts[i].Id.ToString();
                productPrice = listProducts[i].Price.ToString();
                line = productId + "," + listProducts[i].Name + "," + listProducts[i].ExpiredDate + "," + listProducts[i].Company + "," + listProducts[i].ManufactureDate + "," + listProducts[i].Category + "," + productPrice;
                file.WriteLine(line);
            }
            file.Close();
        }
    }
}
