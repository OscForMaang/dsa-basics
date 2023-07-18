using System.Collections.Generic;

/*
 * FIFO : First in first out
 * Enqueue: To add an element at rear
 * Dequeue : remove element from front
 * Peek Element : Return element from front
 * Elements are added at rear end and removed at front
 * rear : index of last element of the queue
 * front : index of first element of queue
 * Initially empty queue : Front and rear will be -1
 * Enqueue: 
 *  rear is incremented by 1
 *  New element is inserted at index rear
 *  if we are inserting in an empty queue(front = -1), front will be 0
 * Dequeue: 
 *  Element at index front taken out 
 *  front is incremented by 1
 *  
 *  Important Notes: 
 *      1. If front == rear : there is only one element in the queue, except in initially empty queue
 *      2. Number of elements = rear - front + 1, expect in initially empty queue
 *      3. Queue is empty :
 *          a. Front == -1
 *          b. front = rear + 1
 *      4. Queue is full : 
 *          rear = arraySize - 1
 */


Queue<int> queue = new Queue<int>();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);
queue.Enqueue(5);
queue.Enqueue(6);
Console.WriteLine(queue.Dequeue()); // 1 is removed: FIFO

