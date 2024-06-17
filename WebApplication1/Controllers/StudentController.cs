using Microsoft.AspNetCore.Mvc;
using WebApplication1.BusinessLayer;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class StudentController : Controller
    {
        private readonly IUpdateStudentDetails _updateStudentDetails;

        public StudentController(IUpdateStudentDetails updateStudentDetails)
        {
            _updateStudentDetails = updateStudentDetails;
        }

        [HttpPost]
        [ActionName("UpdateStudentDetails")]
        public async Task<string> UpdateStudentDetails(Studentdetails studentdetails)
        {
            string response= await _updateStudentDetails.updatestudentdetails(studentdetails);
            return response;
        }
    }
}
