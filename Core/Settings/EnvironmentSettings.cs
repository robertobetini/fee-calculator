using Core.Exceptions;
using Core.Settings.Interfaces;
using System;

namespace Core.Settings
{
    public class EnvironmentSettings : IEnvironmentSettings
    {
        public double Fee
        {
            get
            {
                var variableName = "FeeValue";
                var fee = Environment.GetEnvironmentVariable(variableName);

                if (string.IsNullOrWhiteSpace(fee))
                    throw new EnvironmentVariableException(variableName, "can't be null or empty.");

                if (!double.TryParse(fee, out var feeValue))
                    throw new EnvironmentVariableException(variableName, "must be a float.");

                return feeValue;
            }
        }
    }
}
