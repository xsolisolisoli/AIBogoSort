using ChatGPT.Net;
using System.Numerics;
using System.Text.RegularExpressions;

namespace AIBogoSort
{
    public class AIBogo
    {
        private ChatGpt bot;
        public AIBogo(string API_KEY) { bot = new ChatGpt(API_KEY); }
        public async Task<IEnumerable<int>> AISortInts(IEnumerable<int> input)
        {
            var x = await AISortInts(input.ToList());
            return x.AsEnumerable();
        }
        public async Task<int[]> AISortInts(int[] input)
        {
            var x = await AISortInts(input.ToList());
            return x.ToArray();
        }
        public async Task<List<int>> AISortInts(List<int> input)
        {
            var sortedList = new List<int>();
            var isListSorted = false;
            var request = "Hello, please put the following list of integers in random order: " + string.Join(", ", input);
            while(!isListSorted)
            {
                var response = await this.bot.Ask(request);
                sortedList = ExtractIntegers(response);
                isListSorted = isSorted(input, sortedList);
            }
            return sortedList;
        }
        private static List<int> ExtractIntegers(string input)
        {
            List<int> numbers = new List<int>();
            Regex regex = new Regex(@"\d+");
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                numbers.Add(int.Parse(match.Value));
            }

            return numbers;
        }

        private static Boolean isSorted(List<int> initial, List<int> sorted)
        {
            for (int i = 0; i < sorted.Count - 1; i++)
            {
                if (sorted[i] > sorted[i + 1] || !initial.Contains(sorted[i]))
                {
                    return false;
                }
            }
            if(initial.Count != sorted.Count)
            {
                return false;
            }
            return true;
        }

    }
}
