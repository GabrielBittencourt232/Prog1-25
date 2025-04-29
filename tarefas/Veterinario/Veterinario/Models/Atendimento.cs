using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Veterinario.Models
{
    public class Atendimento
    {
        public int Id { get; set; }
        public int AnimalId { get; set; }
        public Animal Animal { get; set; }
        public int VeterinarioId { get; set; }

        [ForeignKey("VeterinarioId")]
            public Veterinario Veterinario { get; set; }

        public DateTime DataAtendimento { get; set; }
        public string Procedimento { get; set; }
    }
}
