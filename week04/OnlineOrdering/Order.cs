using System;

public class Order
{
    List<Product> _productsList = new List<Product>();
    List<Customer> _customerList = new List<Customer>();
    private double totalCost = 0;
    private double productCost = 0;
    private int shippingCost = 0;

    public Order()
    {
        // Console.WriteLine("Making Order");
    }
    
    public void GetWholeOrder()
    {
        PackingLabel();
        Console.WriteLine("Ship to:");
        Console.WriteLine(ShippingLabel());
        totalCost = productCost + shippingCost;
        Console.WriteLine("Price of Order: $" + totalCost);
    }

    public void AddProduct(Product product)
    {
        _productsList.Add(product);
    }
    public void AddCustomer(Customer customer)
    {
        _customerList.Add(customer);
    }

    public void PackingLabel()
    {
        foreach (Product product in _productsList)
        {
            Console.WriteLine(product.PackingLabel());
            productCost += product.TotalCost();
        }
    }
    public string ShippingLabel()
    {
        // List the name and address of the customer
        string wholeAddress = "";
        foreach (Customer customer in _customerList)
        {
            wholeAddress = customer.ShippingLabel();
            if (customer.LiveCountry())
            {
                shippingCost = 5;
            }
            else
            {
                shippingCost = 35;
            }
        }
        return wholeAddress;
    }
}