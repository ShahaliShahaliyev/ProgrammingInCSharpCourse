using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson33_36.Data;
using Lesson33_36.Data.Entitites;

namespace Lesson33_36.Repository
{
    public interface IStudentManagerRepository
    {
        Task<Student> Get(int id);
        Task<IEnumerable<Student>> GetAll();

        List<Student> Add(Student entity);
        List<Student> Delete(int id);
        List<Student> Update(Student studentEntity);
    }

    public class StudentManagerRepository : IStudentManagerRepository
    {
        private readonly StudentDbContext _context;

        public StudentManagerRepository(StudentDbContext context)
        {
            _context=context;
        }

        public Task<Student> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Student>> GetAll()
        {

            return  _context.Students.ToList();
        }

        public List<Student> Add(Student entity)
        {
            return _context.Students.ToList();
        }

        public List<Student> Delete(int id)
        {
            return _context.Students.ToList();
        }

        public List<Student> Update(Student studentEntity)
        {
            return _context.Students.ToList();
        }
    }

}
