public class Product
{
    private string name;
    private string productId;
    private decimal price;
    private int quantity;

    public Product(string name, string productId, decimal price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public decimal RetrieveTotalCost()
    {
        return price * quantity;
    }

    public string RetrieveName()
    {
        return name;
    }

    public string RetrieveProductId()
    {
        return productId;
    }
}
