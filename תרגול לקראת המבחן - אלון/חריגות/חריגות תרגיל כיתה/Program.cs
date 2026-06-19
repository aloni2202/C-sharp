namespace חריגות_תרגיל_כיתה
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isCorrect = true;
            int[] array1 = new int[3];
            int[] array2 = new int[3];
            int[] array3 = new int[3];

            try
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    Console.WriteLine("Please enter num :");
                    array1[i] = int.Parse(Console.ReadLine());
                    array2[array2.Length - i - 1] = array1[i];
                }
                for (int i = 0; i < array1.Length; i++)
                {
                    array3[i] = array1[i] / array2[i];
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.GetType().Name + "its unpossible devide by zero ");
                isCorrect = false;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.GetType().Name + "please enter num in format");
                isCorrect = false;
            }

            catch (OverflowException ex)
            {
                Console.WriteLine(ex.GetType().Name + $"value can be between : {int.MinValue} to {int.MaxValue}");
                isCorrect = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name + "invalid value");
            }
            finally
            {
                if (isCorrect)
                {
                    foreach (int i in array3)
                    {
                        Console.WriteLine($"res : {i}");
                    }
                    Console.WriteLine("Please enter a key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
