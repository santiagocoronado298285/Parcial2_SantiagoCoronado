using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppBoleteria.DAL.Entity
{
    public class Ticket
    {
        [Key]
        [Required]
        
        public int Id { get; set; }

  
        [Display(Name = "Fecha de uso Boleta")]
        public DateTime UseDate { get; set; }

        [Display(Name = "Boleta usada?")]
       
        public bool IsUse { get; set; }

        [Display(Name = "Entrada al estadio")]
       
        public string EntranceGate { get; set; }

    }
}
