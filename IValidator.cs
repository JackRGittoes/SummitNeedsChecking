using System;
using System.Collections.Generic;
using System.Text;

namespace SummitNeedsChecking
{
    public interface IValidator
    {
        bool ReferenceIsAtLeast8Characters(string reference);
        bool ReferenceStartsWithLetter(string reference);
        bool ReferenceOnlyContainsLettersAndNumbers(string reference);
        bool ReferenceContainsChecksum(string reference);
    }
}
