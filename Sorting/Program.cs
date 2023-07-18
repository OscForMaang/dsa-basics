using Sorting.CyclicSort;

CyclicSort cyclic = new CyclicSort();
int[] arr = new int[] { 5, 3, 4, 1, 2 };
cyclic.Sort(arr);
Console.WriteLine(String.Join(' ', arr));