using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(
        Customer customer,
        List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public double CalculateTotalCost()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        total += _customer.LivesInUSA()
            ? 5
            : 35;

        return total;
    }
}