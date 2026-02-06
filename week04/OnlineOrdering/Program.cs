using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        List<Order> _orderList = new List<Order>();

        Address _address = new Address("123 Brooklyn Heights Blvd", "New York", "NY", "USA");
        Order _order1 = new Order();
        _orderList.Add(_order1);
        _order1.AddProduct(new Product("Sketchbook", "A101", 12.50, 2));
        _order1.AddProduct(new Product("Graphite Pencil Set", "B202", 8.99, 1));
        _order1.AddCustomer(new Customer("Miles Morales", _address));

        // Order 2
        Address _address2 = new Address("Dalagatan 46", "Stockholm", "Stockholm County", "Sweden");
        Order _order2 = new Order();
        _orderList.Add(_order2);
        _order2.AddProduct(new Product("Winter Parka", "C303", 145, 1));
        _order2.AddProduct(new Product("Wool Mittens", "D404", 25.5, 2));
        _order2.AddCustomer(new Customer("Astrid Lindgren", _address2));

        foreach (Order order in _orderList)
        {
            order.GetWholeOrder();
        }
    }
}