using AutoMapper;
using ProyectoNegocio.Infrastructure.Dtos;
using ProyectoNegocio.Infrastructure.Model;
using ProyectoNegocio.Infrastructure.Repository;

namespace ProyectoNegocio.Service.Fragancy
{
    public class FragrancyService : IFragrancyService
    {
        private readonly IMapper _mapper;
        private readonly FragrancyRepository _repository;

        public FragrancyService(IMapper mapper, FragrancyRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task CreateFragrancyAsync(FragrancyDTO fragrancyDto)
        {
            if (fragrancyDto == null)
                throw new ArgumentNullException(nameof(fragrancyDto));

            var fragrancy = _mapper.Map<Fragrancy>(fragrancyDto);
            _repository.Add(fragrancy);
        }

        public async Task<FragrancyDTO> GetFragrancy(int id)
        {
            var fragrancy = await _repository.GetIdAsync(id);
            return _mapper.Map<FragrancyDTO>(fragrancy);
        }
    }
}
