using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentCrud.Api.Contracts.Requests.Commands;
using StudentCrud.Api.Contracts.Requests.Queries;
using StudentCrud.Api.Contracts.Responses;
using StudentCrud.Domain.Commands;
using StudentCrud.Domain.Queries;

namespace StudentCrud.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<StudentController> _logger;

        public StudentController(IMediator mediator, ILogger<StudentController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetStudentByEmail([FromRoute]GetStudentByEmailRequest request, CancellationToken cancellationToken)
        {
            var command = new GetStudentByEmail(request.Email);

            var student = await _mediator.Send(command, cancellationToken);

            var response = new GetStudentByEmailResponse(student.Id, student.FullName, student.Email);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateStudent([FromBody] CreateStudentRequest request, CancellationToken cancellationToken)
        {
            var command = new CreateStudent(request.FullName, request.Email);

            await _mediator.Send(command, cancellationToken);

            return Ok();
        }
    }
}