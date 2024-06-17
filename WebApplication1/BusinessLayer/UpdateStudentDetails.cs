using WebApplication1.DataLayer;
using WebApplication1.Models;

namespace WebApplication1.BusinessLayer
{
    public class UpdateStudentDetails : IUpdateStudentDetails
    {
        private readonly IStudentdata _studentdata;

        public UpdateStudentDetails(IStudentdata studentdata)
        {
            _studentdata = studentdata;
        }

        public async Task<string> updatestudentdetails(Studentdetails studentdetails)
        {
            string response = await _studentdata.updatestudentdetails(studentdetails);
            return response;
        }
    }
}
