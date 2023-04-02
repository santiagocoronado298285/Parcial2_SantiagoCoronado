using System.ComponentModel.DataAnnotations;

namespace AppBoleteria.DAL.Entity
{
    public class Ticket
    {
        [Key]
        [Required]
        
        public int Id { get; set; }


        [Display(Name = "Fecha de uso Boleta")]
        public DateTime UseDate { get; set; }

        
        public bool IsUse { get; set; }
        
        public string EntranceGate { get; set; }

    }
}
