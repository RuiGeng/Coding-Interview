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
            productList.Add(new Product(14, @"Tofu", "Produce", 23.25, 35));
            productList.Add(new Product(15, @"Genen Shouyu", "Condiments", 15.5, 39));
            productList.Add(new Product(16, @"Pavlova", "Confections", 17.45, 29));
            productList.Add(new Product(17, @"Alice Mutton", "Meat/Poultry", 39, 0));
            productList.Add(new Product(18, @"Carnarvon Tigers", "Seafood", 62.5, 42));
            productList.Add(new Product(19, @"Teatime Chocolate Biscuits", "Confections", 9.2, 25));
            productList.Add(new Product(20, @"Sir Rodney's Marmalade", "Confections", 81, 40));
            productList.Add(new Product(21, @"Sir Rodney's Scones", "Confections", 10, 3));
            productList.Add(new Product(22, @"Gustaf's Knäckebröd", "Grains/Cereals", 21, 104));
            productList.Add(new Product(23, @"Tunnbröd", "Grains/Cereals", 9, 61));
            productList.Add(new Product(24, @"Guaraná Fantástica", "Beverages", 4.5, 20));
            productList.Add(new Product(25, @"NuNuCa Nuß-Nougat-Creme", "Confections", 14, 76));
            productList.Add(new Product(26, @"Gumbär Gummibärchen", "Confections", 31.23, 15));
            productList.Add(new Product(27, @"Schoggi Schokolade", "Confections", 43.9, 49));
            productList.Add(new Product(28, @"Rössle Sauerkraut", "Produce", 45.6, 26));
            productList.Add(new Product(29, @"Thüringer Rostbratwurst", "Meat/Poultry", 123.79, 0));
            productList.Add(new Product(30, @"Nord-Ost Matjeshering", "Seafood", 25.89, 10));
            productList.Add(new Product(31, @"Gorgonzola Telino", "Dairy Products", 12.5, 0));
            productList.Add(new Product(32, @"Mascarpone Fabioli", "Dairy Products", 32, 9));
            productList.Add(new Product(33, @"Geitost", "Dairy Products", 2.5, 112));
            productList.Add(new Product(34, @"Sasquatch Ale", "Beverages", 14, 111));
            productList.Add(new Product(35, @"Steeleye Stout", "Beverages", 18, 20));
            productList.Add(new Product(36, @"Inlagd Sill", "Seafood", 19, 112));
            productList.Add(new Product(37, @"Gravad lax", "Seafood", 26, 11));
            productList.Add(new Product(38, @"Côte de Blaye", "Beverages", 263.5, 17));
            productList.Add(new Product(39, @"Chartreuse verte", "Beverages", 18, 69));
            productList.Add(new Product(40, @"Boston Crab Meat", "Seafood", 18.4, 123));
            productList.Add(new Product(41, @"Jack's New England Clam Chowder", "Seafood", 9.65, 85));
            productList.Add(new Product(42, @"Singaporean Hokkien Fried Mee", "Grains/Cereals", 14, 26));
            productList.Add(new Product(43, @"Ipoh Coffee", "Beverages", 46, 17));
            productList.Add(new Product(44, @"Gula Malacca", "Condiments", 19.45, 27));
            productList.Add(new Product(45, @"Rogede sild", "Seafood", 9.5, 5));
            productList.Add(new Product(46, @"Spegesild", "Seafood", 12, 95));
            productList.Add(new Product(47, @"Zaanse koeken", "Confections", 9.5, 36));
            productList.Add(new Product(48, @"Chocolade", "Confections", 12.75, 15));
            productList.Add(new Product(49, @"Maxilaku", "Confections", 20, 10));
            productList.Add(new Product(50, @"Valkoinen suklaa", "Confections", 16.25, 65));
            productList.Add(new Product(51, @"Manjimup Dried Apples", "Produce", 53, 20));
            productList.Add(new Product(52, @"Filo Mix", "Grains/Cereals", 7, 38));
            productList.Add(new Product(53, @"Perth Pasties", "Meat/Poultry", 32.8, 0));
            productList.Add(new Product(54, @"Tourtière", "Meat/Poultry", 7.45, 21));
            productList.Add(new Product(55, @"Pâté chinois", "Meat/Poultry", 24, 115));
            productList.Add(new Product(56, @"Gnocchi di nonna Alice", "Grains/Cereals", 38, 21));
            productList.Add(new Product(57, @"Ravioli Angelo", "Grains/Cereals", 19.5, 36));
            productList.Add(new Product(58, @"Escargots de Bourgogne", "Seafood", 13.25, 62));
            productList.Add(new Product(59, @"Raclette Courdavault", "Dairy Products", 55, 79));
            productList.Add(new Product(60, @"Camembert Pierrot", "Dairy Products", 34, 19));
            productList.Add(new Product(61, @"Sirop d'érable", "Condiments", 28.5, 113));
            productList.Add(new Product(62, @"Tarte au sucre", "Confections", 49.3, 17));
            productList.Add(new Product(63, @"Vegie-spread", "Condiments", 43.9, 24));
            productList.Add(new Product(64, @"Wimmers gute Semmelknödel", "Grains/Cereals", 33.25, 22));
            productList.Add(new Product(65, @"Louisiana Fiery Hot Pepper Sauce", "Condiments", 21.05, 76));
            productList.Add(new Product(66, @"Louisiana Hot Spiced Okra", "Condiments", 17, 4));
            productList.Add(new Product(67, @"Laughing Lumberjack Lager", "Beverages", 14, 52));
            productList.Add(new Product(68, @"Scottish Longbreads", "Confections", 12.5, 6));
            productList.Add(new Product(69, @"Gudbrandsdalsost", "Dairy Products", 36, 26));
            productList.Add(new Product(70, @"Outback Lager", "Beverages", 15, 15));
            productList.Add(new Product(71, @"Flotemysost", "Dairy Products", 21.5, 26));
            productList.Add(new Product(72, @"Mozzarella di Giovanni", "Dairy Products", 34.8, 14));
            productList.Add(new Product(73, @"Röd Kaviar", "Seafood", 15, 101));
            productList.Add(new Product(74, @"Longlife Tofu", "Produce", 10, 4));
            productList.Add(new Product(75, @"Rhönbräu Klosterbier", "Beverages", 7.75, 125));
            productList.Add(new Product(76, @"Lakkalikööri", "Beverages", 18, 57));
            productList.Add(new Product(77, @"Original Frankfurter grüne Soße", "Condiments", 13, 32));

            return productList;
        }
    }
}