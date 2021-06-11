using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SummitNeedsChecking
{
    public class Validator : IValidator
    {
        public bool ReferenceContainsChecksum(string reference)
        {
            var length = reference.Length;
            return Char.IsDigit(reference[length - 2]) && Char.IsDigit(reference[length - 1]);
        }

        public bool ReferenceIsAtLeast8Characters(string reference)
        {
            return reference.Length >= 8;
        }

        public bool ReferenceOnlyContainsLettersAndNumbers(string reference)
        {
            var regex = new Regex(@"^[_A-z0-9]*((-|\s)*[_A-z0-9])*$");
            return regex.IsMatch(reference);
        }

        public bool ReferenceStartsWithLetter(string reference)
        {
            return Char.IsLetter(reference[0]);
        }
    }
}
