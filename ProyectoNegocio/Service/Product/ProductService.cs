using AutoMapper;
using ProyectoNegocio.Infrastructure.Dtos;
using ProyectoNegocio.Infrastructure.Model;
using ProyectoNegocio.Infrastructure.Repository;

namespace ProyectoNegocio.Service.Product
{
    public class ProductService : IProductService
    {
        private readonly ProductRepository _productRepositoy;
        private readonly IMapper _mapper;
        public ProductService(ProductRepository productRepositoy, IMapper mapper)
        {
            _productRepositoy = productRepositoy;
            _mapper = mapper;
        }


        public async Task CreateProductAsync(ProductsDTO productDto)
        {
            if (productDto == null)
                throw new ArgumentNullException(nameof(productDto));

            var product = _mapper.Map<Products>(productDto);

            _productRepositoy.Add(product);
        }


        public async Task<ProductsDTO> GetProductDtoByIdAsync(int productId)
        {
            var products = await _productRepositoy.GetIdAsync(productId);
            return _mapper.Map<ProductsDTO>(products);
        }

        public async Task<List<ProductsDTO>> GetProductListAsync()
        {
            var products = await _productRepositoy.GetAllAsync();
            return _mapper.Map<List<ProductsDTO>>(products);
        }
    }
}
