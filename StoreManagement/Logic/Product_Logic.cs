using Microsoft.AspNetCore.Http;
using StoreManagement.Data;
using StoreManagement.Entities;
using System;

namespace StoreManagement.Logic
{
    public class Product_Logic
    {
        public static Product[]? FindProductsByName(string keySearch)
        {
            Product[] listProducts = Product_Data.ReadListProduct();
            int numberOfProductsContainsKeySearch = 0;

            for (int i = 0; i < listProducts.Length; i++)
            {
                if (listProducts[i].Name.Contains(keySearch))
                {
                    numberOfProductsContainsKeySearch++;
                }
            }

            Product[]? result = new Product[numberOfProductsContainsKeySearch];
            int j = 0;
            if (numberOfProductsContainsKeySearch == 0)
            {
                result = null;
            }
            else
            {
                for (int i = 0; i < numberOfProductsContainsKeySearch; i++)
                {
                    if (listProducts[i].Name.Contains(keySearch))
                    {
                        result[j] = listProducts[i];
                        j++;
                    }
                }
            }
            return result;
        }

        public static Product[]? FindProductsById(string keySearch)
        {
            Product[] listProducts = Product_Data.ReadListProduct();
            int numberOfProductsContainsKeySearch = 0;

            for (int i = 0; i < listProducts.Length; i++)
            {
                if (listProducts[i].Id.ToString().Contains(keySearch))
                {
                    numberOfProductsContainsKeySearch++;
                }
            }

            Product[]? result = new Product[numberOfProductsContainsKeySearch];
            int j = 0;
            if (numberOfProductsContainsKeySearch == 0)
            {
                result = null;
            }
            else
            {
                for (int i = 0; i < numberOfProductsContainsKeySearch; i++)
                {
                    if (listProducts[i].Id.ToString().Contains(keySearch))
                    {
                        result[j] = listProducts[i];
                        j++;
                    }
                }
            }
            return result;
        }

        public static Product[]? FindProductsByExpireDate(string keySearch)
        {
            Product[] listProducts = Product_Data.ReadListProduct();
            int numberOfProductsContainsKeySearch = 0;

            for (int i = 0; i < listProducts.Length; i++)
            {
                if (listProducts[i].ExpiredDate.Contains(keySearch))
                {
                    numberOfProductsContainsKeySearch++;
                }
            }

            Product[]? result = new Product[numberOfProductsContainsKeySearch];
            int j = 0;
            if (numberOfProductsContainsKeySearch == 0)
            {
                result = null;
            }
            else
            {
                for (int i = 0; i < numberOfProductsContainsKeySearch; i++)
                {
                    if (listProducts[i].ExpiredDate.Contains(keySearch))
                    {
                        result[j] = listProducts[i];
                        j++;
                    }
                }
            }
            return result;
        }

        public static Product[]? FindProductsByCompany(string keySearch)
        {
            Product[] listProducts = Product_Data.ReadListProduct();
            int numberOfProductsContainsKeySearch = 0;

            for (int i = 0; i < listProducts.Length; i++)
            {
                if (listProducts[i].Company.Contains(keySearch))
                {
                    numberOfProductsContainsKeySearch++;
                }
            }

            Product[]? result = new Product[numberOfProductsContainsKeySearch];
            int j = 0;
            if (numberOfProductsContainsKeySearch == 0)
            {
                result = null;
            }
            else
            {
                for (int i = 0; i < numberOfProductsContainsKeySearch; i++)
                {
                    if (listProducts[i].Company.Contains(keySearch))
                    {
                        result[j] = listProducts[i];
                        j++;
                    }
                }
            }
            return result;
        }

        public static Product[]? FindProductsByManufactureDateId(string keySearch)
        {
            Product[] listProducts = Product_Data.ReadListProduct();
            int numberOfProductsContainsKeySearch = 0;

            for (int i = 0; i < listProducts.Length; i++)
            {
                if (listProducts[i].ManufactureDate.Contains(keySearch))
                {
                    numberOfProductsContainsKeySearch++;
                }
            }

            Product[]? result = new Product[numberOfProductsContainsKeySearch];
            int j = 0;
            if (numberOfProductsContainsKeySearch == 0)
            {
                result = null;
            }
            else
            {
                for (int i = 0; i < numberOfProductsContainsKeySearch; i++)
                {
                    if (listProducts[i].ManufactureDate.Contains(keySearch))
                    {
                        result[j] = listProducts[i];
                        j++;
                    }
                }
            }
            return result;
        }

        public static Product[]? FindProductsByCategory(string keySearch)
        {
            Product[] listProducts = Product_Data.ReadListProduct();
            int numberOfProductsContainsKeySearch = 0;

            for (int i = 0; i < listProducts.Length; i++)
            {
                if (listProducts[i].Category.Contains(keySearch))
                {
                    numberOfProductsContainsKeySearch++;
                }
            }

            Product[]? result = new Product[numberOfProductsContainsKeySearch];
            int j = 0;
            if (numberOfProductsContainsKeySearch == 0)
            {
                result = null;
            }
            else
            {
                for (int i = 0; i < numberOfProductsContainsKeySearch; i++)
                {
                    if (listProducts[i].Category.Contains(keySearch))
                    {
                        result[j] = listProducts[i];
                        j++;
                    }
                }
            }
            return result;
        }

