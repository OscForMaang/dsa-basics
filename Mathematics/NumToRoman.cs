namespace Mathematics
{
    internal class NumToRoman
    {
        Dictionary<int, string> romanMap = new Dictionary<int, string>(){
           {1000, "M"},
           {900, "CM"},
           {500, "D"},
           {400, "CD"},
           {100, "C"},
           {90, "XC"},
           {50, "L"},
           {40, "XL"},
           {10, "X"},
           {9, "IX"},
           {5, "V"},
           {4, "IV"},
           {1, "I"}
        };

        public string IntToRoman(int num)
        {
            string res = string.Empty;
            foreach (int number in romanMap.Keys)
            {
                string roman = romanMap[number];
                if(num / number  > 0)
                {
                    int count = num / number;
                    num = num % number;
                    while(count > 0)
                    {
                        count--;
                        res += roman; 
                    }  
                }

            }
            return res;
        }
    }
}
