using System.ComponentModel.DataAnnotations;

namespace ProyectoNegocio.Infrastructure.Model
{
    public class Products
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string BarCode { get; set; }
        public int? Amount { get; set; }

        public int FragrancyId { get; set; }
        public Fragrancy Fragrancy { get; set; }

        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }

    }
}