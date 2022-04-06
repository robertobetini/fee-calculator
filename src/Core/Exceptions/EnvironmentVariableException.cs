using System;
using System.Runtime.Serialization;

namespace Core.Exceptions
{
    [Serializable]
    internal class EnvironmentVariableException : Exception
    {
        public EnvironmentVariableException(string variableName, string message) : base($"Environment Variable '{variableName}' {message}")
        {
        }

        protected EnvironmentVariableException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}