using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Convergr.NET.Models
{
    public class FacultyViewModels
    {
        public int Id { get; set; }
        public UniversityModels University { get; set; }
        public List<ClassModels> Class { get; set; }
        public string Name { get; set; }

    }
}