namespace Domain.Products;

public class Product
{
    public Guid Id { get; private set; }
    public string Name { get; set; } = string.Empty;
    public Money Price { get; private set; }
    public Sku Sku { get; private set; }
}
