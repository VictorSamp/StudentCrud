using MediatR;
using StudentCrud.Domain.Dtos.Responses;

namespace StudentCrud.Domain.Queries
{
    public class GetStudentByEmail : IRequest<GetStudentByEmailResponseDto>
    {
        public string? Email { get; set; }

        public GetStudentByEmail(string? email)
        {
            Email = email;
        }
    }
}