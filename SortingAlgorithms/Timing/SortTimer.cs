
using System;
using System.Diagnostics;

using SortingAlgorithms.Sorting;

namespace SortingAlgorithms.Timing
{
    public class SortTimer
    {
        public delegate void SortingEvent(SortResult result);
        public event SortingEvent SortingFinished;

        public void TimeSort(ISorter sorter, int[] unsorted)
        {
            var result = new SortResult()
            {
                AlgorithmName = sorter.GetType().Name,
            };

            var watch = Stopwatch.StartNew();

            try
            {
                result.Sorted = sorter.Sort(unsorted);
                watch.Stop();
                result.MillisecondsElapsed = watch.ElapsedMilliseconds;
                result.Status = SortStatus.Completed;
            }
            catch (Exception e)
            {
                result.Status = SortStatus.Failed;
                result.FailedMessage = e.Message;
            }

            SortingFinished(result);
        }
    }
}
