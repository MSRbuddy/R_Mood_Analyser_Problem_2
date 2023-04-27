using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem
{
    public class MoodAnalyserClass
    {
        public string message;

        public MoodAnalyserClass()
        {
            this.message = null;
        }

        public MoodAnalyserClass(string message)
        {
            this.message = message.ToUpper();
        }
      
        public string analyseMood()
        {
            if (this.message.Contains("SAD"))
                return "SAD";
            else if (this.message.Contains("HAPPY") || message.Contains("ANY"))
                return "HAPPY";
            else
                return "NO COMMENTS";
        }
    }
}
