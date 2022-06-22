using System.Collections.Generic;
using The7Backend.Models;

namespace The7Backend.ViewModels
{
    public class HomeVM
    {
        public Slider sliders { get; set; }
        public IEnumerable<Service>services { get; set; }
        public IEnumerable<Blog>blogs { get; set; }
        public IEnumerable<Team>teams { get; set; }
    }
}
