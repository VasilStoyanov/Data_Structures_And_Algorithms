namespace DSA_Jedi_Master
{
    using System;
    using System.Text;

    public class Startup
    {
        internal const char JediMasterFirstLetter = 'm';
        internal const char JediKnightFirstLetter = 'k';

        public static void Main()
        {
            int numberOfJedi = int.Parse(Console.ReadLine());
            string[] allJedi = Console.ReadLine().Split(' ');
            string result = ProcessData(numberOfJedi, allJedi);

            Console.WriteLine(result.ToString().Trim());
        }

        internal static string ProcessData(int numberOfAllJedi, string[] allJediToBeProcessed)
        {
            int numberOfJedi = numberOfAllJedi;

            // Creates shallow copy of the string array.
            // The method will use the copy, not the original.
            string[] allJedi = new string[allJediToBeProcessed.Length];
            allJediToBeProcessed.CopyTo(allJedi, 0);

            var jediMasters = new StringBuilder();
            var jediKnights = new StringBuilder();
            var padawans = new StringBuilder();
            for (int i = 0; i < numberOfJedi; i++)
            {
                if (allJedi[i][0] == JediMasterFirstLetter)
                {
                    jediMasters.Append(allJedi[i] + ' ');
                }
                else if (allJedi[i][0] == JediKnightFirstLetter)
                {
                    jediKnights.Append(allJedi[i] + ' ');
                }
                else
                {
                    padawans.Append(allJedi[i] + ' ');
                }
            }

            var capacity = jediMasters.Capacity + jediKnights.Capacity + padawans.Capacity;
            var result = new StringBuilder(capacity);
            result.Append(jediMasters)
                .Append(jediKnights)
                .Append(padawans);

            return result.ToString();
        }
    }
}
