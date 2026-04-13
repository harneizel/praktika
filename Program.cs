namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //contains

            string word = "Hello";
            Console.WriteLine(word.Contains("ll"));

            if (word.Contains("lo"))
            {
                Console.WriteLine("Success");
            }
            else 
            { 
                Console.WriteLine("Error");
            }

            char[] example = { 'a', '.', '0' };
            Console.WriteLine(example.Contains('a'));

            // Replace
            string text = "cat dog dog love";
            Console.WriteLine(text.Replace("dog", "more cats"));

            // Trim
            string word2 = "   Hello";
            Console.WriteLine(word2.Trim(new char[] {' ', ','}));

            // SPlit
            string text2 = "Hello, my dear 2 friends!";
            string[] dirtyWords = text2.Split(' ');
            foreach (string m in dirtyWords) { 
                Console.WriteLine(m);
            }

            // Join
            string text3 = String.Join(" ", dirtyWords);
            Console.WriteLine(text3);

            // IsDigit/IsLetter
            char s = 'a';
            Console.WriteLine(Char.IsDigit(s));
            Console.WriteLine(Char.IsLetter(s));

            // ToUpper/ToLower
            string word3 = "Hello";
            Console.WriteLine(word3.ToLower());
            Console.WriteLine(word3.ToUpper());

        }
    }
}
