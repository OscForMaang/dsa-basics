using Recursion.Learning;
SubsetProblems problems = new SubsetProblems();

string input = "ABC";
string output = string.Empty;
output = $"{input[0]}";
input = input.Remove(0, 1);
List<string> result = new List<string>();
problems.PermutationWithSpace(result, input, output);
foreach (string str in result)
{
    Console.WriteLine(str);
}
