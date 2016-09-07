using System;
using Xunit;
using NSS_Koans;

namespace NSS_Koans_Tester
{
   
    public class Strings
    {
        //Note: This is one of the longest test files and, perhaps, one
        //of the most important. String behavior in .NET is not
        //always what you expect it to be, especially when it comes
        //to concatenation and newlines, and is one of the biggest
        //causes of memory leaks in .NET applications
        public object FILL_ME_IN = Koan.FILL_ME_IN;
        [Fact]
        public void AboutStringsDoubleQuotedStringsAreStrings()
        {
            var str = "Hello, World";
            Assert.Equal(typeof(FillMeIn), str.GetType());
        }

        [Fact]
        public void AboutStringsSingleQuotedStringsAreNotStrings()
        {
            var str = 'H';
            Assert.Equal(typeof(FillMeIn), str.GetType());
        }


        [Fact]
        public void AboutStringsCreateAStringWhichContainsDoubleQuotes()
        {
            var str = "Hello, \"World\"";
            Assert.Equal(FILL_ME_IN, str.Length);
        }

        [Fact]
        public void AboutStringsAnotherWayToCreateAStringWhichContainsDoubleQuotes()
        {
            //The @ symbol creates a 'verbatim string literal'. 
            //Here's one thing you can do with it:
            var str = @"Hello, ""World""";
            Assert.Equal(FILL_ME_IN, str.Length);
        }

        [Fact]
        public void AboutStringsVerbatimStringsCanHandleFlexibleQuoting()
        {
            var strA = @"Verbatim Strings can handle both ' and "" characters (when escaped)";
            var strB = "Verbatim Strings can handle both ' and \" characters (when escaped)";
            Assert.Equal(FILL_ME_IN, strA.Equals(strB));
        }

        [Fact]
        public void AboutStringsVerbatimStringsCanHandleMultipleLinesToo()
        {
            //Tip: What you create for the literal string will have to 
            //escape the newline characters. For Windows, that would be
            // \r\n. If you are on non-Windows, that would just be \n.
            //We'll show a different way next.
            var verbatimString = @"I
am a
broken line";
            Assert.Equal(20, verbatimString.Length);
            var literalString = FILL_ME_IN;
            Assert.Equal(literalString, verbatimString);
        }

        [Fact]
        public void AboutStringsACrossPlatformWayToHandleLineEndings()
        {
            //Since line endings are different on different platforms
            //(\r\n for Windows, \n for Linux) you shouldn't just type in
            //the hardcoded escape sequence. A much better way
            //(We'll handle concatenation and better ways of that in a bit)
            var literalString = "I" + System.Environment.NewLine + "am a" + System.Environment.NewLine + "broken line";
            var vebatimString = FILL_ME_IN;
            Assert.Equal(literalString, vebatimString);
        }

        [Fact]
        public void AboutStringsPlusWillConcatenateTwoStrings()
        {
            var str = "Hello, " + "World";
            Assert.Equal(FILL_ME_IN, str);
        }

        [Fact]
        public void AboutStringsPlusConcatenationWillNotModifyOriginalStrings()
        {
            var strA = "Hello, ";
            var strB = "World";
            var fullString = strA + strB;
            Assert.Equal(FILL_ME_IN, strA);
            Assert.Equal(FILL_ME_IN, strB);
        }

        [Fact]
        public void AboutStringsPlusEqualsWillModifyTheTargetString()
        {
            var strA = "Hello, ";
            var strB = "World";
            strA += strB;
            Assert.Equal(FILL_ME_IN, strA);
            Assert.Equal(FILL_ME_IN, strB);
        }

        [Fact]
        public void AboutStringsStringsAreReallyImmutable()
        {
            //So here's the thing. Concatenating strings is cool
            //and all. But if you think you are modifying the original
            //string, you'd be wrong. 

            var strA = "Hello, ";
            var originalString = strA;
            var strB = "World";
            strA += strB;
            Assert.Equal(FILL_ME_IN, originalString);

            //What just happened? Well, the string concatenation actually
            //takes strA and strB and creates a *new* string in memory
            //that has the new value. It does *not* modify the original
            //string. This is a very important point - if you do this kind
            //of string concatenation in a tight loop, you'll use a lot of memory
            //because the original string will hang around in memory until the
            //garbage collector picks it up. Let's look at a better way
            //when dealing with lots of concatenation
        }

        [Fact]
        public void AboutStringsYouDoNotNeedConcatenationToInsertVariablesInAString()
        {
            var world = "World";
            var str = String.Format("Hello, {0}", world);
            Assert.Equal(FILL_ME_IN, str);
        }

        [Fact]
        public void AboutStringsAnyExpressionCanBeUsedInFormatString()
        {
            var str = String.Format("The square root of 9 is {0}", Math.Sqrt(9));
            Assert.Equal(FILL_ME_IN, str);
        }

        [Fact]
        public void AboutStringsStringsCanBePaddedToTheLeft()
        {
            //You can modify the value inserted into the result
            var str = string.Format("{0,3:}", "x");
            Assert.Equal(FILL_ME_IN, str);
        }

        [Fact]
        public void AboutStringsStringsCanBePaddedToTheRight()
        {
            var str = string.Format("{0,-3:}", "x");
            Assert.Equal(FILL_ME_IN, str);
        }

