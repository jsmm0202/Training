﻿namespace Acme.Common
{
    using System;

    public static class StringHandler
    {
        /// <summary>
        /// Insert spaces before each capital letter in a string if there aren't any.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string InsertSpaces(this string source)
        {
            string result = string.Empty;

            if (!string.IsNullOrWhiteSpace(source))
            {
                foreach (char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result = result.Trim();
                        result += " ";
                    }

                    result += letter;
                }
            }

            result = result.Trim();
            return result;
        }
    }
}
