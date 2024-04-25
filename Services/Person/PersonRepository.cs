using Microsoft.EntityFrameworkCore;
using RexixBackend.Data;
using RexixBackend.DTOs;

namespace RexixBackend.Services.Person
{
    public class PersonRepository : IPersonRepository
    {
        private readonly AppDbContext _context;
        public PersonRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<List<PersonDTO>> AddPerson(PersonDTO Person)
        {
            throw new NotImplementedException();
        }

        public Task<List<PersonDTO>> DeletePerson(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<PersonDTO>> GetAllPersons()
        {
            var persons = await _context.Person.ToListAsync();
            return persons;
        }

        public Task<PersonDTO> GetPerson(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PersonDTO>> UpdatePerson(Guid id, PersonDTO Person)
        {
            throw new NotImplementedException();
        }
    }
}