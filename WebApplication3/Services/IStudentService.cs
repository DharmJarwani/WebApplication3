using WebApplication3.Models;

namespace WebApplication3.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetStudentsAsync();
    }
}
