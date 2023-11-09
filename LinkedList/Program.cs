// c# Linked List

int[] digits = new int[]{9 };

int length = digits.Length - 1;
int sum = (digits[length] + 1) % 10;
int carry = (digits[length] + 1) / 10;
digits[length] = sum;
for (int i = length - 1; i >= 0; i--)
{
    sum = (digits[i] + carry) % 10;
    carry = (digits[i] + carry) / 10;
    digits[i] = sum;
}

if (carry == 0)
{
    
}

// WHEN CARRY IS NOT ZERO, NUMBER OF Digits are going to increase by 1
int[] ans = new int[length + 2];
ans[0] = carry;
for (int i = 1; i <= length; i++)
{
    ans[i] = digits[i - 1];
}

Console.WriteLine(String.Join(' ', ans));