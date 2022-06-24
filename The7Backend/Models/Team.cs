using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace The7Backend.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Image { get; set; }
        [Required]
        [NotMapped]
        public IFormFile Photo { get; set; }
        public string Author { get; set; }
        public string Profession { get; set; }

    }
}
