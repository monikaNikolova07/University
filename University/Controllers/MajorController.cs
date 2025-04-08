using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Data.Models;
using University.Data;

namespace University.Controllers
{
    public class MajorController
    {
        public UniversityContext context;

        public MajorController(UniversityContext _context)
        {
            context = _context;
        }

        public void AddMajor(string name, int facultyId)
        {
            var major = new Major()
            {
                Name = name,
                FacultyId = facultyId
            };

            context.Add(major);

            context.SaveChanges();
        }

        public List<Major> GetMajorsByFacultyId(int facultyId)
        {
            var majors = context.Majors
                .Where(m => m.FacultyId == facultyId)
                .ToList();

            return majors;
        }

        public List<Major> GetMajorsByName(string name)
        {
            var majors = context.Majors
                .Where(m => m.Name == name)
                .ToList();

            return majors;
        }

        public Major? GetMajorByNameAndFacultyId(string name, int facultyId)
        {
            var major = context.Majors
                .FirstOrDefault(m => m.Name == name && m.FacultyId == facultyId);

            return major;
        }
    }
}
