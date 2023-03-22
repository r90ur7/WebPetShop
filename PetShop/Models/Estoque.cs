using System.Collections;

namespace PetShop.Models
{
    public class Estoque
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Fornecedor { get; set; }
        public int Quantidade { get; set; }
        public int Preco { get; set; }
        public DateTime Data { get; set; }
        public ICollection<Consulta>? Consultas { get; set; }
    }
}
