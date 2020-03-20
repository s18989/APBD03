using APBD03.Models;
using System.Collections.Generic;

namespace APBD03.DAL
{
    public interface IDbService
    {
        public IEnumerable<Students> GetStudents();
    }
}
