using MessagePack;
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
        public int ClienteId { get; set; }
        public int FuncionarioId { get; set; }
        public int EstoqueId { get; set; }
        
        public virtual Cliente Clientes { get;set; }
        public virtual Estoque Estoques { get;set; }
        public virtual Funcionario Funcionarios { get;set; }

    }
}
