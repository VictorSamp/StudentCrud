using Microsoft.AspNetCore.Mvc;

namespace StudentCrud.Api.Contracts.Requests.Queries
{
    public class GetStudentByEmailRequest
    {
        [FromRoute]
        public string? Email { get; set; }
    }
}