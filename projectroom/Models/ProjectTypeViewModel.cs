using Microsoft.AspNetCore.Mvc.Rendering;

namespace projectroom.Models
{
    public class ProjectTypeViewModel
    {
        public List<Project>? Projects { get; set; }
        public SelectList? Types { get; set; }
        public string? ProjectType { get; set; }
        public string? SearchString { get; set; }
    }
}
