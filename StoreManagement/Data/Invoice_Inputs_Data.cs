using StoreManagement.Entities;
using StoreManagement.Logic;

namespace StoreManagement.Data
{
    public class Invoice_Inputs_Data
    {
        public static void SaveItemsOfInvoiceInputs(Item[] listItems)
        {
            const string path = "\\Files\\Invoice_Inputs_Items.txt";

            string? dir = System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().Location);
            string filepath = dir + path;
            StreamWriter file = new StreamWriter(filepath);
            string line;
            for (int i = 0; i < listItems.Length; i++)
            {
                line = listItems[i].InvoiceId.ToString() + "," + listItems[i].Product.Id.ToString() + "," + listItems[i].Quantity.ToString();
                file.WriteLine(line);
            }
            file.Close();
        }

        public static void SaveInvoiceInputs(Invoice[] listInvoices)
        {
            const string path = "\\Files\\Invoice_Inputs.txt";

            string? dir = System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().Location);
            string filepath = dir + path;
            StreamWriter file = new StreamWriter(filepath);
            string line;
            for (int i = 0; i < listInvoices.Length; i++)
            {
                line = listInvoices[i].Id.ToString() + "," + listInvoices[i].Date + "," + listInvoices[i].Items.Length.ToString();
                file.WriteLine(line);
            }
            file.Close();
        }

        public static Invoice[] ReadListInvoiceInputs()
        {
            Invoice[] listInvoices;
            string[] lines;
            string[] invoice;
            int invoiceNumber = 0;

            const string path = "\\Files\\Invoice_Inputs.txt";
            string? dir = System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().Location);
            string filepath = dir + path;
            StreamReader file = new StreamReader(filepath);
            lines = file.ReadToEnd().Split(new char[] { '\n' });
            file.Close();

            for (int i = 0; i < lines.Length; i++)
            {
                invoice = lines[i].Split(",");
                if (!string.IsNullOrEmpty(invoice[0]))
                {
                    invoiceNumber++;
                }
            }

            listInvoices = new Invoice[invoiceNumber];
            Item[]? listItems = Invoice_Inputs_Data.ReadListItemsInvoiceInputs();

            if (listItems !=  null && listItems.Length > 0)
            {
                for (int i = 0; i < invoiceNumber; i++)
                {
                    invoice = lines[i].Split(",");
                    if (!string.IsNullOrEmpty(invoice[0]))
                    {
                        listInvoices[i].Id = int.Parse(invoice[0]);
                        listInvoices[i].Date = invoice[1];
                        listInvoices[i].Items = Invoice_Logic.FindListItemsByInvoiceId(int.Parse(invoice[0]));
                    }
                }
            }
            return listInvoices;
        }

        public static Invoice[] ReadListInvoiceSales()
        {
            Invoice[] listInvoices;
            string[] lines;
            string[] invoice;
            int invoiceNumber = 0;

            const string path = "\\Files\\Invoice_Sales.txt";
            string? dir = System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().Location);
            string filepath = dir + path;
            StreamReader file = new StreamReader(filepath);
            lines = file.ReadToEnd().Split(new char[] { '\n' });
            file.Close();

            for (int i = 0; i < lines.Length; i++)
            {
                invoice = lines[i].Split(",");
                if (!string.IsNullOrEmpty(invoice[0]))
                {
                    invoiceNumber++;
                }
            }

            listInvoices = new Invoice[invoiceNumber];
            Item[]? listItems = Invoice_Inputs_Data.ReadListItemsInvoiceSales();

            if (listItems != null && listItems.Length > 0)
            {
                for (int i = 0; i < invoiceNumber; i++)
                {
                    invoice = lines[i].Split(",");
                    if (!string.IsNullOrEmpty(invoice[0]))
                    {
                        listInvoices[i].Id = int.Parse(invoice[0]);
                        listInvoices[i].Date = invoice[1];
                        listInvoices[i].Items = Invoice_Logic.FindListItemsByInvoiceIdSales(int.Parse(invoice[0]));
                    }
                }
            }
            return listInvoices;
        }

        public static Item[] ReadListItemsInvoiceInputs()
        {
            Item[] listItems;
            string[] lines;
            string[] item;
            int itemNumber = 0;

            const string path = "\\Files\\Invoice_Inputs_Items.txt";
            string? dir = System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().Location);
            string filepath = dir + path;
            StreamReader file = new StreamReader(filepath);
            lines = file.ReadToEnd().Split(new char[] { '\n' });
            file.Close();

            for (int i = 0; i < lines.Length; i++)
            {
                item = lines[i].Split(",");
                if (!string.IsNullOrEmpty(item[0]))
                {
                    itemNumber++;
                }
            }

            listItems = new Item[itemNumber];


            for (int i = 0; i < itemNumber; i++)
            {
                item = lines[i].Split(",");
                if (!string.IsNullOrEmpty(item[0]))
                {
                    listItems[i].InvoiceId = int.Parse(item[0]);
                    listItems[i].Quantity = int.Parse(item[2]);
                    listItems[i].Product = Product_Logic.FindProductById(int.Parse(item[1]));
                }
            }

            return listItems;
        }
        public static Item[] ReadListItemsInvoiceSales()
        {
            Item[] listItems;
            string[] lines;
            string[] item;
            int itemNumber = 0;

            const string path = "\\Files\\Invoice_Sales_Items.txt";
            string? dir = System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().Location);
            string filepath = dir + path;
            StreamReader file = new StreamReader(filepath);
            lines = file.ReadToEnd().Split(new char[] { '\n' });
            file.Close();

            for (int i = 0; i < lines.Length; i++)
            {
                item = lines[i].Split(",");
                if (!string.IsNullOrEmpty(item[0]))
                {
                    itemNumber++;
                }
            }

            listItems = new Item[itemNumber];


            for (int i = 0; i < itemNumber; i++)
            {
                item = lines[i].Split(",");
                if (!string.IsNullOrEmpty(item[0]))
                {
                    listItems[i].InvoiceId = int.Parse(item[0]);
                    listItems[i].Quantity = int.Parse(item[2]);
                    listItems[i].Product = Product_Logic.FindProductById(int.Parse(item[1]));
                }
            }

            return listItems;
        }

        public static void SaveItemsOfInvoiceInputsSales(Item[] listItems)
        {
            const string path = "\\Files\\Invoice_Sales_Items.txt";

            string? dir = System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().Location);
            string filepath = dir + path;
            StreamWriter file = new StreamWriter(filepath);
            string line;
            for (int i = 0; i < listItems.Length; i++)
            {
                line = listItems[i].InvoiceId.ToString() + "," + listItems[i].Product.Id.ToString() + "," + listItems[i].Quantity.ToString();
                file.WriteLine(line);
            }
            file.Close();
        }

        public static void SaveInvoiceInputsSales(Invoice[] listInvoices)
        {
            const string path = "\\Files\\Invoice_Sales.txt";

            string? dir = System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().Location);
            string filepath = dir + path;
            StreamWriter file = new StreamWriter(filepath);
            string line;
            for (int i = 0; i < listInvoices.Length; i++)
            {
                line = listInvoices[i].Id.ToString() + "," + listInvoices[i].Date + "," + listInvoices[i].Items.Length.ToString();
                file.WriteLine(line);
            }
            file.Close();
        }
    }
}
