using System.ComponentModel.DataAnnotations;

namespace flutterapi.Models
{
    public class user
    {
        [Key]
        public int userId { get; set; }

        [Required]
        public string name { get; set; } = "";

        [Required]
        public string address { get; set; } = "";

        


    }
}
