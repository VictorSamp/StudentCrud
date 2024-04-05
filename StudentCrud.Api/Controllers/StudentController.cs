using Microsoft.AspNetCore.Mvc;
using StudentCrud.Api.Request.Commands;
using StudentCrud.Domain.Commands;
using StudentCrud.Domain.Interfaces.CommandHandlers;

namespace StudentCrud.Api.Controllers
{
    [ApiController]
    [Route("v1/student")]
    public class StudentController : ControllerBase
    {
        private readonly ICreateStudentCommandHandler _handler;
        private readonly ILogger<StudentController> _logger;

        public StudentController(ICreateStudentCommandHandler handler, ILogger<StudentController> logger)
        {
            _handler = handler;
            _logger = logger;
        }

        [HttpPost]
        [Route("")]
        public void CreateStudent(CreateStudentRequest request)
        {
            var command = new CreateStudent(request.FullName, request.Email);

            _handler.Handle(command);
        }
    }
}