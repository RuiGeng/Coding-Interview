namespace LinqSamples
{
    using System.Collections.Generic;

    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public double UnitPrice { get; set; }
        public long UnitsInStock { get; set; }

        public Product(int productId, string productName, string category, double unitPrice, long unitsInStock)
        {
            ProductID = productId;
            ProductName = productName;
            Category = category;
            UnitPrice = unitPrice;
            UnitsInStock = unitsInStock;
        }

        public static List<Product> GetProductList()
        {
            List<Product> productList = new List<Product>();
            productList.Add(new Product(1, @"Chai", "Beverages", 18.0000, 39));
            productList.Add(new Product(2, @"Chang", "Beverages", 19.0000, 17));
            productList.Add(new Product(3, @"Aniseed Syrup", "Condiments", 10.0000, 13));
            productList.Add(new Product(4, @"Chef Anton's Cajun Seasoning", "Condiments", 22.0000, 53));
            productList.Add(new Product(5, @"Chef Anton's Gumbo Mix", "Condiments", 21.3500, 0));
            productList.Add(new Product(6, @"Grandma's Boysenberry Spread", "Condiments", 25.0000, 120));
            productList.Add(new Product(7, @"Uncle Bob's Organic Dried Pears", "Produce", 30.0000, 15));
            productList.Add(new Product(8, @"Northwoods Cranberry Sauce", "Condiments", 40.0000, 6));
            productList.Add(new Product(9, @"Mishi Kobe Niku", "Meat/Poultry", 97.0000, 29));
            productList.Add(new Product(10, @"Ikura", "Seafood", 31.0000, 31));
            productList.Add(new Product(11, @"Queso Cabrales", "Dairy Products", 21.0000, 22));
            productList.Add(new Product(12, @"Queso Manchego La Pastora", "Dairy Products", 38.0000, 86));
            productList.Add(new Product(13, @"Konbu", "Seafood", 6.0000, 24));



            return productList;
        }
    }


}