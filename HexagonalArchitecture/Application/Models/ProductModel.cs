namespace Application.Models;

public sealed class ProductModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public void UpdatePrice(decimal price)
    {
        if (price < 0)
        {
            throw new Exception("Price 0 dan küçük olamaz");
        }

        Price = price;
    }
}