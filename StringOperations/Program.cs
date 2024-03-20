namespace StringOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = string.Empty;
            Console.WriteLine("Enter sentence");
            sentence = Console.ReadLine();
            // find no of characters
            Console.WriteLine(sentence.Length);
            // find no of words
            string[] words = sentence.Split(new char[] { ' ','.' });
            Console.WriteLine(words.Length);
            Console.WriteLine("Enter substring to search");
            string subst = Console.ReadLine();
            Console.WriteLine(sentence.Contains(subst));
            Console.WriteLine(sentence.Substring(0, 7));
            Console.WriteLine(sentence.StartsWith('A'));
            Console.WriteLine(sentence.Substring(0,1));
            Console.WriteLine(sentence.Substring(sentence.Length-1, -1));
            //Console.WriteLine(sentence.Reverse());
            char[] charArray = sentence.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(new string(charArray));
            Console.WriteLine();
            string.Concat("aaa", "bbb");
        }

    }
}