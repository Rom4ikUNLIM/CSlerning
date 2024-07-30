using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlerning.Chapter4
{
    public class Chapter4_5_1
    {
        public void reWrite()
        {
            int[] originalArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ArraySegment<int> segment1 = new ArraySegment<int>(originalArray, 2, 4);
            ArraySegment<int> segment2 = new ArraySegment<int>(originalArray, 5, 3);
            ArraySegment<int>[] segments = { segment1, segment2 };
            int sum = SumArraySegments(segments);
            Console.WriteLine("Sum of array segments: " + sum);
        }

        public int SumArraySegments(ArraySegment<int>[] value)
        {
            int sum = 0;
            foreach (var s in value)
                for (int i = s.Offset; i < s.Offset + s.Count; i++)
                    sum += s.Array[i];
            return sum;
        }
    }
}
