using System;

namespace PragmaticUnitTesting
{
    public class Cmp
    {
        public static int Largest(int[] list)
        {
            int index, max = Int32.MinValue;
            if (list.Length == 0)
            {
                throw new ArgumentException("largest:Empty list");
            }
            for (index = 0; index < list.Length; index++)
            {
                if (list[index] > max)
                {
                    max = list[index];
                }
            }

            return max;
        }
    }
}
