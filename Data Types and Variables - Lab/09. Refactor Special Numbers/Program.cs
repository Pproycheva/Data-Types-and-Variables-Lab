namespace _09.Refactor_Special_Numbers
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());           
            for (int num = 1; num <= n; num++)
            {
                int obshto = 0;
                int takova = num;
                while (takova > 0)
                {
                    obshto += num % 10;
                    takova = takova / 10;
                }
                bool toe = false;
                toe = (obshto == 5) || (obshto == 7) || (obshto == 11);
                Console.WriteLine(toe); //$"{takova} -> "
            }
        }
    }
}
