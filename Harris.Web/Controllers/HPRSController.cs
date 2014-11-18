using Harris.Core.Data;
using Harris.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Harris.Web.Controllers
{
    public class HPRSController : ApiController
    {
        HPRSContext db = new HPRSContext();

        public IEnumerable<Status> GetStatus(int start = 0, int end = 100)
        {
            var x = db.Statuses.ToList().Skip(start).Take(end).Select(c => new Status
            {
                StatusDate = c.StatusDate,
                Result = c.Result,
                Employee = new Employee
                {
                    Id = c.Employee.Id,
                    Firstname = c.Employee.Firstname,
                    Lastname = c.Employee.Lastname
                },
                Tags = c.Tags.Select(d => new Tag {
                    Id = d.Id,
                    Name = d.Name
                }).ToList()
            });
            return x; 
        }
    }
}
