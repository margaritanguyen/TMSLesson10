﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMSLesson10
{
    class WrongPasswordException : Exception
    {
        public WrongPasswordException(string message) : base(message) { }
    }
}
