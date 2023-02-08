using PriceAlerterBusiness;

namespace PriceAlerter.IoC;

public abstract class BaseLoadServices : ILoadServices
{
    protected void LoadCommonServices(WebApplicationBuilder builder)
    {
        builder.Services.AddControllersWithViews();
        builder.Services.AddTransient<IProductService, ProductService>();
    }


    public virtual void Load(WebApplicationBuilder builder)
    {
        LoadCommonServices(builder);
    }
}