using System.ComponentModel.DataAnnotations;

namespace Fantasysg.Shared.Entites;

public class Country
{
    public int Id { get; set; }

    [MaxLength(100)]//pais con no mas de 100
    [Required] //para campo obligatorio
    public string Name { get; set; } = null!;
}