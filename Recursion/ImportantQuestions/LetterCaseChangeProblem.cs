namespace Recursion.StackImportantQuestions
{
    internal class LetterCaseChangeProblem
    {
        public IList<string> LetterCasePermutation(string s)
        {
            List<string> list = new List<string>();
            HashSet<char> smallChars = new HashSet<char>()
            {
                'a', 'b', 'c', 'd', 'e', 'f',
                'g', 'h', 'i', 'j', 'k', 'l',
                'm', 'n', 'o', 'p', 'q', 'r',
                's', 't', 'u', 'v', 'w', 'x',
                'y', 'z'
            };
            void BackTracking(int start, string result)
            {
                if(start == s.Length)
                {
                    list.Add(result);
                    return;
                }

                char letter = s[start];
                if (Char.IsDigit(letter))
                {
                    BackTracking(start + 1, $"{result}{letter}");
                }
                else
                {
                    string caseChange = string.Empty;
                    if (smallChars.Contains(letter))
                    {
                        caseChange = letter.ToString().ToUpper();
                    }
                    else
                    {
                        caseChange = letter.ToString().ToLower();
                    }

                    BackTracking(start + 1, $"{result}{letter}");
                    BackTracking(start + 1, $"{result}{caseChange}");
                }
            }

            BackTracking(0, string.Empty);
            return list;
        }
    }
}
