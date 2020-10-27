// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kirti Swaraj"/>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace StacksAndQueueUsingLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            /// UC 1
            Stack stack = new Stack();
            stack.PushToTop(70);
            stack.PushToTop(30);
            stack.PushToTop(56);
            stack.Display();
            ///UC2
            stack.IsEmpty();
            stack.Display();
            /// UC 3
            Queue queue = new Queue();
           queue.Enqueue(56);
           queue.Enqueue(30);
           queue.Enqueue(70);
           queue.Display();
           Console.ReadKey();
            }
    }
}
