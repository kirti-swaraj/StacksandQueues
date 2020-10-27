using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueueUsingLinkedList
{
    class Queue
    {
        public Node front;

        /// <summary>
        /// UC 3 : Enqueues the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        public void Enqueue(int value)
        {
            Node newNode = new Node(value);
            if (this.front == null)
            {
                this.front = newNode;
            }
            else
            {
                Node temp = this.front;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            Console.WriteLine("{0} enqueued into the queue", value);
        }
        /// <summary>
        /// UC 4 : Dequeues and removes the value at front.
        /// </summary>
        public void Dequeue()
        {
            if (this.front == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Node temp = this.front;
            this.front = this.front.next;
            Console.WriteLine("Dequeued value: " + temp.data);
        }

        /// <summary>
        /// Displays the queue contents from front to rear.
        /// </summary>
        public void Display()
        {
            Node temp = this.front;
            if (temp == null)
                Console.WriteLine("Stack is empty\n");
            else
            {
                Console.Write("\nDisplay:Queue contents from Front to Rear: ");
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine();
            }
        }
    }
}