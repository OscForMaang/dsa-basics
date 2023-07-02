using System.Security.Cryptography.X509Certificates;

namespace Queue.Implementation
{
    internal class Queue
    {
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

        int[] queue;
        int front, rear;
        public Queue()
        {
            front = rear = -1;
            queue = new int[10];
        }

        public Queue(int size)
        {
            queue = new int[size];
            front = rear = -1;
        }

        /// <summary>
        /// Returns true of the queue if empty otherwise false
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return (front == -1 || front == rear + 1);
        }

        /// <summary>
        /// Returns true of the queue if full otherwise false
        /// </summary>
        /// <returns></returns>
        public bool IsFull()
        {
            return rear == queue.Length - 1 ;
        }

        /// <summary>
        /// Return the size of the queue
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            if (IsEmpty())
                return 0;
            return rear - front + 1 ;
        }

        /// <summary>
        /// Insert an element in the queue
        /// </summary>
        /// <param name="key"></param>
        public void Enqueue(int key)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is overflow");
                return;
            }

            if (front == -1)
                front = 0;
            rear = rear + 1;
            queue[rear] = key;
        }

        /// <summary>
        /// Delete an element from the queue
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is underflow");
            }

            int key = queue[front];
            front = front + 1;
            return key;
        }

        /// <summary>
        /// returns the queue element from front
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is underflow");
            }
            return queue[front];
        }

        /// <summary>
        /// Print the elements of the queue
        /// </summary>
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Console.WriteLine("Queue is :\n\n");
            for (int i = front; i <= rear; i++)
            {
                Console.WriteLine(queue[i] + " ");
            }
        }
    }
}
