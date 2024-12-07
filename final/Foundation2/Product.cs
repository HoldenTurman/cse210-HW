public class Product
{
    //Attributes
    private string _name;
    private string _productId;
    private double _pricePerUnit;
    private int _quantity;

    //Methods

    public Product(string name, string productId, double pricePerUnit, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    //Getter methods to read private Attributes
    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }

    //Calculates Cost of product
    public double GetTotalCost()
    {
        return _pricePerUnit * _quantity;
    }
}