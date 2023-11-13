using System.ComponentModel.DataAnnotations;

namespace UnimarLife.Domain.NovaPasta
{
    public abstract class User
    {
        public int Id { get; set; }
        [Required]
        public string? NomeCompleto { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Senha { get; set; }
        public int? Pontos { get; set; }

        public bool Ativo { get; set; }

    }
}