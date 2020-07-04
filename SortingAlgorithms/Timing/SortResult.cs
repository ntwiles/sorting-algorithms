using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Timing
{
    public class SortResult
    {
        public string AlgorithmName;
        public long MillisecondsElapsed;
        public int[] Sorted;
        public SortStatus Status;
        public string FailedMessage;
    }

    public enum SortStatus
    {
        Completed,
        Failed
    }
}
