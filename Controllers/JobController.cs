using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Mvc;
using TechJobPortal.Models;

namespace TechJobPortal.Controllers
{

    public class JobController : Controller
    {
        private static List<JobListing> jobListings = new List<JobListing>
        {
            new JobListing
            {
                Id = 1,
                Title = "Software Developer",
                CompanyName = "Tech Corp",
                Location = "New York, NY",
                JobType = JobType.FullTime,
                PostedDate = new System.DateTime(2025, 1, 15)
            },
            new JobListing
            {
                Id = 2,
                Title = "Frontend Developer",
                CompanyName = "Web Innovations",
                Location = "San Francisco, CA",
                JobType = JobType.Remote,
                PostedDate = new System.DateTime(2025, 2, 1)
            },
            new JobListing
            {
                Id = 3,
                Title = "Data Scientist",
                CompanyName = "Data Solutions Inc.",
                Location = "Remote",
                JobType = JobType.Contract,
                PostedDate = new System.DateTime(2025, 2, 10)
            },new JobListing
{
    Id = 4,
    Title = "Frontend Developer",
    CompanyName = "CreativeWeb Co.",
    Location = "San Francisco, CA",
    JobType = JobType.FullTime,
    PostedDate = new System.DateTime(2025, 2, 15)
},
new JobListing
{
    Id = 5,
    Title = "Backend Engineer",
    CompanyName = "Tech Innovations Ltd.",
    Location = "Austin, TX",
    JobType = JobType.PartTime,
    PostedDate = new System.DateTime(2025, 2, 12)
},


        };

        // Index action to display list of job listings
        public ActionResult Index()
        {
            // You could replace this with data from a database
            return View(jobListings);
        }

        // Details action to display details of a selected job
        public ActionResult Details(int id)
        {
            var job = jobListings.FirstOrDefault(j => j.Id == id);
            if (job == null)
            {
                return NotFound();
            }
            return View(job); // ✅ Passing a single JobListing, not a list
        }
    }
}
