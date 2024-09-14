using ProyectoNegocio.Infrastructure.Dtos;

namespace ProyectoNegocio.Service.Fragancy
{
    public interface IFragrancyService
    {
        Task CreateFragrancyAsync(FragrancyDTO fragrancyDto);
        Task<FragrancyDTO> GetFragrancy(int id);
    }
}
