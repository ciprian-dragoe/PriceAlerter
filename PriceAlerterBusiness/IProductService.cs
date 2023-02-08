using Domain;

namespace PriceAlerterBusiness;

public interface IProductService
{
    Product ExtractProductFromDomain(string domain);
}