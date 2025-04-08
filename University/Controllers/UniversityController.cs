using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Data;
using University.Data.Models;

namespace University.Controllers
{
    public class UniversityController
    {
        public UniversityContext context;

        public UniversityController(UniversityContext _context)
        {
            context = _context;
        }

        public void AddUniversity(string name)
        {
            var university = new UniversityClass()
            {
                Name = name,
            };

            context.Universities.Add(university);

            context.SaveChanges();
        }

        public List<UniversityClass> GetAllUniversities()
        {
            var universities = context.Universities
                .ToList();

            return universities;
        }

        public UniversityClass? GetUniversityByName(string name)
        {
            var university = context.Universities
                .FirstOrDefault(u => u.Name == name);

            return university;
        }

        public int? GetUniversityIdByName(string name)
        {
            var university = context.Universities
               .FirstOrDefault(u => u.Name == name);

            return university.Id;
        }
    }
}
