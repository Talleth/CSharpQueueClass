using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            QueueClass queueClass = new QueueClass();

            queueClass.Enqueue("Bonnai");
            queueClass.Enqueue("Tim");
            queueClass.Enqueue("Jerry");
            queueClass.Enqueue("Tom");

            Console.WriteLine();
            Console.WriteLine("Front item in the queue: " + queueClass.PeekFront());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Back item in the queue: " + queueClass.PeekBack());
            Console.WriteLine();
        }
    }

    public class QueueClass
    {
        private LinkedList<string> m_queue;

        public QueueClass()
        {
            this.m_queue = new LinkedList<string>();
        }

        public string PeekFront()
        {
            return this.m_queue.First.Value;
        }

        public string PeekBack()
        {
            return this.m_queue.Last.Value;
        }

        public void Enqueue(string data)
        {
            this.m_queue.AddLast(data);
        }

        public string Dequeue()
        {
            string result = this.m_queue.First.Value;

            this.m_queue.RemoveLast();

            return result;
        }
    }
}
