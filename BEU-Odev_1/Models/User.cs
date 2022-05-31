using System.ComponentModel.DataAnnotations;

namespace BEU_Odev_1.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; } 
        [Required]  
        public string Name { get; set; }    
        [Required]
        public string Surname { get; set; }
        public string Email { get; set; }   
        public string Password { get; set; }
        [Required]
        public bool IsActive { get; set; }  

        public DateTime CreatedDate { get; set; }   
    }
}
