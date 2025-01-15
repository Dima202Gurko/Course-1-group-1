using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._2025
{
    internal class Program
    {
        public class Person
        {
            //Часть A
            public string name;
            public int age;
            public Person(string name, int age)
            {
                this.name = name;
                //this.age = age;
                ProverAge(age);
            }
            public void Introduce()
            {
                Console.WriteLine($"Привет, мое имя {name}");
            }
            //Часть B
            public void ProverAge(int Age)
            {
                if(Age >= 0)
                {
                    age = Age;
                }
                else
                {
                    Console.WriteLine("Возраст указан неверно!");
                }
            }
        }
        //Часть C
        public class Employee : Person
        {
            public string position;
            public Employee(string name, int age, string position) : base(name, age)
            {
                this.position = position;
            }         
        }
        static void Main(string[] args)
        {
            /*Person person = new Person();
            person.name = "Oleg";
            person.age = 20;*/ //1
            Person[] student = new Person[2];
            student[0] = new Person("Dima", 21);
            student[1] = new Person("Artem", 23);
            foreach(Person person in student)
            {
                person.Introduce();
            }
        }
    }
}
