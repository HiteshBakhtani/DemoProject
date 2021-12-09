using DemoProject.Data;
using DemoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Services
{
    public class DashboardService
    {
  
        public IEnumerable<ApplicationModel> GetAllapplication(ApplicationDbContext context)
        {

            return context.Applications.OrderBy(x=>x.Name).ToList();
        }

        public ApplicationModel GetapplicationByID(ApplicationDbContext context, int ID)
        {

            return context.Applications.Find(ID);
        }

        public IEnumerable<ApplicationModel> Searchapplication(ApplicationDbContext context, string searchTerm)
        {
            var applications = context.Applications.AsQueryable();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                applications = applications.Where(a => a.Name.ToLower().Contains(searchTerm.ToLower()));
            }

            return applications.ToList();
        }

        public bool Saveapplication(ApplicationDbContext context, ApplicationModel application)
        {

            context.Applications.Add(application);

            return context.SaveChanges() > 0;
        }

        public bool Updateapplication(ApplicationDbContext context, ApplicationModel application)
        {
            context.Applications.Update(application);

            return context.SaveChanges() > 0;
        }

        public bool Deleteapplication(ApplicationDbContext context, ApplicationModel application)
        {
            context.Applications.Remove(application);

            return context.SaveChanges() > 0;
        }

    }
}
