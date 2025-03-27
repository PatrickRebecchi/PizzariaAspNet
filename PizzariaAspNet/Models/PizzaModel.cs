using System.ComponentModel.DataAnnotations;

namespace PizzariaAspNet.Models
{
    public class PizzaModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Valor invalido")]
        public string Sabor { get; set; } = string.Empty;
        [Required]
        public string Capa { get; set; } = string.Empty;
        [Required(ErrorMessage = "Valor invalido")]
        public string Descricao { get; set; } = string.Empty;
        [Range(0.1, double.MaxValue, ErrorMessage = "O valor deve ser maior que zero")]
        public double Valor { get; set; }
    }
}
