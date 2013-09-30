using System;

namespace Pass4SureTestingEngine.Utils
{
    public class LetterHelper
    {
        public static char? LetterFromInt(int letterIndex)
        {
            if (letterIndex > 26 || letterIndex < 0)
                return null;

            return Convert.ToChar(letterIndex + 65);
        }
    }
}
