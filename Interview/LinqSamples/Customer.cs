using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace LinqSamples
{
    public class Customer
    {
        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public Order[] Orders { get; set; }

        public static List<Customer> GetCustomerList()
        {
            List<Customer> customerList = new List<Customer>();

            var xElement = XDocument.Load("Customers.xml").Root;

            if (xElement != null)
            {
                customerList = (
                        from e in xElement.Elements("customer")
                        select new Customer
                        {
                            CustomerId = (string)e.Element("id"),
                            CompanyName = (string)e.Element("name"),
                            Address = (string)e.Element("address"),
                            City = (string)e.Element("city"),
                            Region = (string)e.Element("region"),
                            PostalCode = (string)e.Element("postalcode"),
                            Country = (string)e.Element("country"),
                            Phone = (string)e.Element("phone"),
                            Fax = (string)e.Element("fax"),
                            Orders = (
                                    from o in e.Elements("orders").Elements("order")
                                    select new Order
                                    {
                                        OrderId = (int)o.Element("id"),
                                        OrderDate = (DateTime)o.Element("orderdate"),
                                        Total = (decimal)o.Element("total")
                                    })
                                .ToArray()
                        })
                    .ToList();
            }

            return customerList;
        }
    }
}