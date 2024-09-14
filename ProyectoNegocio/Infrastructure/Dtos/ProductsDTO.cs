using ProyectoNegocio.Infrastructure.Model;

namespace ProyectoNegocio.Infrastructure.Dtos
{
    public class ProductsDTO
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string BarCode { get; set; }
        public int? Amount { get; set; }
        public FragrancyDTO Fragrancy { get; set; }
        public ProductTypeDTO ProductType { get; set; }
    }
}
