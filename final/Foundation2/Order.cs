
using System.Collections.Generic;

public class Order
{
    //Attributes / Create List
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer orderCustomer)
    {
        _customer = orderCustomer;
        _products = new List<Product>();
    }

    public void AddProduct(Product orderProduct)
    {
        _products.Add(orderProduct);
    }


    //Gets costs based on whether they are in USA or not
    public double GetTotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        double shippingCost = _customer.LivesInUSA() ? 5.0 : 35.0;
        return total + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += product.GetName() + " (ID: " + product.GetProductId() + ")\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return "Shipping Label:\n" + _customer.GetName() + "\n" + _customer.GetAddress().GetFullAddress();
    }
}
