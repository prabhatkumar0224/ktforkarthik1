using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.DataLayer
{
    public class Studentdata : IStudentdata
    {
        private readonly StudentDbContext _dbContext;
        public Studentdata(StudentDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<string> updatestudentdetails(Studentdetails studentdetails)
        {
            try
            {
                var getValue = await _dbContext.students
                .Where(x => x.rollno == studentdetails.rollno && x.classroom == studentdetails.classroom)
                .FirstOrDefaultAsync();
                if (getValue != null)
                {
                    getValue.rollno = studentdetails.rollno;
                    getValue.studentname = studentdetails.studentname;
                    getValue.fathername = studentdetails.fathername;
                    getValue.mothername = studentdetails.mothername;
                    getValue.address = studentdetails.address;
                    getValue.classroom = studentdetails.classroom;
                    var res = await _dbContext.SaveChangesAsync();
                    return "Details Updated";
                }
                else
                {
                    await _dbContext.students.AddAsync(new Student
                    {
                        rollno = studentdetails.rollno,
                        studentname = studentdetails.studentname,
                        fathername = studentdetails.fathername,
                        mothername = studentdetails.mothername,
                        address = studentdetails.address,
                        classroom = studentdetails.classroom
                    });
                    var res = await _dbContext.SaveChangesAsync();
                    return "Details Updated";
                }
            }
            catch (Exception ex) 
            {
                return "An exception ocurred while updating the data: "+ex.Message;
            }
        }
    }
}
