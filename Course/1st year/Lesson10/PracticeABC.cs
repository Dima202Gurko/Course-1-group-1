using System;
using System.IO;
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
            //Часть A L9
            public string name;
            public int age;
            public Person(string name, int age)
            {
                this.name = name;
                //this.age = age;
                ProverAge(age);
            }
            public string Introduce(string milen)
            {
                milen = $"Привет, мое имя {name}";
                return milen;
            }
            //Часть B L9
            public void ProverAge(int Age)
            {
                if (Age >= 0)
                {
                    age = Age;
                }
                else
                {
                    Console.WriteLine("Возраст указан неверно!");
                }
            }
        }
        //Часть C L9
        public class Employee : Person
        {
            public string position;
            public Employee(string name, int age, string position) : base(name, age)
            {
                this.position = position;
            }
        }
        //PracticA
        class FileOperations
        {
            public static void WriteToFile()
            {
                string[] lines = new string[10];
                for (int i = 0; i < lines.Length; i++)
                {
                    lines[i] = "Hello";
                }
                File.WriteAllLines("Test.txt", lines);
            }
            public static void ReadFromFile()
            {
                string[] lines = File.ReadAllLines("Test.txt");
                foreach(string line in  lines)
                {
                    Console.WriteLine(line);
                }
            }
        }
        //PracticB,C
        static void WritteFile()
        {
            /*Person person = new Person();
            person.name = "Oleg";
            person.age = 20;*/ //1
            Person person = new Person("", 0);
            Person[] student = new Person[2];
            student[0] = new Person("Dima", 21);
            student[1] = new Person("Artem", 23);
            string[] pers = new string[2];
            int i = 0;
            foreach (Person persona in student)
            {
                pers[i] = persona.Introduce("");
                i++;
            }
            i = 0;
            File.WriteAllLines("Person.md", pers);
        }
        static void ReadFile()
        {
            string[] line = File.ReadAllLines("Person.md");
            foreach(string i in line)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            FileOperations.WriteToFile();
            FileOperations.ReadFromFile();
            //PracticB,C
            WritteFile();
            ReadFile();
        }
    }
}
