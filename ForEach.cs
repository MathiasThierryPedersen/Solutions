using System;
using System.Collections.Generic;
namespace ForEachConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Jens Hansen", "Bo Jensen", "Hans Pedersen" };
            List<Person> personList = new List<Person>();

            personList.Add(new Person("Søren", "Jensen"));
            personList.Add(new Person("Lars", "Jørgensen"));
            personList.Add(new Person("Karl", "Sørensen"));
            

            writeNamesFromListOfStrings(names);
            writeNamesFromListOfObjects(personList);

        }

        public static void writeNamesFromListOfStrings(List<String> names)
        {
            foreach(String name in names)
            {
                Console.WriteLine(name);
            }
        }

        private static void writeNamesFromListOfObjects(List<Person> people)
        {
            foreach(Person person in people)
            {
                Console.WriteLine(person.firstName + " " + person.lastName);
            }
        }

    }

    class Person
    {
        public String firstName;
        public String lastName;

        public Person(String firstName, String lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }


    }
}
