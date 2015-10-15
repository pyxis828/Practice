using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectPractice
{    
    class Program
    {
        static void Main(string[] args)
        {
            Dog mine = new Dog();
            Console.WriteLine("My dog's name is {0} and she is {1}", mine.Name, mine.Color);
            Dog anotherDog = new Dog("Toby", "tan");
            anotherDog.Woof();
            mine.Woof();
            mine.Wag();          
            
        }
    }
    class Dog
    {
        private string name;
        private string color;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
               this.name = value;
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public Dog ()
        {                        
            this.Name = "Moya";
            this.Color = "white";
        }
        public Dog (string name, string color)
        {
            this.name = name;
            this.color = color;
        }
        public void Woof()
        {
            Console.WriteLine("The dog named {0} who is {1} said \"Woof!\"", name, color);
        }
        public void Wag()
        {
            Console.WriteLine("The dog named {0} is wagging its tail", this.name); 
        }
    }
}
