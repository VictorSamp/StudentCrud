using StudentCrud.Domain.Model;

namespace StudentCrud.Domain.Dtos.Responses
{
    public class GetStudentByEmailResponseDto
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        public GetStudentByEmailResponseDto(Student student)
        {
            Id = student.Id;
            FullName = student.FullName;
            Email = student.Email;
        }
    }
}