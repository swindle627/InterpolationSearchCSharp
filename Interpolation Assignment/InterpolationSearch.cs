using System;
using System.Collections.Generic;
using System.Text;

namespace Interpolation_Assignment
{
    class InterpolationSearch
    {
        public bool found; // indicates if key value is found or not
        public int index; // index of target value in list. value isn't in list -1 returned
        public int divisions; // number of divisions performed to find the value

        public InterpolationSearch(int[] values, int key)
        {
            found = false;
            index = -1;
            divisions = 0;
            int low = 0;
            int high = values.Length - 1; 
            int pos;

            // The formula for estimating the position of the key using interpolation search is:
            // low + ((key - values[low]) * (high - low)) / (values[high] - values[low])
            // if the element at the position resulting from that formula is equal to the key the search stops
            // if it is greater than the key the search continues with the first part
            // if it is less than the key the search continues with the second part
            while (values[high] != values[low] && key >= values[low] && key <= values[high])
            {
                pos = low + ((key - values[low]) * (high - low)) / (values[high] - values[low]);

                if(key == values[pos])
                {
                    found = true;
                    index = pos;
                    break;
                }
                else if(key < values[pos])
                {
                    high = pos - 1;
                }
                else if(key > values[pos])
                {
                    low = pos + 1;
                }

                divisions++;
            }
        }
    }
}