        public static Product[]? FindProductsByPrice(string keySearch)
        {
            Product[] listProducts = Product_Data.ReadListProduct();
            int numberOfProductsContainsKeySearch = 0;

            for (int i = 0; i < listProducts.Length; i++)
            {
                if (listProducts[i].Price.ToString().Contains(keySearch))
                {
                    numberOfProductsContainsKeySearch++;
                }
            }

            Product[]? result = new Product[numberOfProductsContainsKeySearch];
            int j = 0;
            if (numberOfProductsContainsKeySearch == 0)
            {
                result = null;
            }
            else
            {
                for (int i = 0; i < numberOfProductsContainsKeySearch; i++)
                {
                    if (listProducts[i].Price.ToString().Contains(keySearch))
                    {
                        result[j] = listProducts[i];
                        j++;
                    }
                }
            }
            return result;
        }

        public static Product FindProductById(int productId)
        {
            Product[] listProducts = Product_Data.ReadListProduct();
            Product result = new Product();

            for (int i = 0; i < listProducts.Length; i++)
            {
                if (listProducts[i].Id.Equals(productId))
                {
                    result = listProducts[i];
                    return result;
                }
            }
            return result;
        }

        public static bool IsNotContainBlankSpaceProductId(string productId)
        {
            return productId.Contains(" ");
        }

        public static Product? EditProduct(int productId, Product newEditProduct)
        {
            Product[] listProducts = Product_Data.ReadListProduct();
            Product? result = null;

            for (int i = 0; i < listProducts.Length; i++)
            {
                if (listProducts[i].Id.Equals(productId))
                {
                    listProducts[i] = newEditProduct;
                    result = listProducts[i];
                }
            }

            const string path = "\\Files\\Product.txt";
            Product_Data.SaveProducts(path, listProducts);

            return result;
        }

        public static bool AddProduct(Product newProduct)
        {
            Product[] listProducts = Product_Data.ReadListProduct();
            Product[] newListProducts = new Product[listProducts.Length + 1];

            for (int i = 0; i < listProducts.Length; i++)
            {
                newListProducts[i] = listProducts[i];
            }
            newListProducts[listProducts.Length] = newProduct;

            const string path = "\\Files\\Product.txt";
            Product_Data.SaveProducts(path, newListProducts);

            return true;
        }

        public static bool DeleteProduct(int deleteProductId)
        {
            Product[] listProducts = Product_Data.ReadListProduct();
            Product[] newListProducts = new Product[listProducts.Length - 1];

            int j = 0;
            for (int i = 0; i < listProducts.Length; i++)
            {
                if (deleteProductId != listProducts[i].Id)
                {
                    newListProducts[j] = listProducts[i];
                    j++;
                }
            }

            const string path = "\\Files\\Product.txt";
            Product_Data.SaveProducts(path, newListProducts);

            return true;
        }


        public static bool IsNotUniqueProductId(int productId)
        {
            Product[] listProducts = Product_Data.ReadListProduct();

            for (int i = 0; i < listProducts.Length; i++)
            {
                if (productId == listProducts[i].Id)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsNotValidNumber(int isNotValidNumberd)
        {
            if (isNotValidNumberd < 0)
            {
                return true;
            }
            return false;
        }


        public static bool IsNotValidString(string S)
        {
            if(string.IsNullOrEmpty(S))
            {
                return true;
            }
            return false;
        }

        public static bool IsNotValidDateManufactureandExpire(string startDateStr, string endDateStr)
        {
            DateTime startDate = DateTime.Parse(startDateStr);
            DateTime endDate = DateTime.Parse(endDateStr);

            TimeSpan ts = endDate - startDate;

            if(ts.TotalDays < 0)
            {
                return true;
            }
            
            return false;
        }

        public static Product[] UpdateListProductsByCategory(string currentCategoryName, string newcategoryName)
        {
            Product[] listProducts = Product_Data.ReadListProduct();

            for (int i = 0; i < listProducts.Length; i++)
            {
                if (listProducts[i].Category.Trim().Equals(currentCategoryName.Trim()))
                {
                    listProducts[i].Category = newcategoryName.Trim();
                }
            }

            const string path = "\\Files\\Product.txt";
            Product_Data.SaveProducts(path, listProducts);

            return listProducts;
        }

        public static Product[] DeleteProductsByCategory(string currentCategoryName)
        {

            Product[] listProducts = Product_Data.ReadListProduct();
            Product[] newListProducts = new Product[listProducts.Length - 1];

            int j = 0;
            for (int i = 0; i < listProducts.Length; i++)
            {
                if (listProducts[i].Category != currentCategoryName)
                {
                    newListProducts[j] = listProducts[i];
                    j++;
                }
            }

            const string path = "\\Files\\Product.txt";
            Product_Data.SaveProducts(path, newListProducts);

            return listProducts;
        }
    }
}
