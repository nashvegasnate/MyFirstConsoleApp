using System;
using System.Collections.Generic;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            //get data from a user
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
            //name = 7;
            //this won't work because of static types

            //csharp has a lot of specificity around numbers
            //32 bit signed number
            int favoriteNumber = 11;

            //64 bit signed numbers
            long reallyBigNumber = 9_223_372_036_854_775_806;

            //16 bit numbers
            short smallerNumbers = 32_767;

            //stuff with decimals
            double accountBalance = 0.57;
            //decimal accountBalance = 0.57M;
            //must use M at end of value because double is default w/ nothing at end

            //var is a shorthand for the real type
            //it is called type inference
            var myStuff = 5 * 5;
            //this still won't work
            //myStuff = "";

            //bool is for boolean
            var isTeaching = true;

            //datetime is for holding...datetime
            var today = new DateTime(2021, 7, 13);

            today = DateTime.Today;


            //var students = new string[5];
            //arrrays are not much fun in csharp

            //           = list of string (a new instance)
            var students = new List<string>();

            students.Add("Hunter");
            students.Add("Rob");
            students.Add("Jimbo");

            students.Remove("Jimbo");

            for(var i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i]);
            }

            //more idiomatic
            foreach(var student in students)
            {
                Console.WriteLine(student);
            }

            //csharp - IF block difference from JS - one equal = for set and two == for equality
            if (name == "Nathan")
            {
                Console.WriteLine("Hey it me");
            }
            else
            {
                Console.WriteLine("Not me");
            }

            //ternary (not technically control flow)
            var greeting = name == "Nathan" ? "It is you." : "It is not you";


            //anonymous types
            var nathan = new { Name = "Nathan", IsTeacher = true };

            //doesn't work, anonymous types don't allow for modification (immutable)
            //nathan.Name = "Steve";


            //objects break the rules sometimes because of being a reference type
            object animalType = "Dog";
            animalType = 45;

            //boxing moves values to the heap
            if (animalType.ToString() == "Dog")
            {
            }
        }
    }
}
