using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PetShop.Models
{
    public class Estoque
    {
        public int Id { get; set; }
        [DisplayName("Nome do Produto")]
        public string? Nome { get; set; }
        public string? Fornecedor { get; set; }
        public int Quantidade { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}")]
        public int Preco { get; set; }
        public DateTime Data { get; set; }
        public ICollection<Consulta> Consultas { get; set; }
    }
}
