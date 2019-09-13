using System.Linq;
namespace myStore.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}