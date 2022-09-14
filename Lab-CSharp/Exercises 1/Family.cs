using System.Collections.Generic;

namespace Lab_CSharp.Exercises_1
{
    public class Family:Person
    {
        List<Person> families;
        public Family()
        {
            families = new List<Person>();
        }
        public  void AddMember(Person member)
        {
            families.Add(member);
        }
        public Person GetOldestMember()
        {
            int max = int.MinValue;
            int index = -1;
            for (int i = 0;i< families.Count; i++)
            {
                if (families[i].age>max)
                {
                    max = families[i].age;
                    index = i;
                }
            }
            if (index >= -1)
            {
                return families[index];
            }
            return null;
        }
    }
}