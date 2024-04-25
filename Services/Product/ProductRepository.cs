using RexixBackend.Data;
using RexixBackend.DTOs;

namespace RexixBackend.Services.Product
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;
        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }
        public List<ProductDTO> AddProduct(ProductDTO Product)
        {
            throw new NotImplementedException();
        }

        public List<ProductDTO> DeleteProduct(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<ProductDTO> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public ProductDTO GetProduct(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<ProductDTO> UpdateProduct(Guid id, ProductDTO Product)
        {
            throw new NotImplementedException();
        }
    }
}