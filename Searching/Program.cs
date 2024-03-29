

using Searching.BinarySearchPractice;

SearchInMatrix matrix = new SearchInMatrix();
int[][] input = new int[][]
{
    new int[] { 1, 3, 5, 7 },
    new int[] {10,11,16,20 },
    new int[] {23,30,34,60 },
};

Console.WriteLine(matrix.SearchMatrix(input, 0));