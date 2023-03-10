using System;
using System.Collections.Generic;
using System.Text;

namespace UC_4__MoodAnalyserFactory
{
    public class MoodAnalyserCustomException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE,
            NO_SUCH_CLASS, NO_SUCH_METHOD,

        }
        public readonly ExceptionType type;
        public MoodAnalyserCustomException(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}
