using System;
using System.Collections.Generic;
using Combinatorics.Collections;
using System.Linq;

namespace SmartSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] mostPopularNumbers = { 13, 24, 20, 18, 28, 4, 27, 39, 32, 34 };
            //int[] leastPopularNumbers = { 19, 12, 8, 6, 44, 30, 36, 33, 2, 16 };
            var selectedNumbers = new List<SelectedNumber>();
            selectedNumbers.Add(new SelectedNumber() { Number = 1, MustBeIncluded = false });
            selectedNumbers.Add(new SelectedNumber() { Number = 2, MustBeIncluded = false });
            selectedNumbers.Add(new SelectedNumber() { Number = 3, MustBeIncluded = false });
            selectedNumbers.Add(new SelectedNumber() { Number = 4, MustBeIncluded = false });
            selectedNumbers.Add(new SelectedNumber() { Number = 5, MustBeIncluded = false });
            selectedNumbers.Add(new SelectedNumber() { Number = 6, MustBeIncluded = false });
            selectedNumbers.Add(new SelectedNumber() { Number = 7, MustBeIncluded = false });
            selectedNumbers.Add(new SelectedNumber() { Number = 8, MustBeIncluded = false });
            selectedNumbers.Add(new SelectedNumber() { Number = 9, MustBeIncluded = false });
            selectedNumbers.Add(new SelectedNumber() { Number = 10, MustBeIncluded = false });
            selectedNumbers.Add(new SelectedNumber() { Number = 11, MustBeIncluded = false });
            selectedNumbers.Add(new SelectedNumber() { Number = 12, MustBeIncluded = false });
            selectedNumbers.Add(new SelectedNumber() { Number = 13, MustBeIncluded = false });
            selectedNumbers.Add(new SelectedNumber() { Number = 14, MustBeIncluded = false });
            selectedNumbers.Add(new SelectedNumber() { Number = 15, MustBeIncluded = false });

            int NO_OF_GAMES = 80;

            const int NUMBERS_PER_GAME = 6;

            var allCombos = new Combinations<int>(selectedNumbers.Select(x => x.Number).ToArray(), NUMBERS_PER_GAME);

            Console.WriteLine(String.Format("Combinations of {0} choose 6: size = {1}", String.Join(',', selectedNumbers.Select(x => x.Number).ToArray()), allCombos.Count));
            Console.ReadKey();

            foreach (IList<int> combo in allCombos)
            {
                Console.WriteLine(String.Format("{0}, {1}, {2}, {3}, {4}, {5}", combo[0], combo[1], combo[2], combo[3], combo[4], combo[5]));
            }

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++");

            var selectedCombos = new List<List<int>>();
            var randomIndexes = new List<int>();
            var random = new Random();
            for (int i = 0; i < NO_OF_GAMES; i++)
            {
                int index = random.Next(allCombos.Count());
                randomIndexes.Add(index);
            }

            randomIndexes.Sort();

            for (int i = 0; i < NO_OF_GAMES; i++)
            {
                var combo = allCombos.ElementAt(randomIndexes[i]);
                selectedCombos.Add(combo.ToList());
            }

            foreach (IList<int> combo in selectedCombos)
            {
                Console.WriteLine(String.Format("{0}, {1}, {2}, {3}, {4}, {5}", combo[0], combo[1], combo[2], combo[3], combo[4], combo[5]));
            }

            Console.ReadKey();
        }

        public int DetermineComboWeighting()
        {
            return 0;
        }
    }

    public class SelectedNumber
    {
        public int Number { get; set; }
        public bool MustBeIncluded { get; set; }
    }
}
