﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem
{
    public class MoodAnalysisCustomException : Exception
    {
        public enum ExceptionType
        {
            EMPTY_MESSAGE,
            NULL_MESSAGE,
            NO_SUCH_CLASS,
            NO_SUCH_CONSTRUCTOR,
            NO_SUCH_METHOD,
            NO_SUCH_FIELD
        }
        
        public readonly ExceptionType type;

        public MoodAnalysisCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}