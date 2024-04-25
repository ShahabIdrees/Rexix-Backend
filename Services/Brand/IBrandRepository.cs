using RexixBackend.DTOs;
namespace RexixBackend.Services.Brand
{
    public interface IBrandRepository
    {

        Task<List<BrandDTO>> GetAllBrands();
        Task<BrandDTO> GetBrand(Guid id);

        Task<List<BrandDTO>> AddBrand(BrandDTO Brand);

        Task<List<BrandDTO>> UpdateBrand(Guid id, BrandDTO Brand);
        Task<List<BrandDTO>> DeleteBrand(Guid id);
    }
}