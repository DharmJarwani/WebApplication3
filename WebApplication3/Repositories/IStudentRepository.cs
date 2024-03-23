using WebApplication3.Models;

namespace WebApplication3.Repositories
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetStudentsAsync();
    }
}
