using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void GiveBookAName(ref GradeBook book)
        {
            book.Name = "The Gradebook";
        }

        static void IncrementNumber(out int number)
        {
            number = 42;
        }

        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();

            book.NameChanged += OnNameChanged;

            book.Name = "Scott's Grade Book";
            book.Name = "GradeBook";

            book.AddGrade(91f);
            book.AddGrade(89.5f);
            book.AddGrade(75f);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name); ;
            WriteResults("Average Grade", stats.AverageGrade);
            WriteResults("Lowest Grade", stats.LowestGrade);
            WriteResults("Highest Grade", (int)stats.HighestGrade);

            Console.Read();
        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Grade book changing name from {args.ExistingName} to {args.NewName}");
        }

        static void WriteResults(string description, int result)
        {
            Console.WriteLine($"{description}: {result:F2}");
        }

        static void WriteResults(string description, float result)
        {
            Console.WriteLine($"{description}: {result:F2}");
        }
        
    }
}
