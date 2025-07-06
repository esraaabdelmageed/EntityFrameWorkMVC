using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameWorkMVC1.Models
{
    public class Company
    {
        [Key]  //define key ---> id
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //not so important because it is identity by default (key)
        public  int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string? Address { get; set; }
    }
}
