namespace repo
{
    public class Beta2010
    {
        public static int execute(int[] A)
        {
            int n = A.Length;

            /*
             * First mark all the potential intersection points :
             * A[i] + i = j means that A[j] is potentially an intersection point, if j > n then j = n - 1;
             * Afterward, compute the number discs which the borders end before or on top of A[j]
             * Note that if the border ( center + radius ) is upper than n , it's considered as (n - 1) thus end on top of A[n-1]
             *  
            */
            int[] cumulative = new int[n]; 

            for (int i = 0; i < n; i++)
            {
                int index = i + (long)A[i] >= n ? n - 1 : i + A[i];
                cumulative[index]++;
            }

            for (int i = 1; i < n; i++)
                cumulative[i] +=  cumulative[i-1];
            

            /*
             * Second part of the algo:
             * we start off by computing the number of possible connections between al discs
             * and then substruct the number that is smaller than the positive (i - A[i]) 
            */
            long intersections = (long)n * (n - 1) / 2; 

            for (int i = 0; i < n; i++)
            {

                intersections -= A[i] > i
                                 ? 0
                                 : i - A[i] > 0 ? cumulative[i - A[i] - 1] : 0;
            }

            return intersections > 10E6 ? -1 : (int)intersections;
        }
    }
}