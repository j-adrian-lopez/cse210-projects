using System;

public class Order 
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public string PackingLabel()
    {
        string packingLabel = "Product Details\n";
        foreach (Product product in _products)
        {
            int id = product.GetProductId();
            string name = product.GetProductName();
            packingLabel += $"ID# {id} - {name}\n";
        }
        return packingLabel;
    }

    public string ShippingLabel()
    {
        string shippingLabel = "Shipping Details\n"+
                               $"Customer: {_customer.GetCustomerName()}\n"+
                               $"Address: {_customer.GetAddress().GetFullAddress()}";
        return shippingLabel;
    }

    public double calculateTotalPrice()
    {
        int shippingCost;
        double totalPrice = 0;
        if (_customer.InUSA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        foreach(Product product in _products)
        {
            totalPrice += product.CalculatePrice();
        }
        return totalPrice += shippingCost;
    }

}
