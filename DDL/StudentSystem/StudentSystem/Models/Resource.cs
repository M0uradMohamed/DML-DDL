using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class Resource
    {
        public int ResourceId { get; set; }
        public string Name { get; set; } = null!;
        public string Url { get; set; }
        public ResourceType ResourceType { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
    public enum ResourceType
    {
        Video=1,
        Presentation=2,
        Document=3,
        Other=4
    }
}
