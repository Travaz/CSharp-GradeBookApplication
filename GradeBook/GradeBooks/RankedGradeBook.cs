using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool isweighted) : base(name, isweighted) {
            // calling base gradebook
            this.Type = GradeBookType.Ranked;
            this.IsWeighted = isweighted;
        }


        public override char GetLetterGrade(double averageGrade)
        {
            // Ranked-based grading requires at least 5 students
            if (Students.Count < 5)
                throw new System.InvalidOperationException("Too few students");

            // (1) Order the students based on the average 
            var sortedStudentsAverages = Students
                .Select(s => s.AverageGrade)
                .OrderBy(ag => ag)
                .ToList();

            // (2) Retrieve the 5-quantiles of the distribution
            var quantiles = new List<double>();
            var fiveQuantileLimits = Range(min: 0.0, max: 0.8, step: 0.2).ToList();
            

            // (3) Foreach limit, retrieve the positions of the elements at a specific quantile
            foreach (var l in fiveQuantileLimits)
            {
                int index = Convert.ToInt32( l * (sortedStudentsAverages.Count) );
                quantiles.Add( sortedStudentsAverages[index]  );
            }
            quantiles.Add(sortedStudentsAverages.Last());

            // (4) Retrieve the correct ranked-based letter grade
            if (averageGrade >= quantiles[0] && averageGrade < quantiles[1])
                return 'F';
            else if (averageGrade >= quantiles[1] && averageGrade < quantiles[2])
                return 'D';            
            else if (averageGrade >= quantiles[2] && averageGrade < quantiles[3])
                return 'C';            
            else if (averageGrade >= quantiles[3] && averageGrade < quantiles[4])
                return 'B';            
            else 
                return 'A';

        }

        public static IEnumerable<double> Range(double min, double max, double step)
        {
            double i;
            for (i=min; i<=max; i+=step)
                yield return i;

            if (i != max+step) // added only because you want max to be returned as last item
                yield return max; 
        }

        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
                System.Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
            else
                base.CalculateStatistics();
        }

        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
                System.Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
            else
                base.CalculateStudentStatistics(name);
        }
    }
}