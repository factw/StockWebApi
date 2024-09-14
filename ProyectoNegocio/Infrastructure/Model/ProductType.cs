namespace ProyectoNegocio.Infrastructure.Model
{
    public class ProductType
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public ICollection<Products> Products { get; set; }
    }
}