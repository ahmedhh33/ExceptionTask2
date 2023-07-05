using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTask2
{
    internal class ClassRoom
    {
        public string Course { get; set; }
        public string Teacher { get; set; }
        readonly int  NumberOfStudents= 40;

        public ClassRoom(string course, string teacher )
        {
            this.Course = course;
            this.Teacher = teacher;
        }

        public void registrationStudent1(int  student)
        {
            if (student > 40)
            {
                throw new NumderOfstudentExceptions();
            }
            Console.WriteLine("The Students Regestred Sucsessfully");
        }
        
        public void registrationStudent2(int student)
        {
            registrationStudent1(student);
        }
        public void registrationStudent3(int student)
        {
            try
            {
                registrationStudent2(student);
            }catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Reduce the students");
            }
        }

    }
}
