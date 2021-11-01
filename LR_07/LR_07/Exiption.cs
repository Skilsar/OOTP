using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace LR_07
{
    class ErrorName : ArgumentException
    {
        string Value
        {
            get;
            set;
        }

        public ErrorName(string message, string value) : base(message)
        {
            Value = value;
        }
    }

    class ErrorAge : ArgumentException
    {
        int Value
        {
            get;
            set;
        }

        public ErrorAge(string message, int value) : base(message)
        {
            Value = value;
        }
    }

    class ProgrammerExpError : ArgumentException
    {
        int Value
        {
            get;
            set;
        }

        public ProgrammerExpError(string message, int value) : base(message)
        {
            Value = value;
        }
    }

}
