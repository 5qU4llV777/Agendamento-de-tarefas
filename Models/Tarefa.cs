using System.ComponentModel.DataAnnotations;

namespace TrilhaApiDesafio.Models
{
    public class Tarefa
    {
        [Key]
        public int Id { get; set; }
        
        [Required] // ← Adicione isso
        public string Titulo { get; set; } = string.Empty; // ← Ou inicialize
        
        [Required] // ← Adicione isso  
        public string Descricao { get; set; } = string.Empty; // ← Ou inicialize
        
        public DateTime Data { get; set; }
        public EnumStatusTarefa Status { get; set; }
    }
}