using System.Collections;
using System.ComponentModel;

namespace PetShop.Models
{
    public class Consulta
    {
        [DisplayName("Protocolo")]
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public string? Atividade { get; set; }
        public DateTime Data { get; set; }
        public ICollection<Cliente> Clientes { get; set;}
        public ICollection<Funcionario> Funcionarios { get; set;}
        public ICollection<Estoque> Estoques { get; set;}

    }
}
