/*
 * Heap Tree: 
 *      A Binary tree with below properties: 
 *        1. Structure Property :
 *              All the levels have maximum number of nodes except possibly the last level, In the last level, all the nodes are to the left
 *              Complete Binary tree: H = CeilOf(log(n+1))
 *        2. Heap order Property :
 *              Key in any node N is greater than or equal to the keys in the both children of N
 *              Root node is the height key
 * In heap tree, there is no order maintain between sibling nodes 
 * Max Heap and Min heap
 */



using Heap.Implementation;

var minHeap = new PriorityQueue<string, string>();
minHeap.Enqueue("1", "1");
minHeap.Enqueue("2", "2");
minHeap.Enqueue("3", "3");
//Console.WriteLine(minHeap.Peek());



/*
 * In build C# heap
 */

//var minHeap = new PriorityQueue<int, int>();


//minHeap.Enqueue(1, 1);
//minHeap.Enqueue(2, 2);
//minHeap.Enqueue(3, 3);
//Console.WriteLine(minHeap.Peek());


//var maxHeap = new PriorityQueue<int, int>(new MaxHeapComparer());

//maxHeap.Enqueue(1, 1);
//maxHeap.Enqueue(2, 2);
//maxHeap.Enqueue(3, 3);
//maxHeap.Enqueue(4, 4);
//Console.WriteLine(maxHeap.Peek());
//Console.WriteLine(3.CompareTo(2));
Console.WriteLine(AudienceType.PRODUCTION.ToString().Equals("PrODUCTION",StringComparison.OrdinalIgnoreCase));

List<int> FindClosestElements(int[] arr, int k, int x)
{
    // we need k closest, we need max heap
    PriorityQueue<int, int> heap = new PriorityQueue<int, int>(new MaxHeapComparer());
    // Max heap is required
    for (int i = arr.Length-1; i >= 0; i--)
    {
        heap.Enqueue(arr[i], Math.Abs(arr[i] - x));
        if (heap.Count > k)
        {
            heap.Dequeue();
        }
    }
    List<int> result = new List<int>();
    while (heap.Count > 0)
    {
        result.Add(heap.Dequeue());
    }
    return result;
}

public class MaxHeapComparer : IComparer<int>
{
    public int Compare(int x, int y) => y.CompareTo(x);
}

enum AudienceType
{
    NONE,
    DOGFOOD,
    PRODUCTION
}


