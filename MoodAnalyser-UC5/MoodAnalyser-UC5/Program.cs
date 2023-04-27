using System;

namespace MoodAnalyserProblem
{
    class Program
    {
        public static MoodAnalyserClass moodAnalyser;
        
        static void Main(string[] args)
        {
            moodAnalyser = new MoodAnalyserClass("I am in sad mood");
            Console.WriteLine("The mood of your customer is {0}", moodAnalyser.analyseMood());
            moodAnalyser = new MoodAnalyserClass("I am in happy mood");
            Console.WriteLine("The mood of your customer is {0}", moodAnalyser.analyseMood());
            moodAnalyser = new MoodAnalyserClass("I am in any mood");
            Console.WriteLine("The mood of your customer is {0}", moodAnalyser.analyseMood());

            Console.WriteLine("\n ============================================================");
            MoodAnalyserReflectionClass.ReflectMoodAnalyser();

            //Creating MoodAnalyserClass object at run time
            MoodAnalyserFactory.CreateMoodAnalyserObject("MoodAnalyserProblem.MoodAnalyserClass", "MoodAnalyserClass", "I am in happy mood today");
            Console.ReadKey();
        }
    }
}