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

Stack<int> stack = new Stack<int>();
stack.Push(0);
stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Push(5);
int pop = stack.Pop(); // 5 will get popped
Console.WriteLine(pop);
Console.WriteLine(stack.Count); // size of the stack
stack.Pop();
stack.Pop();
stack.Pop();
stack.Pop();
stack.Pop(); // all element are popped 
stack.Pop(); // stack underflow, stack is empty

// pop and push happens with constant time complexity