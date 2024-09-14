using System.ComponentModel.DataAnnotations;

namespace ProyectoNegocio.Infrastructure.Model
{
    public class Fragrancy
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public ICollection<Products> Products { get; set; }
    }
}