using Microsoft.AspNetCore.Http;
using StoreManagement.Data;
using StoreManagement.Entities;
using System;
using System.Data;
using System.Reflection.Metadata.Ecma335;

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
                for (int i = 0; i < listProducts.Length; i++)
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
                for (int i = 0; i < listProducts.Length; i++)
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
                for (int i = 0; i < listProducts.Length; i++)
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
                for (int i = 0; i < listProducts.Length; i++)
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
                for (int i = 0; i < listProducts.Length; i++)
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
                for (int i = 0; i < listProducts.Length; i++)
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
                for (int i = 0; i < listProducts.Length; i++)
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

        public static Product FindProductByIdSale(int productId)
        {
            Product[] listProducts = Product_Logic.FindProductForSale();
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

        public static Product[] FindInputProduct()
        { 

            Invoice[] inputInvoice = Invoice_Inputs_Data.ReadListInvoiceInputs();
            int existProduct = 0;
            for (int i = 0; i < inputInvoice.Length; i++)
            {
                for (int j = 0; j < inputInvoice[i].Items.Length; j++)
                {
                    existProduct++;
                }
            }

            Product[] inputProducts = new Product[existProduct];

            int n = 0;
            for (int i = 0; i < inputInvoice.Length; i++)
            {
                for (int j = 0; j < inputInvoice[i].Items.Length; j++)
                {
                    inputProducts[n] = inputInvoice[i].Items[j].Product;
                    n++;
                }
            }

            return inputProducts;
        }

        public static Product[] FindSalesProduct()
        {

            Invoice[] Invoice = Invoice_Inputs_Data.ReadListInvoiceSales();
            int existProduct = 0;
            for (int i = 0; i < Invoice.Length; i++)
            {
                for (int j = 0; j < Invoice[i].Items.Length; j++)
                {
                    existProduct++;
                }
            }

            Product[] Products = new Product[existProduct];

            int n = 0;
            for (int i = 0; i < Invoice.Length; i++)
            {
                for (int j = 0; j < Invoice[i].Items.Length; j++)
                {
                    Products[n] = Invoice[i].Items[j].Product;
                    n++;
                }
            }

            return Products;
        }

        public static Product[] FindInventoryProduct()
        {

            Item[] inputItem = Invoice_Inputs_Data.ReadListItemsInvoiceInputs();
            Item[] outputItem = Invoice_Inputs_Data.ReadListItemsInvoiceSales();
            int inputProductIdNumber = 0;

            for (int k = 0; k < inputItem.Length; k++)
            {
                inputProductIdNumber++;
            }

            int[] inputProductId = new int[inputProductIdNumber];

            for (int k = 0; k < inputItem.Length; k++)
            {
                inputProductId[k] = inputItem[k].Product.Id;
            }

            inputProductId = inputProductId.Distinct().ToArray();

            int[] inputProductQuantity = new int[inputProductId.Length];

            for (int i = 0; i < inputProductQuantity.Length; i++)
            {
                for (int k = 0; k < inputItem.Length; k++)
                {
                    if (inputItem[k].Product.Id == inputProductId[i])
                    {
                        inputProductQuantity[i] = inputProductQuantity[i] + inputItem[k].Quantity;
                    }
                }
            }

            for (int k = 0; k < inputProductId.Length; k++)
            {
                for (int i = 0; i < outputItem.Length; i++)
                {
                    if (outputItem[i].Product.Id == inputProductId[k])
                    {
                        inputProductQuantity[k] = inputProductQuantity[k] - outputItem[i].Quantity;
                    }
                }
            }

            Product[] list = new Product[inputProductId.Length];
            Product[] listProduct = Product_Data.ReadListProduct();
            for (int k = 0; k < inputProductId.Length; k++)
            {
                for (int i = 0; i < listProduct.Length; i++)
                {
                    if (listProduct[i].Id == inputProductId[k])
                    {
                        list[k] = listProduct[i];
                    }
                }
            }

            return list;
        }

        public static int[] FindInventoryProductQuantity()
        {

            Item[] inputItem = Invoice_Inputs_Data.ReadListItemsInvoiceInputs();
            Item[] outputItem = Invoice_Inputs_Data.ReadListItemsInvoiceSales();
            int inputProductIdNumber = 0;

            for (int k = 0; k < inputItem.Length; k++)
            {
                inputProductIdNumber++;
            }

            int[] inputProductId = new int[inputProductIdNumber];

            for (int k = 0; k < inputItem.Length; k++)
            {
                inputProductId[k] = inputItem[k].Product.Id;
            }

            inputProductId = inputProductId.Distinct().ToArray();

            int[] inputProductQuantity = new int[inputProductId.Length];

            for (int i = 0; i < inputProductQuantity.Length; i++)
            {
                for (int k = 0; k < inputItem.Length; k++)
                {
                    if (inputItem[k].Product.Id == inputProductId[i])
                    {
                        inputProductQuantity[i] = inputProductQuantity[i] + inputItem[k].Quantity;
                    }
                }
            }

            for (int k = 0; k < inputProductId.Length; k++)
            {
                for (int i = 0; i < outputItem.Length; i++)
                {
                    if (outputItem[i].Product.Id == inputProductId[k])
                    {
                        inputProductQuantity[k] = inputProductQuantity[k] - outputItem[i].Quantity;
                    }
                }
            }

            Product[] list = new Product[inputProductId.Length];
            Product[] listProduct = Product_Data.ReadListProduct();
            for (int k = 0; k < inputProductId.Length; k++)
            {
                for (int i = 0; i < listProduct.Length; i++)
                {
                    if (listProduct[i].Id == inputProductId[k])
                    {
                        list[k] = listProduct[i];
                    }
                }
            }

            return inputProductQuantity;

        }

        public static Product[] FindOutDateProduct()
        {
            DateTime today = DateTime.Today;
            Product[] inventoryProduct = Product_Logic.FindInventoryProduct();
            int existProduct = 0;
            for (int i = 0; i < inventoryProduct.Length; i++)
            {
                DateTime productDate = DateTime.Parse(inventoryProduct[i].ExpiredDate);
                TimeSpan ts = today - productDate;
                if (ts.TotalDays >= 0)
                {
                    existProduct++;
                }
            }

            Product[] inputProducts = new Product[existProduct];

            int n = 0;
            for (int i = 0; i < inventoryProduct.Length; i++)
            {
                DateTime productDate = DateTime.Parse(inventoryProduct[i].ExpiredDate);
                TimeSpan ts = today - productDate;
                if (ts.TotalDays >= 0)
                {
                    inputProducts[n] = inventoryProduct[i];
                    n++;
                }
            }

            inputProducts = inputProducts.Distinct().ToArray();

            return inputProducts;
        }

        public static int[] FindQuantityByProductId()
        {
            Product[] inputProducts = Product_Logic.FindInventoryProduct();
            Product[] outDateProduct = Product_Logic.FindOutDateProduct();
            int[] outDateQuantity = new int[outDateProduct.Length];
            int[] inputQuantity = Product_Logic.FindInventoryProductQuantity();

            for (int k = 0; k < outDateProduct.Length; k++)
            {
                for (int j = 0; j < inputProducts.Length; j++)
                {
                    if (inputProducts[j].Id == outDateProduct[k].Id)
                    {
                        outDateQuantity[k] = outDateQuantity[k] + inputQuantity[j];
                    }
                }
            }

            return outDateQuantity;
        }

        public static Product[] FindProductForSale()
        {

            Product[] inventoryProduct = Product_Logic.FindInventoryProduct();
            Product[] outDateProduct = Product_Logic.FindOutDateProduct();

            int notSaleProductNumber = 0;
            for (int k = 0; k < outDateProduct.Length; k++)
            {
                for (int i = 0; i < inventoryProduct.Length; i++)
                {
                    if (inventoryProduct[i].Id == outDateProduct[k].Id)
                    {
                        notSaleProductNumber++;
                    }
                }
            }
            
            int[] productIdTempt = new int[notSaleProductNumber];

            int n = 0;
            for (int k = 0; k < outDateProduct.Length; k++)
            {
                for (int i = 0; i < inventoryProduct.Length; i++)
                {
                    if (inventoryProduct[i].Id == outDateProduct[k].Id)
                    {
                        productIdTempt[n] = inventoryProduct[i].Id;
                        n++;
                    }
                }
            }

            int[] productId = new int[inventoryProduct.Length - notSaleProductNumber];
            int d = 0;

            for (int j = 0; j < inventoryProduct.Length; j++)
            {
                if (inventoryProduct[j].Id != productIdTempt[d])
                {
                    productId[d] = inventoryProduct[j].Id;
                    d++;
                }
            }

            Product[] list = new Product[productId.Length];
            Product[] listProduct = Product_Data.ReadListProduct();
            for (int k = 0; k < productId.Length; k++)
            {
                for (int i = 0; i < listProduct.Length; i++)
                {
                    if (listProduct[i].Id == productId[k])
                    {
                        list[k] = listProduct[i];
                    }
                }
            }

            return list;
        }
    }
}
