using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal DetermineTotalCost()
    {
        decimal totalCost = 0;
        foreach (var product in products)
        {
            totalCost += product.RetrieveTotalCost();
        }

        totalCost += customer.LivesInUSA() ? 5 : 35;
        return totalCost;
    }

    public string RetrievePackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (var product in products)
        {
            packingLabel += $"{product.RetrieveName()} (ID: {product.RetrieveProductId()})\n";
        }
        return packingLabel;
    }

    public string RetrieveShippingLabel()
    {
        return $"Shipping Label:\n{customer.RetrieveName()}\n{customer.RetrieveAddress().RetrieveFullAddress()}";
    }
}
