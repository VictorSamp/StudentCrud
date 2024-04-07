namespace StudentCrud.Api.Request.Commands
{
    public class CreateStudentRequest
    {
        public string? FullName { get; set; }
        public string? Email { get; set; }
    }
}