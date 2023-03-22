namespace PetShop.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Funcao { get; set; }
        public virtual Consulta? Consultas { get; set; }
    }
}
