namespace StringArray.DotNetConcepts
{
    internal static class ExtentionMethodExample
    {
        public static string GetListName(this List<string> list, string name)
        {
            return $"{name}-{list.Count}";
        }
    }

    public class MyClass
    {
        public string Print()
        {
            #if DEBUG
                Console.WriteLine("Hello Debug");
            #endif

            List<string> strings = new List<string>() { "" };

            return strings.GetListName("Hello");
        }
    }
}
