namespace StudentCrud.Domain.Commands
{
    public class CreateStudent
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