using static System.Console;


namespace Basic_String_Processing_2
{
    internal class BasicStringProcessing
    {
        List<string> words = new List<string>();
        public BasicStringProcessing()
        {
            do
            {
                GetWord(); 
            } while(Continue("Would you like to continue Y/N?"));
            Clear();

            foreach(var item in words)
            {
                Write(item + " ");
            }
            WriteLine("\n\nPress any key to continue.");
            ReadKey();
        }

        private void GetWord()
        {
            Write("Enter some text: ");
            words.Add(ReadLine());
        }

        private static string[] yes = { "yes", "y", "yup" };
        private static string[] no = { "no", "n", "nope" };

        public static bool Continue(string description)
        {
            do
            {
                Write(description);
                string input = ReadLine().ToLower().Trim();
                if(yes.Contains(input)) return true;
                else if(no.Contains(input)) return false; 
            } while(true);
        }
    }
}
