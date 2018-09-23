using System;

namespace repo
{
    class Program
    {
        static void Main(string[] args)
        {

            // alpha 2010
            var alpha = new int[] { 2, 2, 1, 0, 2 };
            Console.WriteLine(Alpha2010.execute(alpha));

            // beta 2010
            var beta = new int[] {1,5,2,1,4,0};
            Console.WriteLine(Beta2010.execute(beta));

            Console.ReadKey();
        }
    }
}
