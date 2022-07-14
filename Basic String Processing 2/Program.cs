using static Basic_String_Processing_2.BasicStringProcessing;

namespace Basic_String_Processing_2
{
    internal class Program
    {
        static void Main()
        {
            do
            {
                Console.Clear();
                _ = new BasicStringProcessing();
            } while(Continue("Would you like to play again Y/N?"));
        }
    }
}