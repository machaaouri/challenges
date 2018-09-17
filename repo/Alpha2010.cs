using System.Collections.Generic;

namespace repo
{
    /*
     *  A non-empty array A consisting of N integers is given.
     *  The first covering prefix of array A is the smallest integer P such that 0≤P<N 
     *  and such that every value that occurs in array A also occurs in sequence A[0], A[1], ..., A[P].
     *  For example, the first covering prefix of the following 5−element array A:
     *  A[0] = 2
     *  A[1] = 2
     *  A[2] = 1
     *  A[3] = 0
     *  A[4] = 1
     *  is 3, because sequence [ A[0], A[1], A[2], A[3] ] equal to [2, 2, 1, 0], contains all values that occur in array A.
     * 
    */

    public class Alpha2010
    {
        // time complexity: O(N) or O(N* log(N))

        public static int execute(int[] A)
        {
            int coveringPrefix = 0;
            HashSet<int> values = new HashSet<int> { A[0] }; 

            for(int i = 1; i < A.Length; i++)
            {
                if (values.Contains(A[i])) continue;

                values.Add(A[i]);
                coveringPrefix = i;
            }

            return coveringPrefix;


        }
    }
}
