using Domain;

namespace PriceAlerterBusiness;

public class ProductService : IProductService
{
    public Product ExtractProductFromDomain(string domain)
    {
        return new Product()
        {
            CurrentPrice = 1,
            LimitPrice = 2,
            PhotoUrl = "sdf"
        };
    }
}