namespace תרגיל_כיתה_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumbersPro(100, 90, 80, 70, 60);
        }

        public static void NumbersPro(params int[] numbers)
        {
            Queue<int> myQueue = new Queue<int>();
            Stack<int> myStack = new Stack<int>();

            foreach (int num in numbers)
            {
                myQueue.Enqueue(num);
            }
            while (myQueue.Count > 0)
            {
                myStack.Push(myQueue.Dequeue());
            }
            while(myStack.Count > 0)
            {
                Console.WriteLine(myStack.Pop()); 
            }
    }
}
}
