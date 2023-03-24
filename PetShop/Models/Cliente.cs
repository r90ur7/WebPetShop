using System.ComponentModel;

namespace PetShop.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [DisplayName("Nome do Cliente")]
        public string Nome { get; set; }
        public ICollection<Consulta> Consultas { get; set; }

    }
}
