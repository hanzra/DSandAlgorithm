using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsArray
{
    public class FindArray
    {
        public int[] NextGreaterElement(int[] findNums, int[] nums)
        {

            int[] result = new int[findNums.Count()];
            int numsLength = nums.Count();

            for (int i = 0; i < findNums.Count(); i++)
            {

                int index = FindIndex(findNums[i], nums);

                if (index < numsLength - 1)
                    result[i] = nums[index + 1] > nums[index] ? nums[index + 1] : -1;
                else
                    result[i] = -1;
            }
            return result;
        }

    }
}
