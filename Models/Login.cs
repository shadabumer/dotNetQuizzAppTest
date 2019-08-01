using System.ComponentModel.DataAnnotations;  

namespace  quizzApp.Models {
    public class Login {
        [Required]
        [StringLength(30)]
        public string email { get; set; }

        [Required]
        [StringLength(10)]
        public string password { get; set; }
    }
}