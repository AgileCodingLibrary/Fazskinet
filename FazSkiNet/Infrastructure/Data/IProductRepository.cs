using Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public interface IProductRepository
    {

        Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync();
        Task<Product> GetProductByIdAsync(int id);
        Task<IReadOnlyList<Product>> GetProductsAsync();
        Task<IReadOnlyList<ProductType>> GetProductTypesAsync();
    }
}