using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace The7Backend.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Image { get; set; }
        [Required]
        [NotMapped]
        public IFormFile Photo { get; set; }
        public string Title { get; set; }
        public DateTime Time { get; set; }
        public string Profession { get; set; }
        public string Desc { get; set; }
    }
}
