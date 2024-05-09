namespace StoreManagement.Entities
{
    public struct Item
    {
        public int InvoiceId;
        public Product Product;
        public int Quantity;
    }

    public struct Invoice
    {
        public int Id;
        public Item[] Items;
        public string Date;
    }
}
