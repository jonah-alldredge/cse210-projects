using System;

public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    public string PackingLabel()
    {
        string packingLabel = "Product: " + _name + " Id: " + _productId;
        return packingLabel;
    }

    public double TotalCost()
    {
        double totalCost = _price * _quantity;
        return totalCost;
    }
}