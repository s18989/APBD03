using APBD03.Models;
using System.Collections.Generic;

namespace APBD03.DAL
{
    public class MockDbService : IDbService
    {   
        private static IEnumerable<Students> _students;

        static MockDbService()
        {
            _students = new List<Students>
            {
                new Students{IdStudent=1, FirstName="Jan", LastName="Kochanowski"},
                new Students{IdStudent=2, FirstName="Adam", LastName="Mickiewicz"},
                new Students{IdStudent=3, FirstName="Bolesław", LastName="Prus"}
            };
        }

        public IEnumerable<Students> GetStudents()
        {
            return _students;
        }

    }
}
