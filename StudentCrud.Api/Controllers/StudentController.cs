using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentCrud.Api.Request.Commands;
using StudentCrud.Domain.Commands;

namespace StudentCrud.Api.Controllers
{
    [ApiController]
    [Route("v1/student")]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<StudentController> _logger;

        public StudentController(IMediator mediator, ILogger<StudentController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CreateStudent(CreateStudentRequest request, CancellationToken cancellationToken)
        {
            var command = new CreateStudent(request.FullName, request.Email);

            await _mediator.Send(command, cancellationToken);

            return Ok();
        }
    }
}