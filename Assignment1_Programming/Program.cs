using System;

namespace Assignment1_F19
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 100;
            printSelfDividingNumbers(a, b);

            int n2 = 10;
            printSeries(n2);

            int n3 = 7;
            printTriangle(n3);

            int[] J = new int[] { 1, 3, 2 };
            int[] S = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };
            int r4 = numJewelsInStones(J, S);
            Console.WriteLine(r4);

            int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arr2 = new int[] { 1, 2, 5, 6, 7, 8, 9, 10 };
            int[] r5 = getLargestCommonSubArray(arr1, arr2);
            Console.WriteLine(r5);
            
            solvePuzzle();
        }

        public static void printSelfDividingNumbers(int x, int y)
        {
            try
            {
                // Write your code here
                for (int i = x; i <= y; i++)
                {
                    int j = i;
                    int temp = 1;
                    while( j > 0)
                    {
                        int k = j % 10;
                        if (k == 0)
                        {
                            j = j / 10;
                            temp = 0;
                            break;
                        }


                        if (i % k != 0)
                        {
                            temp = 0;
                            break;
                        }
                         j = j / 10;

                    }
                    if (temp == 1)
                        Console.Write(i+ " ");                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
            }
        }

        public static void printSeries(int n)
        {
            try
            {
                // Write your code here
                Console.WriteLine();
                int k = 0;   //Variable to track the count
                for(int i = 0; i < n; i++)
                {
                    for( int j = 0; j < i; j++) {
                        Console.Write(i + " ");
                        k = k + 1;
                        if (k == n) break;
                    }
                    if(k == n) break;
                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSeries()");
            }
        }

        public static void printTriangle(int n)
        {
            try
            {
                // Write your code here
                Console.WriteLine("\n");
                for (int i = n ; i >= 1; i--)
                {
                    for (int s = 0; s < n - i; s++)
                    {
                        Console.Write("\t ");
                    }
                    for (int j = 2 * i - 1; j >= 1; j--)
                        {
                            Console.Write("\t*");
                        }
                        Console.Write("\n");
                          
                }


                
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static int numJewelsInStones(int[] J, int[] S)
        {
            try
            {
                // Write your code here
                Console.WriteLine();
                int count = 0;
                foreach( int i in S)
                {
                    
                    foreach (int j in J)
                    {
                        if (i == j){
                            count = count + 1;

                       
                        }
                    }
                }
                return count;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing numJewelsInStones()");
            }

            return 0;
        }

        public static int[] getLargestCommonSubArray(int[] a, int[] b)
        {
            int i = 0;

            int j = 0;

            int starting_index = 0;

            int temp_index = 0;

            int count = 0;

            int temp_count = 0;

            try
            {
                

                while (i < a.Length && j < b.Length)
                {

                    if (a[i] == b[j])

                    {
                        if (temp_count == 0) { temp_index = i; }

                        i++; j++;

                        temp_count = temp_count + 1;

                    }
                    else
                    {



                        if (temp_count >= count)
                        {

                            count = temp_count;

                            starting_index = temp_index;



                        }

                        temp_count = 0;

                        i++;

                    }

                   
                }

                if (temp_count >= count)
                {

                    count = temp_count;

                    temp_count = 0;

                    starting_index = temp_index;

                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
            }
            int[] c = new int[count];
            int p = 0;

            for( int k = starting_index; k < starting_index + count; k++)
            {
                c[p] = a[k];
                p = p + 1;
            }
            return c; // return the actual array
        }

        public static void solvePuzzle()
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing solvePuzzle()");
            }
        }
    }
}

