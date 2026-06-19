namespace תרגיל_כיתה_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shape = new Shape[3];
            shape[0] = new Shape("yellow");
            shape[1] = new Circle("White");
            shape[2] = new Rectangle("Green");

            for (int i = 0; i < shape.Length; i++)
            {
                Console.WriteLine();
                shape.Drow(i);
            }
}
}
}
