using System.Collections.Generic;
using System.Text;

public class Order
{
    public List<Product> Products { get; private set; }
    public Customer Customer { get; private set; }

    public Order(Customer customer)
    {
        Customer = customer;
        Products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public decimal GetTotalCost()
    {
        decimal total = 0;
        foreach (var product in Products)
        {
            total += product.GetTotalCost();
        }
        total += Customer.LivesInUSA() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var product in Products)
        {
            sb.AppendLine($"{product.Name} (ID: {product.ProductId})");
        }
        return sb.ToString();
    }

    public string GetShippingLabel()
    {
        return $"{Customer.Name}\n{Customer.Address.GetFullAddress()}";
    }
}
