using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
using StoreManagement.Data;
using StoreManagement.Entities;
using System.Security.Cryptography.Xml;

namespace StoreManagement.Logic
{
    public class Invoice_Logic
    {
        public static Item[] FindListItemsByInvoiceId(int invoiceId)
        {
            Item[] listItems = Invoice_Inputs_Data.ReadListItemsInvoiceInputs();
            int j=0;

            for (int i = 0; i < listItems.Length; i++)
            {
                if (listItems[i].InvoiceId.Equals(invoiceId))
                {
                    j++;
                }
            }

            Item[] result = new Item[j];

            int k = 0;
            for (int i = 0; i < listItems.Length; i++)
            {
                if (listItems[i].InvoiceId.Equals(invoiceId))
                {
                    result[k] = listItems[i];
                    k++;
                }
            }
            return result;
        }

        public static Item[] FindListItemsByInvoiceIdSales(int invoiceId)
        {
            Item[] listItems = Invoice_Inputs_Data.ReadListItemsInvoiceSales();
            int j = 0;

            for (int i = 0; i < listItems.Length; i++)
            {
                if (listItems[i].InvoiceId.Equals(invoiceId))
                {
                    j++;
                }
            }

            Item[] result = new Item[j];

            int k = 0;
            for (int i = 0; i < listItems.Length; i++)
            {
                if (listItems[i].InvoiceId.Equals(invoiceId))
                {
                    result[k] = listItems[i];
                    k++;
                }
            }
            return result;
        }

        public static Invoice[]? FindInvoicesById(string keySearch)
        {
            Invoice[] listInvoices = Invoice_Inputs_Data.ReadListInvoiceInputs();
            int numberContainsKeySearch = 0;

            for (int i = 0; i < listInvoices.Length; i++)
            {
                if (listInvoices[i].Id.ToString().Contains(keySearch))
                {
                    numberContainsKeySearch++;
                }
            }

            Invoice[]? result = new Invoice[numberContainsKeySearch];
            int j = 0;
            if (numberContainsKeySearch == 0)
            {
                result = null;
            }
            else
            {
                for (int i = 0; i < listInvoices.Length; i++)
                {
                    if (listInvoices[i].Id.ToString().Contains(keySearch))
                    {
                        result[j] = listInvoices[i];
                        j++;
                    }
                }
            }
            return result;
        }

        public static Invoice[]? FindInvoicesByIdSales(string keySearch)
        {
            Invoice[] listInvoices = Invoice_Inputs_Data.ReadListInvoiceSales();
            int numberContainsKeySearch = 0;

            for (int i = 0; i < listInvoices.Length; i++)
            {
                if (listInvoices[i].Id.ToString().Contains(keySearch))
                {
                    numberContainsKeySearch++;
                }
            }

            Invoice[]? result = new Invoice[numberContainsKeySearch];
            int j = 0;
            if (numberContainsKeySearch == 0)
            {
                result = null;
            }
            else
            {
                for (int i = 0; i < listInvoices.Length; i++)
                {
                    if (listInvoices[i].Id.ToString().Contains(keySearch))
                    {
                        result[j] = listInvoices[i];
                        j++;
                    }
                }
            }
            return result;
        }

        public static Invoice[]? FindInvoicesByDate(string keySearch)
        {
            Invoice[] listInvoices = Invoice_Inputs_Data.ReadListInvoiceInputs();
            int numberContainsKeySearch = 0;

            for (int i = 0; i < listInvoices.Length; i++)
            {
                if (listInvoices[i].Date.Contains(keySearch))
                {
                    numberContainsKeySearch++;
                }
            }

            Invoice[]? result = new Invoice[numberContainsKeySearch];
            int j = 0;
            if (numberContainsKeySearch == 0)
            {
                result = null;
            }
            else
            {
                for (int i = 0; i < listInvoices.Length; i++)
                {
                    if (listInvoices[i].Date.ToString().Contains(keySearch))
                    {
                        result[j] = listInvoices[i];
                        j++;
                    }
                }
            }
            return result;
        }

