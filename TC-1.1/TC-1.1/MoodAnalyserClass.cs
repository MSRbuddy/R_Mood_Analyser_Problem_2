using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem
{
    public class MoodAnalyserClass
    {
        public static string message;

        public string analyseMood(string messageRecieved)
        {
            message = messageRecieved.ToUpper();
            if (message.Contains("SAD"))
                return "SAD";
            else if (message.Contains("HAPPY"))
                return "HAPPY";
            else
                return "NO COMMENTS";
        }
    }
}
