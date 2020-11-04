using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpression
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            //declaring list 
            List<Person> listPersonInCity = new List<Person>();
            AddPersonInfo(listPersonInCity);
            Retrieving_TopTwoRecord_Where_AgeLessThanSixty(listPersonInCity);
            Checking_TeenAge_Person(listPersonInCity);
            Retrive_Average_Age(listPersonInCity);
            Retrive_Persons_Whose_Age_Greater_Sixty(listPersonInCity);
        }
        /// <summary>
        /// Adds the person information to list
        /// </summary>
        /// <param name="listPersonInCity">The list person in city.</param>
        public static void AddPersonInfo(List<Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person("123", "goud", "nlg", 21));
            listPersonInCity.Add(new Person("456", "naidu", "khm", 65));
            listPersonInCity.Add(new Person("956", "reddy", "hyd", 23));
            listPersonInCity.Add(new Person("789", "ted", "wng", 70));
            listPersonInCity.Add(new Person("760", "tony", "wngl", 55));
            listPersonInCity.Add(new Person("729", "tillu", "khz", 95));
            listPersonInCity.Add(new Person("729", "mad", "europe", 16));
        }
        /// <summary>
        /// Retrievings the top two record where age of person less than sixty.
        /// </summary>
        /// <param name="listPersonInCity">The list person in city.</param>
        public static void Retrieving_TopTwoRecord_Where_AgeLessThanSixty(List<Person> listPersonInCity)
        {
            foreach (Person person in listPersonInCity.FindAll(e => (e.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name: " + person.Name + " Age: " + person.Age);
            }
        }
        /// <summary>
        /// Checkings the teenage person in the list 
        /// </summary>
        /// <param name="listPersonInCity">The list person in city.</param>
        public static void Checking_TeenAge_Person(List<Person> listPersonInCity)
        {

            if (listPersonInCity.Any(e => e.Age >= 13 && e.Age <= 19))
            {
                Console.WriteLine("A Teenager found");
            }
            else
            {
                Console.WriteLine("No teenager found");
            }
        }
        /// <summary>
        /// Method gets average age of the persons in list 
        /// </summary>
        /// <param name="listPersonInCity"></param>
        public static void Retrive_Average_Age(List<Person> listPersonInCity)
        {
            double age = 0;
            foreach (Person person in listPersonInCity.FindAll(e => (e.Age < 100)).ToList())
            {

                age = age + person.Age;
               
            }
            Console.WriteLine("Average of ages is: " +age / listPersonInCity.Count);
        }
        /// <summary>
        /// Method gets the person whose age is greater than 60
        /// </summary>
        /// <param name="listPersonInCity"></param>
        public static void Retrive_Persons_Whose_Age_Greater_Sixty(List<Person> listPersonInCity)
        {
            foreach (Person person in listPersonInCity.FindAll(e => (e.Age > 60)).ToList())
            {
                Console.WriteLine("The persons whose age greater than 60: "+person.Name +" "+person.Age);
            }
        }
    }
}
