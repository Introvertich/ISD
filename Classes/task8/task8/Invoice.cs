using System;

namespace task8
{
    class Invoice
    {
        public string Article { get; set; }
        public int Quantity { get; set; }
        private int account;
        private string customer;
        private string provider;
        private int price;

        public Invoice(int account, string customer, string provider, int price)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
            this.price = price;
            Article = "";
            Quantity = 0;
        }
        private double PriceWithVAT()
        {
            return price * Quantity * 1.2;
        }
        private double PriceWithoutVAT()
        {
            return (double)price * Quantity;
        }

        public override string ToString()
        {
            return "Account №" + account + "\nCustomer: " + customer + "\nProvider: " + provider + "\nProduct info:\narticle - " + Article
                + ", quantity - " + Quantity + ", price per unit - " + price + "\nTotal price without VAT: " + PriceWithoutVAT().ToString() + ", with VAT: " + PriceWithVAT().ToString();
        }
    }
}