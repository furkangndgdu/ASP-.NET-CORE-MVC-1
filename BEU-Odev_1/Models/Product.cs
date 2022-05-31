using System.ComponentModel.DataAnnotations;

namespace BEU_Odev_1.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]  
        public string Name { get; set; }    
        [Required]
        public string Description { get; set; } 
        public int Quantity { get; set; }   
        public double Price { get; set; }   
        public bool IsActive { get; set; }  
    }
}
