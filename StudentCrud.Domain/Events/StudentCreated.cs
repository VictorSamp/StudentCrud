using Newtonsoft.Json;

namespace StudentCrud.Domain.Events
{
    public class StudentCreated : Event
    {
        public StudentCreated(Student student)
        {
            AggregateId = student.Id.ToString();
            EventType = nameof(StudentCreated);
            EventData = JsonConvert.SerializeObject(student);
        }
    }
}