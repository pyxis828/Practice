using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog mine = new Dog();           
            Console.WriteLine("The dog's age is: " + mine.GetAge());
            Dog otherDog = new Dog("Toby", 10, 0.3);
            Console.WriteLine("The dog, {0}, is {1} years old and {2}m long", otherDog.GetName(), otherDog.GetAge(), otherDog.GetLength());
        }
    }
    class Dog
    {
        private int age = 7;
        private string name = "Moya";
        private double length = 0.2;
        
        
        public Dog()
        {
            this.name = name;
            this.age = age;
            this.length = length;
        }
        public Dog(string name)
        {
            this.name = name;
            this.age = age;
            this.length = length;
        }
        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.length = length;
        }
        public Dog(string name, int age, double length)
        {
            this.name = name;
            this.age = age;
            this.length = length;
        }      
        public int GetAge()
        {
            return this.age;
        }
        public string GetName()
        {
            return this.name;
        }
        public double GetLength()
        {
            return this.length;
        }
    }  
 }

   

