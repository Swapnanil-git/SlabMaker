using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SlabMaker.Models
{
    [Table("Orders", Schema = "SM")]
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        [MaxLength(1)]
        public string Grade { get; set; } = string.Empty; // Grade: A, B, or C

        [Required]
        public double Length { get; set; } // Length in meters

        [Required]
        public double Width { get; set; } // Width in meters

        [Required]
        public double Thickness { get; set; } // Thickness in meters

        [Required]
        public int Quantity { get; set; }

        [Required]
        public double Weight { get; set; } // Calculated weight in kg
        
        [Required]
        [MaxLength(50)]
        public string Status { get; set; } = "Open";
        
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime ReceivedDate { get; set; }
    }
}