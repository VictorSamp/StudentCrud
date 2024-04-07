﻿namespace StudentCrud.Domain.Model
{
    public class Student
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        public Student(string fullName, string email)
        {
            FullName = fullName;
            Email = email;
        }
    }
}