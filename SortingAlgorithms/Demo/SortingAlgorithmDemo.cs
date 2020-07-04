using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using SortingAlgorithms.Sorting;
using SortingAlgorithms.Timing;

namespace SortingAlgorithms.Demo
{
    public class SortingAlgorithmDemo
    {
        private const int UNSORTED_ARRAY_SIZE = 30000;

        private List<ISorter> sorters;

        public SortingAlgorithmDemo()
        {
            sorters = SortingBattery.GetAllSorters();
        }

        public async void RunAsync()
        {
            writeWelcomeMessage();
            await performSortsAsync();
            writeFinishedMessage();
        }

        private void writeWelcomeMessage()
        {
            Console.WriteLine($"We will sort a shuffled list of ints of size {UNSORTED_ARRAY_SIZE.ToString("N0")}.\n");
            Console.WriteLine("We'll be using the following algorithms:\n");
            sorters.ForEach(s => { Console.WriteLine(s.GetType().Name); });
            Console.WriteLine();
            Console.WriteLine("Less optimal algorithms may take some time to finish.\n\nPlease wait...\n");
        }

        private void writeFinishedMessage()
        {
            Console.WriteLine("All done! Thanks for trying this demo.");
        }

        private async Task performSortsAsync()
        {
            int[] unsortedArray = RandomArrayGenerator.GenerateUnsorted(UNSORTED_ARRAY_SIZE);

            var timer = new SortTimer();
            timer.SortingFinished += OnSortFinished;

            List<Task> tasks = new List<Task>();

            foreach (ISorter sorter in sorters)
            {
                tasks.Add(Task.Run(() => timer.TimeSort(sorter, unsortedArray)));
            }

            await Task.WhenAll(tasks);
        }

        private void OnSortFinished(SortResult result)
        {
            printResult(result);
        }

        private void printResult(SortResult result)
        {
            if (result.Status == SortStatus.Completed)
            {
                Console.WriteLine($"{result.AlgorithmName} finished.");
                Console.WriteLine($"  Duration: {result.MillisecondsElapsed}ms");
            }
            else
            {
                Console.WriteLine($"{result.AlgorithmName} failed.");
                Console.WriteLine($"  Reason: {result.FailedMessage}");
            }

            Console.WriteLine();
        }
    }
}
