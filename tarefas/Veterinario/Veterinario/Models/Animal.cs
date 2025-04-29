using System.ComponentModel.DataAnnotations;

namespace Veterinario.Models
{
    public class Animal
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public string Especie { get; set; }
        public string Raca { get; set; }
        public string Dono { get; set; }
    }
}
