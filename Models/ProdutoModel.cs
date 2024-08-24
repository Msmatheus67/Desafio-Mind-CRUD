using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Desafio_Mind_CRUD.Models
{
    public class ProdutoModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Nome { get; set;} = string.Empty;
        [Required]
        [MaxLength(60)]
        public string Descricao { get; set;} = string.Empty;
        [Required]
        [Precision(16,2)]
        public decimal Preco { get; set; } = decimal.Zero;
    }
}
