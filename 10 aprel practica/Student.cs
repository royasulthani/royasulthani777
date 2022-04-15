using System;
using System.Collections.Generic;
using System.Text;

namespace _10_aprel_practica
{
    class Student:Person
    {
        public Student[] Students = new Student[0];
        private static int _id;
        public int Id { get; set; }
        public void AddStudent(Student student)
        {
            Array.Resize(ref Students,Students.Length+1);
            Students[Students.Length - 1] = student;
        } 
    public Student()
    {
        _id++;
        Id = _id;
    }
    public string[] Lessons = new string[0];

        public static implicit operator Student(string v)
        {
            throw new NotImplementedException();
        }
    }

}

