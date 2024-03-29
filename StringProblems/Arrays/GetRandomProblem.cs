namespace StringArray.Arrays
{
    internal class GetRandomSet
    {
        HashSet<int> set;
        List<int> list;
        public GetRandomSet()
        {
            set = new HashSet<int>();
            list = new List<int>();
        }
        public bool Insert(int val)
        {
            list.Add(val);
           return set.Add(val);
        }
        public bool Remove(int val)
        {
            list.Remove(val);
            return set.Remove(val);
        }

        public int GetRandom()
        {
            Random r = new Random();
            int random = r.Next(0, set.Count-1);
            return list[random];
        }


    }
}
