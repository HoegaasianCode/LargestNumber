
using System.Collections.Generic;

namespace LargestNumber1
{
    public class Calc
    {
        private readonly int[][] _arrArr;
        private readonly List<int> _intList;

        public Calc(int[][] arrArr)
        {
            _arrArr = arrArr;
            _intList = new List<int>();
        }

        public int[] Calc1()
        {
            foreach (var arr in _arrArr)
            {
                int? x = null;
                for (int i = 0; i < arr.Length; i++)
                {
                    int j = arr[i];
                    if (!x.HasValue || j > x.Value) x = j;
                }
                _intList.Add((int)x);
            }
            return _intList.ToArray();
        }
    }
}
