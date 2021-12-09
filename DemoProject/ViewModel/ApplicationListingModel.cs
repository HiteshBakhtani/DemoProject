using DemoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.ViewModel
{
    public class ApplicationListingModel
    {
        public IEnumerable<ApplicationModel> Applications { get; set; }
        public string SearchTerm { get; set; }
    }
}
