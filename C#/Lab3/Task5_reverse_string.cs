namespace Task5_string_reverse
{
    internal class Task5_reverse_string
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string to revers it!");
            string mystr = Console.ReadLine();
            string[] stringList = mystr.Split();
            for (int i = stringList.Length - 1; i >= 0; i--)
            {
                Console.Write(stringList[i]);
                if (i > 0)
                    Console.Write(' ');
            }
            /** Another easy way!
              * 
              * string revstr = string.join(" ", mystr.split().Reverse());
              * Console.WriteLine(revstr); 
              */
        }
    }
}
