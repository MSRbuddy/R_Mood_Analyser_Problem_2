﻿using System;
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
            if (!string.IsNullOrEmpty(message))
                this.message = message.ToUpper();
            else if (message == string.Empty)
                this.message = message;
        }

       
        public string analyseMood()
        {
            try
            {
                if (!String.IsNullOrEmpty(message))
                {
                    if (message.ToUpper().Contains("SAD"))
                        return "SAD";
                    else if (message.ToUpper().Contains("HAPPY") || message.ToUpper().Contains("ANY"))
                        return "HAPPY";
                    else
                        return "HAPPY";
                }
                else
                {
                    if (this.message.Equals(string.Empty))
                        throw new MoodAnalysisCustomException(MoodAnalysisCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be EMPTY");
                    else
                        throw new NullReferenceException();
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalysisCustomException(MoodAnalysisCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be NULL");
            }

        }
    }
}
