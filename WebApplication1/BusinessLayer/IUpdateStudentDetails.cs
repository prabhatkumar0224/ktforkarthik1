using WebApplication1.Models;

namespace WebApplication1.BusinessLayer
{
    public interface IUpdateStudentDetails
    {
        Task<string> updatestudentdetails(Studentdetails studentdetails);
    }
}
