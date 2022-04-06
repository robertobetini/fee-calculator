using Core.Exceptions;
using Core.Settings.Interfaces;
using System;

namespace Core.Settings
{
    public class EnvironmentSettings : IEnvironmentSettings
    {
        public double Interest
        {
            get
            {
                var variableName = "InterestValue";
                var interest = Environment.GetEnvironmentVariable(variableName);

                if (string.IsNullOrWhiteSpace(interest))
                    throw new EnvironmentVariableException(variableName, "can't be null or empty.");

                if (!double.TryParse(interest, out var interestValue))
                    throw new EnvironmentVariableException(variableName, "must be a float.");

                return interestValue;
            }
        }
    }
}
