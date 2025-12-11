using System;
using System.Reflection.Metadata.Ecma335;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
                      
            Human human01 = new Human("Joe",21);
         
            human01.Eat();
        }
    }
    class Human
    {
        public String name;
        public int age;

        public Human(String name,int age)
            
        {
            this.name = name;
            this.age = age;
        }
        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }
    }
}
