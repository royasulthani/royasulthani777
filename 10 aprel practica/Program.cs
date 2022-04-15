using System;

namespace _10_aprel_practica
{
    class Program
    {
        static void Main(string[] args)
        {
            //int age;
            //int exp;
            Teacher teacher = new Teacher() ;
            Student student = new Student();
            Group group = new Group();
            //do
            //{
            //    Console.WriteLine("Age-i yeniden daxil edin");
            //    age = Convert.ToInt32(Console.ReadLine());
            //} while (age<0);
            //teacher.Age = age;
            //Console.WriteLine(teacher.Age);
            //do
            //{
            //    Console.WriteLine("Experienceni yeniden daxil edin");
            //    exp = Convert.ToInt32(Console.ReadLine());

            //} while (exp<1 ||exp>80);
            //teacher.Experience = exp;
            //Console.WriteLine(teacher.Experience);
            group.AddStudent("Roya");
            group.AddStudent("Fatima");
            foreach (Student students in group.FullNames)
            {
                Console.WriteLine(student);
            }
        }
    }
}
