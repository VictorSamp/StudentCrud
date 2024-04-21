using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentCrud.Api.Contracts.Requests.Commands;
using StudentCrud.Api.Contracts.Responses;
using StudentCrud.Domain.Commands;
using StudentCrud.Domain.Queries;

namespace StudentCrud.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{email}")]
        public async Task<ActionResult<GetStudentByEmailResponse>> GetStudentByEmail([FromRoute] string email, CancellationToken cancellationToken)
        {
            var command = new GetStudentByEmail(email);

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