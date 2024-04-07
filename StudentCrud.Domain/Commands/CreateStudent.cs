using MediatR;

namespace StudentCrud.Domain.Commands
{
    public class CreateStudent : IRequest
    {
        public string FullName { get; set; }
        public string Email { get; set; }

        public CreateStudent(string fullName, string email)
        {
            FullName = fullName;
            Email = email;
        }
    }
}