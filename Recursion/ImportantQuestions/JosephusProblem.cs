namespace Recursion.StackImportantQuestions
{
    internal class JosephusProblem
    {
        public int FindTheWinner(int n, int k)
        {
            List<int> persons = new List<int>();
            // adding the initial positions of person
            for (int i = 1; i <= n; i++)
            {
                persons.Add(i);
            }
            void FindWinner(int start)
            {
                if (persons.Count == 1)
                {
                    return;
                }
                int personToDie = (start + k - 1) % persons.Count;
                persons.RemoveAt(personToDie);
                FindWinner(personToDie);
            }
            FindWinner(0); ;
            return persons[0];
        }
    }
}
