using System;
using System.Collections.Generic;

namespace Lab_CSharp.Exercises_1
{
    public class Person
    {
         List<Person> Persons;
         List<Person> Person30;
        public string name;
        public int age;
        
        public Person(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        // public Person():this("No name",1) { }
        // public Person(int age):this("No name", age) { }
        //
        protected Person()
        {
            Persons = new List<Person>();
        }
        public  void AddPerson(Person member)
        {
            Persons.Add(member);
        }
        
    }
}