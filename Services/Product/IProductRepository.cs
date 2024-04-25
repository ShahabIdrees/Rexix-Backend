using RexixBackend.DTOs;
namespace RexixBackend.Services.Product
{
    public interface IProductRepository
    {
        // Add your class members here
        List<ProductDTO> GetAllProducts();
        ProductDTO GetProduct(Guid id);

        List<ProductDTO> AddProduct(ProductDTO Product);

        List<ProductDTO> UpdateProduct(Guid id, ProductDTO Product);
        List<ProductDTO> DeleteProduct(Guid id);
    }
}