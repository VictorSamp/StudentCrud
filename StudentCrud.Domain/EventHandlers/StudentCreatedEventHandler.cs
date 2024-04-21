using Newtonsoft.Json;
using StudentCrud.Domain.Events;
using StudentCrud.Domain.Interfaces.EventHandlers;
using StudentCrud.Domain.Interfaces.Repository;

namespace StudentCrud.Domain.EventHandlers
{
    internal class StudentCreatedEventHandler : IStudentCreatedEventHandler
    {
        private readonly IStudentRepository _studentCrudReadModelDb;

        public StudentCreatedEventHandler(IStudentRepository studentCrudReadModelDb)
        {
            _studentCrudReadModelDb = studentCrudReadModelDb;
        }

        public async Task Handle(StudentCreated notification, CancellationToken cancellationToken)
        {
            var student = JsonConvert.DeserializeObject<Student>(notification.EventData);

            // TODO: Adicionar validação caso seja nulo

            await _studentCrudReadModelDb.Save(student);
        }
    }
}