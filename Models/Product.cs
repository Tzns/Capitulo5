using System;

namespace LanguageFeatures.Models
{
    public class Product
    {
        public String Name { get; set; }
        public Decimal? Price { get; set; }
        public static Product[] GetProducts()
        {
            Product kayak = new Product
            {
                Name = "Kayak",
                Price = 275m
            };
            Product lifejacket = new Product
            {
                Name = "Lifejack",
                Price = 48.95m
            };
            return new Product[] { kayak, lifejacket, null };
        }
    }
}