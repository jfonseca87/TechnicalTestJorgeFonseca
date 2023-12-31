﻿using System.Text.RegularExpressions;

namespace ClimateMonitor.Services.ExtensionMethods
{
    public static class StringExtensionMethods
    {
        private const string regexPattern = @"^(0|[1-9]\d*)\.(0|[1-9]\d*)\.(0|[1-9]\d*)(?:-((?:0|[1-9]\d*|\d*[a-zA-Z-][0-9a-zA-Z-]*)(?:\.(?:0|[1-9]\d*|\d*[a-zA-Z-][0-9a-zA-Z-]*))*))?(?:\+([0-9a-zA-Z-]+(?:\.[0-9a-zA-Z-]+)*))?$";

        public static bool IsValidFirmware(this string firmware) 
        {
            if (string.IsNullOrEmpty(firmware)) 
            {
                return false;
            }

            return Regex.IsMatch(firmware, regexPattern);
        }
    }
}
