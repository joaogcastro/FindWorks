using System.ComponentModel.DataAnnotations;

namespace MidnightCityTheater.Models;

public class Funcionario
{
    [Key] // Indica que IdFuncionario é a chave primária
    public int IdFuncionario { get; set; }

    [Required] // Not null
    [StringLength(11)] // Define o tamanho máximo da string para 11
    public string CPF { get; set; }

    [Required] // Not null
    public string Nome { get; set; }

    public string? Email { get; set; } // Pode ser nulo

    [StringLength(11)] // Define o tamanho máximo da string para 11
    public string? Telefone { get; set; } // Pode ser nulo
}
