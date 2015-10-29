using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student me = new Student("Kirstin Walsh", "coding", "IT", "kirstin@email.com", "216-555-1234");
            me.Study();
            me.GetInfo();
            Student someGuy = new Student();
            Console.WriteLine(someGuy.Name);             
        }
    }
    class Student
    {
        private string name = "John Doe";
        public string Name
        {
            get
            {
                name.ToUpper();
                return name;
            }
            set
            {
                this.name = value;
            }
        }
        private string course = "Computer Programming";
        public string Course
        {
            get
            {
                return this.course;
            }
            set
            {
                this.course = value;
            }
        }
        private string subject = "IT";
        public string Subject
        {
            get
            {
                return this.subject;
            }
            set
            {
                this.subject = value;
            }
        }
        private string university = "Harvard";
        public string University
        {
            get
            {
                return this.university;
            }
            set
            {
                this.university = value;
            }
        }
        private string email = "kirstinwalsh@email.com";
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }
        private string phoneNumber = "216-555-1234";
        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                this.phoneNumber = value;
            }
        }
        public void Study ()
        {
            Console.WriteLine("The student, {0}, opened the book.", name);
        }
        public void GetInfo ()
        {
            Console.WriteLine("{0}, phone # {1}, email {2}.", name, phoneNumber, email);
        }
        public Student()
        {
            this.name = name;
            this.course = course;          
        }
        public Student(string someName)
        {
            this.name = someName;
            this.course = course;
        }
        public Student(string someName, string someCourse)
        {
            this.name = someName;
            this.course = someCourse;
        }
        public Student(string someName, string someCourse, string someSubject)
        {
            this.name = someName;
            this.course = someCourse;
            this.subject = someSubject;
        }
        public Student(string someName, string someCourse, string someSubject, string someEmail)
        {
            this.name = someName;
            this.course = someCourse;
            this.subject = someSubject;
            this.email = someEmail;
        }
        public Student(string someName, string someCourse, string someSubject, string someEmail, string somePhone)
        {
            this.name = someName;
            this.course = someCourse;
            this.subject = someSubject;
            this.email = someEmail;
            this.phoneNumber = somePhone;
        }
    }
}
