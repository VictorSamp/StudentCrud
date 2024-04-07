namespace StudentCrud.Api.Contracts.Responses
{
    public class GetStudentByEmailResponse
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        public GetStudentByEmailResponse(Guid id, string fullName, string email)
        {
            Id = id;
            FullName = fullName;
            Email = email;
        }
    }
}