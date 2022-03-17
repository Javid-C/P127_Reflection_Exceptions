using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Reflection_Exceptions.Exceptions
{
    class CheckStudentAgeException:Exception
    {
        private string _message;
        public override string Message => _message;

        public CheckStudentAgeException(string message= "Telebenin yasi uygun deyil(default)")
        {
            _message = message;
        }
    }
}
