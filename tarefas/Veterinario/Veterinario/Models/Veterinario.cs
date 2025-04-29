using System.ComponentModel.DataAnnotations;
namespace Veterinario.Models
{
    public class Veterinario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Especialidade { get; set; }
    }
}
