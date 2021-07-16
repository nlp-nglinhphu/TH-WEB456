using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TH_WEB456.Models;

namespace TH_WEB456.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _dbContext;
        public AttendancesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Attend([FromBody] int courseId)
        {
            var attendance = new Attendance
            {
                CourseId = courseId,
                AttendeeId = User.Identity.GetUserId()
            };

            _dbContext.Attendances.Add(attendance);
            _dbContext.SaveChanges();


            return Ok();
        }
    }
}
