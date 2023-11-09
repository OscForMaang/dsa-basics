/*
 * LIFO : Last in first out
 *  For empty stack : top = -1
 * Push: To add an element
 *      top is increased by 1
 *      New index is placed at index top
 * Pop : Removing element
 *      Element at index top taken out
 *      top is decreased by 1
 * Peek Element : Return element at the top
 */

// InBuild examples

using Stack.Problems;

RainWaterTrapping rain = new RainWaterTrapping();
Console.WriteLine(rain.Trap(new int[] {3,0,0,2,0,4}));