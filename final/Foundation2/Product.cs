using System;

public class Product 
{
    private string _productName;
    private int _productId;
    private double _price;
    private int _quantity;

    public Product(string name, int id, double price, int quantity)
    {
        _productName = name;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }

    public double CalculatePrice()
    {
        double totalPrice = _price * _quantity;
        return totalPrice;
    }


    public string GetProductName()
    {
        return _productName;
    }

    public int GetProductId()
    {
        return _productId;
    }
}