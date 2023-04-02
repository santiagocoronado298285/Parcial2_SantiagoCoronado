using System.ComponentModel.DataAnnotations;

namespace AppBoleteria.DAL.Entity
{
    public class Tickets
    {
        [Key]
        [Required]
        public int Guid { get; set; }


        [Display(Name = "Fecha de uso Boleta")]
        public DateTime UseDate { get; set; }

        [Required]
        public bool IsUse { get; set; }
        [Required]
        public string EntranceGate { get; set; }

    }
}
