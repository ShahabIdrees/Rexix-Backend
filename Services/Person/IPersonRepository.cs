using RexixBackend.DTOs;
namespace RexixBackend.Services.Person
{
    public interface IPersonRepository
    {
        Task<List<PersonDTO>> GetAllPersons();
        Task<PersonDTO> GetPerson(Guid id);

        Task<List<PersonDTO>> AddPerson(PersonDTO Person);

        Task<List<PersonDTO>> UpdatePerson(Guid id, PersonDTO Person);
        Task<List<PersonDTO>> DeletePerson(Guid id);
        // Add your class members here
    }
}