        public static Invoice[]? FindInvoicesByDateSales(string keySearch)
        {
            Invoice[] listInvoices = Invoice_Inputs_Data.ReadListInvoiceSales();
            int numberContainsKeySearch = 0;

            for (int i = 0; i < listInvoices.Length; i++)
            {
                if (listInvoices[i].Date.Contains(keySearch))
                {
                    numberContainsKeySearch++;
                }
            }

            Invoice[]? result = new Invoice[numberContainsKeySearch];
            int j = 0;
            if (numberContainsKeySearch == 0)
            {
                result = null;
            }
            else
            {
                for (int i = 0; i < listInvoices.Length; i++)
                {
                    if (listInvoices[i].Date.ToString().Contains(keySearch))
                    {
                        result[j] = listInvoices[i];
                        j++;
                    }
                }
            }
            return result;
        }
        public static bool IsNotValidString(string S)
        {
            if (string.IsNullOrEmpty(S) || S == "0")
            {
                return true;
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

        public static bool IsNotUniqueId(int Id)
        {
            Invoice[] lists = Invoice_Inputs_Data.ReadListInvoiceInputs();

            for (int i = 0; i < lists.Length; i++)
            {
                if (Id == lists[i].Id)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsNotUniqueIdSales(int Id)
        {
            Invoice[] lists = Invoice_Inputs_Data.ReadListInvoiceSales();

            for (int i = 0; i < lists.Length; i++)
            {
                if (Id == lists[i].Id)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool AddItemsByInvoiceId(Item[] Items)
        {
            Item[] listItems = Invoice_Inputs_Data.ReadListItemsInvoiceInputs();
            Item[] newListItems = new Item[listItems.Length + Items.Length];

            for (int i = 0; i < listItems.Length; i++)
            {
                newListItems[i] = listItems[i];
            }

            int k = 0;
            for (int j = listItems.Length; j < newListItems.Length; j++)
            {
                newListItems[j] = Items[k];
                k++;
            }

            Invoice_Inputs_Data.SaveItemsOfInvoiceInputs(newListItems);
            return true;
        }

        public static bool AddInvoices(Invoice newInvoice)
        {
            Invoice[] listInvoices = Invoice_Inputs_Data.ReadListInvoiceInputs();
            Invoice[] newListInvoices = new Invoice[listInvoices.Length + 1];

            for (int i = 0; i < listInvoices.Length; i++)
            {
                newListInvoices[i] = listInvoices[i];
            }
            newListInvoices[listInvoices.Length] = newInvoice;
            Invoice_Inputs_Data.SaveInvoiceInputs(newListInvoices);

            return true;
        }

        public static bool AddItemsByInvoiceIdSales(Item[] Items)
        {
            Item[] listItems = Invoice_Inputs_Data.ReadListItemsInvoiceSales();
            Item[] newListItems = new Item[listItems.Length + Items.Length];

            for (int i = 0; i < listItems.Length; i++)
            {
                newListItems[i] = listItems[i];
            }

            int k = 0;
            for (int j = listItems.Length; j < newListItems.Length; j++)
            {
                newListItems[j] = Items[k];
                k++;
            }

            Invoice_Inputs_Data.SaveItemsOfInvoiceInputsSales(newListItems);
            return true;
        }

        public static bool AddInvoicesSales(Invoice newInvoice)
        {
            Invoice[] listInvoices = Invoice_Inputs_Data.ReadListInvoiceSales();
            Invoice[] newListInvoices = new Invoice[listInvoices.Length + 1];

            for (int i = 0; i < listInvoices.Length; i++)
            {
                newListInvoices[i] = listInvoices[i];
            }
            newListInvoices[listInvoices.Length] = newInvoice;
            Invoice_Inputs_Data.SaveInvoiceInputsSales(newListInvoices);

            return true;
        }

        public static bool EditInvoice(Invoice newInvoice, Invoice Invoice)
        {
            Invoice[] listInvoices = Invoice_Inputs_Data.ReadListInvoiceInputs();

            for (int i = 0; i < listInvoices.Length; i++)
            {
                if (Invoice.Id == listInvoices[i].Id)
                {
                    listInvoices[i] = newInvoice;
                }
            }

            Invoice_Inputs_Data.SaveInvoiceInputs(listInvoices);
            return true;
        }

        public static bool EditInvoiceSales(Invoice newInvoice, Invoice Invoice)
        {
            Invoice[] listInvoices = Invoice_Inputs_Data.ReadListInvoiceSales();

            for (int i = 0; i < listInvoices.Length; i++)
            {
                if (Invoice.Id == listInvoices[i].Id)
                {
                    listInvoices[i] = newInvoice;
                }
            }

            Invoice_Inputs_Data.SaveInvoiceInputsSales(listInvoices);
            return true;
        }
        public static bool EditItemsByInvoiceId(Item[] Items, int currentId)
        {
            int invoiceId = currentId;
            Item[] listItems = Invoice_Inputs_Data.ReadListItemsInvoiceInputs();

            int numberRemaining = 0;
            for (int i = 0; i < listItems.Length; i++)
            {
                if (listItems[i].InvoiceId != invoiceId)
                {
                    numberRemaining++;
                }
            }

            Item[] newListItems = new Item[numberRemaining];
            int k = 0;
            for (int i = 0; i < listItems.Length; i++)
            {
                if (listItems[i].InvoiceId != invoiceId) 
                {
                    newListItems[k] = listItems[i];
                    k++;  
                }
            }

            Item[] newListItemsByInvoiceId = new Item[newListItems.Length + Items.Length];

            for (int i = 0; i < newListItems.Length; i++)
            {
                newListItemsByInvoiceId[i] = newListItems[i];
            }

            int m = 0;
            for (int j = newListItems.Length; j < newListItemsByInvoiceId.Length; j++)
            {
                newListItemsByInvoiceId[j] = Items[m];
                m++;
            }

            Invoice_Inputs_Data.SaveItemsOfInvoiceInputs(newListItemsByInvoiceId);
            return true;
        }

        public static bool EditItemsByInvoiceIdSales(Item[] Items, int currentId)
        {
            int invoiceId = currentId;
            Item[] listItems = Invoice_Inputs_Data.ReadListItemsInvoiceSales();

            int numberRemaining = 0;
            for (int i = 0; i < listItems.Length; i++)
            {
                if (listItems[i].InvoiceId != invoiceId)
                {
                    numberRemaining++;
                }
            }

            Item[] newListItems = new Item[numberRemaining];
            int k = 0;
            for (int i = 0; i < listItems.Length; i++)
            {
                if (listItems[i].InvoiceId != invoiceId)
                {
                    newListItems[k] = listItems[i];
                    k++;
                }
            }

            Item[] newListItemsByInvoiceId = new Item[newListItems.Length + Items.Length];

            for (int i = 0; i < newListItems.Length; i++)
            {
                newListItemsByInvoiceId[i] = newListItems[i];
            }

            int m = 0;
            for (int j = newListItems.Length; j < newListItemsByInvoiceId.Length; j++)
            {
                newListItemsByInvoiceId[j] = Items[m];
                m++;
            }

            Invoice_Inputs_Data.SaveItemsOfInvoiceInputsSales(newListItemsByInvoiceId);
            return true;
        }

        public static Invoice FindInvoiceById(int Id)
        {
            Invoice[] listInvoices = Invoice_Inputs_Data.ReadListInvoiceInputs();
            Invoice invoice = new Invoice();
            for (int i = 0; i < listInvoices.Length; i++)
            {
                if (listInvoices[i].Id.Equals(Id)) { 
                    invoice = listInvoices[i];
                } 
            }

            return invoice;


        }

        public static Invoice FindInvoiceByIdSales(int Id)
        {
            Invoice[] listInvoices = Invoice_Inputs_Data.ReadListInvoiceSales();
            Invoice invoice = new Invoice();
            for (int i = 0; i < listInvoices.Length; i++)
            {
                if (listInvoices[i].Id.Equals(Id))
                {
                    invoice = listInvoices[i];
                }
            }

            return invoice;


        }
        public static bool DeleteInvoiceById(int invoiceId)
        {

            Invoice[] listInvoices = Invoice_Inputs_Data.ReadListInvoiceInputs();
            Invoice[] newListInvoices = new Invoice[listInvoices.Length - 1];

            int k = 0;
            for (int i = 0; i < listInvoices.Length; i++)
            {
                if(invoiceId != listInvoices[i].Id)
                {
                    newListInvoices[k] = listInvoices[i];
                    k++;
                }
            }

            Invoice_Inputs_Data.SaveInvoiceInputs(newListInvoices);

            return true;
        }

        public static bool DeleteInvoiceByIdSales(int invoiceId)
        {

            Invoice[] listInvoices = Invoice_Inputs_Data.ReadListInvoiceSales();
            Invoice[] newListInvoices = new Invoice[listInvoices.Length - 1];

            int k = 0;
            for (int i = 0; i < listInvoices.Length; i++)
            {
                if (invoiceId != listInvoices[i].Id)
                {
                    newListInvoices[k] = listInvoices[i];
                    k++;
                }
            }

            Invoice_Inputs_Data.SaveInvoiceInputsSales(newListInvoices);

            return true;
        }
        public static bool DeleteItemsByInvoiceId(Item[] Items)
        {
            int invoiceId = Items[0].InvoiceId;
            Item[] listItems = Invoice_Inputs_Data.ReadListItemsInvoiceInputs();

            int numberRemaining = 0;
            for (int i = 0; i < listItems.Length; i++)
            {
                if (listItems[i].InvoiceId != invoiceId)
                {
                    numberRemaining++;
                }
            }

            Item[] newListItems = new Item[numberRemaining];
            int k = 0;
            for (int i = 0; i < listItems.Length; i++)
            {
                if (listItems[i].InvoiceId != invoiceId)
                {
                    newListItems[k] = listItems[i];
                    k++;
                }
            }

            Invoice_Inputs_Data.SaveItemsOfInvoiceInputs(newListItems);
            return true;
        }

        public static bool DeleteItemsByInvoiceIdSales(Item[] Items)
        {
            int invoiceId = Items[0].InvoiceId;
            Item[] listItems = Invoice_Inputs_Data.ReadListItemsInvoiceSales();

            int numberRemaining = 0;
            for (int i = 0; i < listItems.Length; i++)
            {
                if (listItems[i].InvoiceId != invoiceId)
                {
                    numberRemaining++;
                }
            }

            Item[] newListItems = new Item[numberRemaining];
            int k = 0;
            for (int i = 0; i < listItems.Length; i++)
            {
                if (listItems[i].InvoiceId != invoiceId)
                {
                    newListItems[k] = listItems[i];
                    k++;
                }
            }

            Invoice_Inputs_Data.SaveItemsOfInvoiceInputsSales(newListItems);
            return true;
        }

        public static bool IsNotValidDate(string Date)
        {
            DateTime today = DateTime.Today;
            DateTime endDate = DateTime.Parse(Date);

            TimeSpan ts = today - endDate;

            if (ts.TotalDays < 0)
            {
                return true;
            }

            return false;
        }
    }
}
