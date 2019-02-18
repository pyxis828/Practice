using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            //GreetUser();
            IGradeTracker book = new ThrowAwayGradeBook();
            //book.NameChanged += OnNameChanged;
            //NameBook(book);
            AddGrades(book);
            WriteGradeResults(book);
            SaveGradesToFile(book);
        }

        private static void SaveGradesToFile(IGradeTracker book)
        {
            using (StreamWriter outputFile = File.CreateText("grades.txt"))
            {
                book.writeGrades(outputFile);
            }
        }

        private static void WriteGradeResults(IGradeTracker book)
        {
            GradeStatistics stats = book.ComputeStatistics();
            WriteResult("Highest", stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Name", book.Name);
            WriteResult("Grade", stats.LetterGrade);
        }

        private static void NameBook(IGradeTracker book)
        {
            try
            {
                Console.WriteLine("Enter a name for the grade book");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void AddGrades(IGradeTracker book)
        {
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(99);
            book.AddGrade(2);
        }

        private static void GreetUser()
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SelectVoiceByHints(VoiceGender.Female);
            synth.Speak("Hello, this is the grade book program.");
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result}");
        }

        static void WriteResult(string description, string result)
        {
            Console.WriteLine($"{description}: {result}");
        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Gradebook name changed from {args.OldName} to {args.NewName}");
        }
    }
}
