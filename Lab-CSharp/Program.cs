using System;
using System.Collections.Generic;
using System.Reflection;
using Lab_CSharp.Exercises_1;

namespace Lab_CSharp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
         Exercise5();   
        }

        private static void Exercise5()
        {
            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();
            int result = DateModifier.DifferenceDate(date1, date2);
            Console.WriteLine(result);
        }

        private static void Exercise4()
        {
            List<Person> myPeople = new List<Person>();
            Console.WriteLine("Input number people in family: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string people = Console.ReadLine();
                string[] listPeople = people.Split();
                if (int.Parse(listPeople[1])>30)
                {
                    Person myPerson = new Person(listPeople[0],int.Parse(listPeople[1]));
                    myPeople.Add(myPerson);
                }
            }

            for (int i = 0; i < myPeople.Count; i++)
            {
                Console.WriteLine(myPeople[i].name+" - "+myPeople[i].age);
            }
        }
        
        private static void Exercise3()
        {
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            if(oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }

            Family myFamily = new Family();
            Console.WriteLine("Input number people in family: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string people = Console.ReadLine();
                string[] listPeople = people.Split();
                Person myPerson = new Person(listPeople[0],int.Parse(listPeople[1]));
                myFamily.AddMember(myPerson);
            }
            Person oldestPerson = myFamily.GetOldestMember();
            Console.WriteLine("The oldest: "+oldestPerson.name+ " : "+oldestPerson.age);
        }
        private static void Exercise2()
        {
            Type personType = typeof(Person);
            ConstructorInfo emptyCtor = personType.GetConstructor(new Type[] { });
            ConstructorInfo ageCtor = personType.GetConstructor(new[] { typeof(int) });
            ConstructorInfo nameAgeCtor = personType.GetConstructor(new[] { typeof(string), typeof(int) });
            bool swapped = false;
            if (nameAgeCtor == null)
            {
                nameAgeCtor = personType.GetConstructor(new[] { typeof(int), typeof(string) });
                swapped = true;
            }

            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Person basePerson = (Person)emptyCtor.Invoke(new object[] { });
            Person personWithAge = (Person)ageCtor.Invoke(new object[] { age });
            Person personWithAgeAndName = swapped ? (Person)nameAgeCtor.Invoke(new object[] { age, name }) :(Person)nameAgeCtor.Invoke
                (new object[] { name, age });

            Console.WriteLine("{0} {1}", basePerson.name, basePerson.age);
            Console.WriteLine("{0} {1}", personWithAge.name, personWithAge.age);
            Console.WriteLine("{0} {1}", personWithAgeAndName.name, personWithAgeAndName.age);

        }
        private static void Exercise1()
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);
        }
    }
}