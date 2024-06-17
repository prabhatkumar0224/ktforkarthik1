using WebApplication1.Models;

namespace WebApplication1.DataLayer
{
    public interface IStudentdata
    {
        Task<string> updatestudentdetails(Studentdetails studentdetails);
    }
}
