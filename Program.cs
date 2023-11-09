using System;

namespace DesignPatterns
{
    // TODO#1: Convert to use Singleton pattern
    // Singleton Printer class to ensure only one instance is created
    public class Printer
    {
        private static Printer _instance;

        // Private constructor to prevent direct instantiation
        private Printer() { }

        public static Printer Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Printer();
                }
                return _instance;
            }
        }

        public void Print(string message)
        {
            // Output: print out the string message
            Console.WriteLine(message);
        }
    }

    // TODO#2: Convert to use Abstract Factory pattern
    // Create an Exam interface and an Abstract Factory to manage the creation of different exam types.

    // Exam interface
    public interface IExam
    {
        void Conduct();
        void Evaluate();
        void PublishResults();
    }

    // Concrete implementation of MathExam
    public class MathExam : IExam
    {
        public void Conduct()
        {
            // Output: "Conducting Math Exam", should use Printer class to print the message
            Printer.Instance.Print("Conducting Math Exam");
        }

        public void Evaluate()
        {
            // Output: "Evaluating Math Exam", should use Printer class to print the message
            Printer.Instance.Print("Evaluating Math Exam");
        }

        public void PublishResults()
        {
            // Output: "Publishing Math Exam Results", should use Printer class to print the message
            Printer.Instance.Print("Publishing Math Exam Results");
        }
    }

    // TODO#5: Add new ScienceExam class
    public class ScienceExam : IExam
    {
        public void Conduct()
        {
            // Output: "Conducting Science Exam", should use Printer class to print the message
            Printer.Instance.Print("Conducting Science Exam");
        }

        public void Evaluate()
        {
            // Output: "Evaluating Science Exam", should use Printer class to print the message
            Printer.Instance.Print("Evaluating Science Exam");
        }

        public void PublishResults()
        {
            // Output: "Publishing Science Exam Results", should use Printer class to print the message
            Printer.Instance.Print("Publishing Science Exam Results");
        }
    }

    // TODO#6: Add another ProgrammingExam class
    public class ProgrammingExam : IExam
    {
        public void Conduct()
        {
            // Output: "Conducting Programming Exam", should use Printer class to print the message
            Printer.Instance.Print("Conducting Programming Exam");
        }

        public void Evaluate()
        {
            // Output: "Evaluating Programming Exam", should use Printer class to print the message
            Printer.Instance.Print("Evaluating Programming Exam");
        }

        public void PublishResults()
        {
            // Output: "Publishing Programming Exam Results", should use Printer class to print the message
            Printer.Instance.Print("Publishing Programming Exam Results");
        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            // TODO#7: Initialize Printer that uses Singleton pattern
            // TODO#8: Test that the created Printer works, by calling the Print method
            Printer printer = Printer.Instance;
            printer.Print("Testing Printer");

            // TODO#9: Ensure that only one Printer instance is used throughout the application.
            // Try to create a new Printer object and compare the two objects to check,
            // that the new printer object is the same instance
            Printer anotherPrinter = Printer.Instance;
            Console.WriteLine($"Are the two printers the same instance? {printer == anotherPrinter}");

            // TODO#10: Use Abstract Factory to create different types of exams.
            IExam mathExam = new MathExam();
            mathExam.Conduct();
            mathExam.Evaluate();
            mathExam.PublishResults();

            IExam scienceExam = new ScienceExam();
            scienceExam.Conduct();
            scienceExam.Evaluate();
            scienceExam.PublishResults();

            IExam programmingExam = new ProgrammingExam();
            programmingExam.Conduct();
            programmingExam.Evaluate();
            programmingExam.PublishResults();
        }
    }
}
