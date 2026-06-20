namespace תרגיל_כיתה_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Shape("Yello");
            Circle c1 = new Circle("Brown");
            Rectangle r1 = new Rectangle("Blue");

            Shape [] shapes = new Shape [3]{ s1 ,  c1  , r1};
            foreach (Shape shape in shapes)
            {
                Console.WriteLine();
                shape.Draw();
            }
    }
}
}
