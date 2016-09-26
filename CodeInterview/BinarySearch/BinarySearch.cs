using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BinarySearchExce
{
    public class BinarySearch
    {
        private int left;
        private int right;
        private int mid;
        private int[] _array;
        private int _value;

        public BinarySearch(int[] array, int value)
        {
            this._array = array;
            this._value = value;
            this.left = 0;
            this.right = _array.Length - 1;
        }

        public int Search()
        {
            while (left <= right)
            {
                mid = (left + right) / 2;

                if (_array[mid] > _value)
                {
                    // Go Left
                    right = mid - 1;
                }
                else if (_array[mid] < _value)
                {
                    // Go Right
                    left = mid + 1;
                }
                else
                {
                    // Find it
                    return mid;
                }
            }

            return left;
        }

    }
}
