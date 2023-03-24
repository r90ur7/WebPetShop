using System.ComponentModel;

namespace PetShop.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        [DisplayName("Nome do Funcionário")]
        public string? Nome { get; set; }
        public string? Funcao { get; set; }
        public ICollection<Consulta> Consultas { get; set; }
    }
}
