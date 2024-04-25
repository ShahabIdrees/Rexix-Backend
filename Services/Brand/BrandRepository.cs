using Microsoft.EntityFrameworkCore;
using RexixBackend.Data;
using RexixBackend.DTOs;

namespace RexixBackend.Services.Brand
{
    public class BrandRepository : IBrandRepository
    {

        private readonly AppDbContext _context;
        public BrandRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<BrandDTO>> GetAllBrands()
        {
            var brands = await _context.Brand.ToListAsync();
            return brands;
        }

        public async Task<List<BrandDTO>> AddBrand(BrandDTO Brand)
        {
            throw new NotImplementedException();
        }

        public async Task<List<BrandDTO>> DeleteBrand(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<BrandDTO> GetBrand(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<BrandDTO>> UpdateBrand(Guid id, BrandDTO Brand)
        {
            throw new NotImplementedException();
        }
    }
}