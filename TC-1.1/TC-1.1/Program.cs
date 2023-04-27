using System;

namespace MoodAnalyserProblem
{
    class Program
    {       
        static void Main(string[] args)
        {
            MoodAnalyserClass moodAnalyser = new MoodAnalyserClass();
            Console.WriteLine("The mood of your customer is {0}", moodAnalyser.analyseMood("I am sad today"));
            Console.WriteLine("The mood of your customer is {0}", moodAnalyser.analyseMood("I am happy today"));
            Console.ReadKey();
        }
    }
}