        [Fact]
        public void AboutStringsSeperatorsCanBeAdded()
        {
            var str = string.Format("{0:n}", 123456);
            Assert.Equal(FILL_ME_IN, str);
        }

        [Fact]
        public void AboutStringsCurrencyDesignatorsCanBeAdded()
        {
            var str = string.Format("{0:C}", 123456);
            Assert.Equal(FILL_ME_IN, str);
        }

        [Fact]
        public void AboutStringsNumberOfDisplayedDecimalsCanBeControled()
        {
            var str = string.Format("{0:.##}", 12.3456);
            Assert.Equal(FILL_ME_IN, str);
        }

        [Fact]
        public void AboutStringsMinimumNumberOfDisplayedDecimalsCanBeControled()
        {
            var str = string.Format("{0:.00}", 12.3);
            Assert.Equal(FILL_ME_IN, str);
        }

        [Fact]
        public void AboutStringsBuiltInDateFormaters()
        {
            var str = string.Format("{0:t}", DateTime.Parse("12/16/2011 2:35:02 PM"));
            Assert.Equal(FILL_ME_IN, str);
        }

        [Fact]
        public void AboutStringsCustomDateFormaters()
        {
            var str = string.Format("{0:t m}", DateTime.Parse("12/16/2011 2:35:02 PM"));
            Assert.Equal(FILL_ME_IN, str);
        }
        //These are just a few of the formatters available. Dig some and you may find what you need.

        [Fact]
        public void AboutStringsABetterWayToConcatenateLotsOfStrings()
        {
            //Concatenating lots of strings is a Bad Idea(tm). If you need to do that, then consider StringBuilder.
            var strBuilder = new System.Text.StringBuilder();
            strBuilder.Append("The ");
            strBuilder.Append("quick ");
            strBuilder.Append("brown ");
            strBuilder.Append("fox ");
            strBuilder.Append("jumped ");
            strBuilder.Append("over ");
            strBuilder.Append("the ");
            strBuilder.Append("lazy ");
            strBuilder.Append("dog.");
            var str = strBuilder.ToString();
            Assert.Equal(FILL_ME_IN, str);

            //String.Format and StringBuilder will be more efficent that concatenation. Prefer them.
        }


        [Fact]
        public void AboutStringsStringBuilderCanUseFormatAsWell()
            //look at what it is- not what you expect it to be!
        {
            var strBuilder = new System.Text.StringBuilder();
            strBuilder.AppendFormat("{0} {1} {2}", "The", "quick", "brown");
            strBuilder.AppendFormat("{0} {1} {2}", "jumped", "over", "the");
            strBuilder.AppendFormat("{0} {1}.", "lazy", "dog");
            var str = strBuilder.ToString();
            Assert.Equal(FILL_ME_IN, str);
        }

        [Fact]
        public void AboutStringsLiteralStringsInterpretsEscapeCharacters()
        {
            var str = "\n";
            Assert.Equal(FILL_ME_IN, str.Length);
        }

        [Fact]
        public void AboutStringsVerbatimStringsDoNotInterpretEscapeCharacters()
        {
            var str = @"\n";
            Assert.Equal(FILL_ME_IN, str.Length);
        }

        [Fact]
        public void AboutStringsVerbatimStringsStillDoNotInterpretEscapeCharacters()
        {
            var str = @"\\\";
            Assert.Equal(FILL_ME_IN, str.Length);
        }

        [Fact]
        public void AboutStringsYouCanGetASubstringFromAString()
        {
            var str = "Bacon, lettuce and tomato";
            Assert.Equal(FILL_ME_IN, str.Substring(19));
            Assert.Equal(FILL_ME_IN, str.Substring(7, 3));
        }

        [Fact]
        public void AboutStringsYouCanGetASingleCharacterFromAString()
        {
            var str = "Bacon, lettuce and tomato";
            Assert.Equal(FILL_ME_IN, str[0]);
        }

        [Fact]
        public void AboutStringsSingleCharactersAreRepresentedByIntegers()
        {
            Assert.Equal(97, 'a');
            Assert.Equal(98, 'b');
            Assert.Equal(FILL_ME_IN, 'b' == ('a' + 1));
        }

        [Fact]
        public void AboutStringsStringsCanBeSplit()
        {
            var str = "Sausage Egg Cheese";
            string[] words = str.Split();
            Assert.Equal(FILL_ME_IN, words[1]);
        }

        [Fact]
        public void AboutStringsStringsCanBeSplitUsingCharacters()
        {
            var str = "the:rain:in:spain";
            string[] words = str.Split(':');
            Assert.Equal(FILL_ME_IN, words[0]);
        }


        [Fact]
        public void AboutStringsStringsCanBeSplitUsingRegularExpressions()
        {
            var str = "the:rain:in:spain";
            var regex = new System.Text.RegularExpressions.Regex(":");
            string[] words = regex.Split(str);
            Assert.Equal(FILL_ME_IN, words[3]);

            //A full treatment of regular expressions is beyond the scope
            //of this tutorial. The book "Mastering Regular Expressions"
            //is highly recommended to be on your bookshelf
        }

        [Fact]
        public void AboutStringsStringFunctions()
        {
            string test = "This Is A Test!";
            string testLower = test.ToLower();
            Assert.Equal(FILL_ME_IN, testLower);
        }





    }
}
