using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.DataLayer
{
    public class Studentdata
    {
        private readonly StudentDbContext _dbContext;
        public Studentdata()
        {
           
        }
        public async Task<string> updatestudentdetails(Studentdetails studentdetails) { }

    }
}
