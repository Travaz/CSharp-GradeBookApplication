using System;
using System.Collections.Generic;
using GradeBook.UserInterfaces;
using GradeBook.GradeBooks;
using GradeBook.Enums;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#=======================#");
            Console.WriteLine("# Welcome to GradeBook! #");
            Console.WriteLine("#=======================#");

            StartingUserInterface.CommandLoop();
            // RankedBased();
            
            Console.WriteLine("Thank you for using GradeBook!");
            Console.WriteLine("Have a nice day!");
            Console.Read();
        }

        // static void RankedBased() 
        // {
        //     var gradebook = new RankedGradeBook("MSDE");
        //     var students = new List<Student>
        //     {
        //         new Student("jamie",StudentType.Standard,EnrollmentType.Campus)
        //         {
        //             Grades = new List<double>{ 100 }
        //         },
        //         new Student("john",StudentType.Standard,EnrollmentType.Campus)
        //         {
        //             Grades = new List<double>{ 75 }
        //         },
        //         new Student("jackie",StudentType.Standard,EnrollmentType.Campus)
        //         {
        //             Grades = new List<double>{ 50 }
        //         },
        //         new Student("tom",StudentType.Standard,EnrollmentType.Campus)
        //         {
        //             Grades = new List<double>{ 25 }
        //         },                
        //         // new Student("maria",StudentType.Standard,EnrollmentType.Campus)
        //         // {
        //         //     Grades = new List<double>{ 25 }
        //         // },                
        //         // new Student("mariom",StudentType.Standard,EnrollmentType.Campus)
        //         // {
        //         //     Grades = new List<double>{ 25 }
        //         // },
        //         new Student("tony",StudentType.Standard,EnrollmentType.Campus)
        //         {
        //             Grades = new List<double>{ 0 }
        //         }
        //     };

        //     students.ForEach(s => gradebook.AddStudent(s));

        //     System.Console.WriteLine(gradebook.GetLetterGrade(25));

        // }

    }
}