using System.Linq;

namespace System
{
    //1. create a static class (convention)
    // start with the name of the class you're extending and add the postfix "Extensions" (convetion)
    public static class StringExtensions
    {
        //the first argument "this String str" represents the instance we're applying the method on. So it will work on strings here
        public static string Shorten(this String str, int numberOfWords) //should always be static 
        {
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException("number of words should be 0 or more");
            if (numberOfWords == 0)
                return "";

            var words = str.Split(' ');

            if (words.Length <= numberOfWords)
                return str;

            return string.Join(" ", words.Take(numberOfWords)) + "...";
            //return "Hello";
        }
    }
}
