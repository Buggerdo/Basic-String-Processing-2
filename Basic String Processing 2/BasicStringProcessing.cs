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
            } while(Continue());

            Clear();

            foreach(var item in words)
            {
                Write(item + " ");
            }
            WriteLine("\nPress any key to continue.");
            ReadKey();
        }


        private void GetWord()
        {
            Write("Enter some text: ");
            words.Add(ReadLine());
        }

        private static string[] yes = { "yes", "y", "yup" };
        private static string[] no = { "no", "n", "nope" };

        private bool Continue()
        {
            do
            {
                Write("Would you like to continue Y/N?");
                string input = ReadLine().ToLower().Trim();
                if(yes.Contains(input)) return true;
                else if(no.Contains(input)) return false; 
            } while(true);
        }
    }
}
