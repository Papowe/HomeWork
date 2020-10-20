using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4___Solution3
{
    class MyClass
    {
        public int[] arr;

        public MyClass(int elements, int initial, int step)
        {
            arr = new int[elements];
            arr[0] = initial;

            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] + step;
            }
        }
    }
}
