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
        }
        /// <summary>
        /// Retrievings the top two record where age of person less than sixty.
        /// </summary>
        /// <param name="listPersonInCity">The list person in city.</param>
        public static void Retrieving_TopTwoRecord_Where_AgeLessThanSixty(List<Person> listPersonInCity)
        {
            foreach (Person person in listPersonInCity.FindAll(e => (e.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name: "+person.Name+" Age: "+person.Age);
            }
        }
    }
}
