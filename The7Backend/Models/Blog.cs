using System;

namespace The7Backend.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public DateTime Time { get; set; }
        public string Profession { get; set; }
        public string Desc { get; set; }
    }
}
